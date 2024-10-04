namespace Pulse.Components
{
    /// <summary>
    /// Данные поста
    /// </summary>
    public class PulsePostContent
    {
        public string Text = string.Empty;
        public List<PulsePostInstrument> Instruments = new();
        public List<PulsePostHashtag> Hashtags = new();
    }
}
