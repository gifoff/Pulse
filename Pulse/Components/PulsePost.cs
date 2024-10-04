namespace Pulse.Components
{
    /// <summary>
    /// Пост пульса
    /// </summary>
    public class PulsePost
    {
        public string Id;
        public int CommentsCount;
        public DateTime Inserted;
        public PulsePostOwner Owner;
        public PulsePostContent Content;
        public PulsePostReactions Reactions;
        public List<string> ServiceTags = new();

        public override string ToString()
        {
            return Owner?.Nickname + "\n" +
                    Inserted + "\n\n" +
                    Content?.Text;
        }
    }
}
