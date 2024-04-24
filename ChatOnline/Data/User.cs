namespace ChatOnline.Data
{
    public class User
    {
        public User(string username, string password)
        {
            _id = Guid.NewGuid().ToString();
            Username = username;
            Password = password;
        }

        private string _id;
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
    }
}
