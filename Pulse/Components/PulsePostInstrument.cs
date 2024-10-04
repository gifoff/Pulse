namespace Pulse.Components
{
    /// <summary>
    /// Данные поста
    /// </summary>
    public class PulsePostInstrument
    {
        /// <summary>
        /// Тип инструмента
        /// </summary>
        public enum InstrumentType
        {
            Unspecified = 0,
            /// <summary>
            /// Облигация.
            /// </summary>
            Bond = 1,
            /// <summary>
            /// Акция.
            /// </summary>
            Share = 2,
            /// <summary>
            /// Валюта.
            /// </summary>
            Currency = 3,
            /// <summary>
            /// Exchange-traded fund. Фонд.
            /// </summary>
            Etf = 4,
            /// <summary>
            /// Фьючерс.
            /// </summary>
            Futures = 5,
            /// <summary>
            /// Структурная нота.
            /// </summary>
            Sp = 6,
            /// <summary>
            /// Опцион.
            /// </summary>
            Option = 7,
            /// <summary>
            /// Clearing certificate.
            /// </summary>
            ClearingCertificate = 8,
            /// <summary>
            ///  Индекс.
            /// </summary>
            Index = 9,
            /// <summary>
            /// Товар.
            /// </summary>
            Commodity = 10
        }

        public InstrumentType Type;
        public string Ticker;
        public string Currency;
        public string Image;
        public string BriefName;
        public decimal Price;
        public decimal RelativeYield;
    }
}
