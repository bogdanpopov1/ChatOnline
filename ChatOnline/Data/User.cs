namespace ChatOnline.Data
{
    public class User
    {
        public User(string username, string password)
        {
            Id = Guid.NewGuid().ToString();
            Username = username;
            Password = password;
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
