using Microsoft.AspNetCore.Components;

namespace ChatOnline.Data
{
    public class DataContext
    {
        [Parameter]
        public static List<User> Users { get; set; } = new List<User>();

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
            Chats = Chats.OrderBy(chat => chat.User.Username).ToList();
        }
    }
}
