namespace ChatOnline.Data
{
    public class Message
    {
        public Message(string text, DateTime dateTime)
        {
            _id = Guid.NewGuid().ToString();
            Text = text;
            DateTime = dateTime;
        }

        private string _id;
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public User UserOwner { get; set; }
    }
}
