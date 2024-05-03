using Microsoft.AspNetCore.Components;

namespace ChatOnline.Data
{
    public class DataContext
    {
        [Parameter]
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User("bogdan_popov", "A123qweQ!"),
            new User("bogopas", "A123qweQ!"),
            new User("diana_best", "A123qweQ!"),
            new User("diannyyse", "A123qweQ!"),
            new User("borross17", "A123qweQ!"),
            new User("user1", "123"),
            new User("user2", "123"),
        };

        [Parameter]
        public static List<Chat> Chats { get; set; } = new List<Chat>();

        public void AddUser(User user)
        {
            Users.Add(user);
        }
        public void RemoveUser(User user)
        {
            Users.Remove(user);
        }

        public void UpdateUsers()
        {
            Users = Users.OrderBy(user => user.Username).ToList();
        }

        public void AddChat(Chat chat)
        {
            Chats.Add(chat);
        }

        public void RemoveChat(Chat chat)
        {
            Chats.Remove(chat);
        }

        public void UpdateChats(Chat chat)
        {
            
        }
    }
}
