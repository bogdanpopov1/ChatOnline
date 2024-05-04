namespace ChatOnline.Data
{
    public class User
    {
        public User(string username, string password, string image)
        {
            _id = Guid.NewGuid().ToString();
            Username = username;
            Password = password;
            Image = image;
            Chats = new List<Chat>();
        }

        private string _id;
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Image {  get; set; }
        public List<Chat> Chats { get; set; }
    }
}
