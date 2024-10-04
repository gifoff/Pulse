namespace Pulse.Components
{
    /// <summary>
    /// Данные автора поста
    /// </summary>
    public class PulsePostOwner
    {
        public string Id = string.Empty;
        public string Nickname = string.Empty;
        public bool DonationActive = false;
        public bool Block = false;
        public string Image = string.Empty;
        public List<string> ServiceTags = new();
    }
}
