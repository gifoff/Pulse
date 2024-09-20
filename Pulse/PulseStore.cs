using HtmlAgilityPack;
using Newtonsoft.Json;
using Pulse.Components;
using System.Collections.Concurrent;

namespace Pulse
{
    /// <summary>
    /// Взаимодействие с пульсом
    /// </summary>
    public class PulseStore
    {
        /// <summary>
        /// Тикер
        /// </summary>
        public string Ticker {  get; init; }
        /// <summary>
        /// Коллекция постов последней загрузки
        /// </summary>
        public ConcurrentQueue<PulsePost> LastPosts { get; private set; } = new();

        public PulseStore(string ticker)
        {
            Ticker = ticker;
        }

        /// <summary>
        /// Запрашивает и отдает коллекцию постов
        /// </summary>
        /// <returns></returns>
        public async Task<ConcurrentQueue<PulsePost>> GetPosts()
        {
            var doc = await new HtmlWeb().LoadFromWebAsync("https://www.tbank.ru/invest/stocks/" + Ticker + "/pulse/");

            LastPosts = new();

            var data = doc.DocumentNode.SelectNodes("//script")
                .FirstOrDefault(x =>
                    x.InnerText.IndexOf("investSocialPostsByTicker") >= 0 &&
                    x.InnerText.IndexOf("items") >= 0
                );

            if (data != null)
            {
                try
                {
                    foreach (var item in getValueFrom(JsonConvert.DeserializeObject<dynamic>(data.InnerText), "items"))
                    {
                        try
                        {
                            LastPosts.Enqueue(JsonConvert.DeserializeObject<PulsePost>(JsonConvert.SerializeObject(item)));
                        } catch(Exception e)
                        {

                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }

            return LastPosts;
        }

        /// <summary>
        /// Поиск элемента в объекте
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="searchName"></param>
        /// <returns></returns>
        private dynamic? getValueFrom(dynamic obj, string searchName)
        {
            List<string> properties = new() { "JObject", "JProperty" };

            foreach (var item in obj)
            {
                try
                {
                    if (item != null && properties.Contains(item.GetType().Name))
                    {
                        if (item.Name + "" == searchName)
                        {
                            return item.Value;
                        }
                        else
                        {
                            dynamic objX = getValueFrom(item, searchName);
                            if (objX != null)
                            {
                                return objX;
                            }
                        }
                    }
                }
                catch (Exception e)
                {

                }
            }
            return null;
        }
    }
}
