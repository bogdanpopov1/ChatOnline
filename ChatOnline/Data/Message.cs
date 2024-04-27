namespace ChatOnline.Data
{
    public class Message
    {
        public Message(string text, User userOwner)
        {
            _id = Guid.NewGuid().ToString();
            Text = text;
            DateTime = DateTime.Now;
            UserOwner = userOwner;
        }

        private string _id;
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public User UserOwner { get; set; }
    }
}
