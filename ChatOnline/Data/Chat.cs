namespace ChatOnline.Data
{
    public class Chat
    {
        public Chat(User userSender)
        {
            _id = Guid.NewGuid().ToString();
            UserSender = userSender;
        }

        private string _id;
        public User UserSender {  get; private set; }
        public List<Message> Messages { get; set; } = new List<Message>();

        public void SendMessage(Message message)
        {
            Messages.Add(message);
        }

        public void UpdateMessages()
        {
            Messages = Messages.OrderBy(msg => msg.DateTime).ToList();
        }
    }
}
