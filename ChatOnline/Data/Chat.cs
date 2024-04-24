namespace ChatOnline.Data
{
    public class Chat
    {
        public Chat(List<Message> messages)
        {
            _id = Guid.NewGuid().ToString();
            Messages = messages;
        }

        private string _id;
        public List<Message> Messages { get; set; }

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
