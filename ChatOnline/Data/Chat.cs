namespace ChatOnline.Data
{
    public class Chat
    {
        public Chat()
        {
            _id = Guid.NewGuid().ToString();
            Messages = new List<Message>();
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
