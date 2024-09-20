namespace Pulse.Components
{
    /// <summary>
    /// Пост пульса
    /// </summary>
    public class PulsePost
    {
        public DateTime Inserted;
        public PulsePostOwner Owner;
        public PulsePostContent Content;

        public override string ToString()
        {
            return Owner?.Nickname + "\n" +
                    Inserted + "\n\n" +
                    Content?.Text;
        }
    }
}
