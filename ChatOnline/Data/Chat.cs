namespace ChatOnline.Data
{
    public class Chat
    {
        public Chat(User user, List<Message> messages)
        {
            _id = Guid.NewGuid().ToString();
            User = user;
            Messages = messages;
        }

        private string _id;
        public User User { get; set; }
        public List<Message> Messages { get; set; }

        public void UpdateMessages()
        {
            Messages = Messages.OrderBy(msg => msg.DateTime).ToList();
        }
    }
}
