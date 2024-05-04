using Microsoft.AspNetCore.Components;

namespace ChatOnline.Data
{
    public class DataContext
    {
        [Parameter]
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User("user1", "123", "https://news.store.rambler.ru/img/e3ea4f8957bb1a608f5f997279be134a?img-1-resize=width%3A1280%2Cheight%3A1280%2Cfit%3Acover&img-format=auto"),
            new User("user2", "123", "https://cs10.pikabu.ru/post_img/big/2019/06/10/10/1560189303130026525.jpg"),
            new User("user3", "123", "https://i.pinimg.com/1200x/3a/07/0d/3a070dd1253de60dd66f04c11ff22f85.jpg"),

            new User("user4", "123", "https://news.store.rambler.ru/img/e3ea4f8957bb1a608f5f997279be134a?img-1-resize=width%3A1280%2Cheight%3A1280%2Cfit%3Acover&img-format=auto"),
            new User("user5", "123", "https://cs10.pikabu.ru/post_img/big/2019/06/10/10/1560189303130026525.jpg"),
            new User("user6", "123", "https://i.pinimg.com/1200x/3a/07/0d/3a070dd1253de60dd66f04c11ff22f85.jpg"),

            new User("user7", "123", "https://news.store.rambler.ru/img/e3ea4f8957bb1a608f5f997279be134a?img-1-resize=width%3A1280%2Cheight%3A1280%2Cfit%3Acover&img-format=auto"),
            new User("user8", "123", "https://cs10.pikabu.ru/post_img/big/2019/06/10/10/1560189303130026525.jpg"),
            new User("user9", "123", "https://i.pinimg.com/1200x/3a/07/0d/3a070dd1253de60dd66f04c11ff22f85.jpg"),

            new User("user10", "123", "https://news.store.rambler.ru/img/e3ea4f8957bb1a608f5f997279be134a?img-1-resize=width%3A1280%2Cheight%3A1280%2Cfit%3Acover&img-format=auto"),
            new User("user12", "123", "https://cs10.pikabu.ru/post_img/big/2019/06/10/10/1560189303130026525.jpg"),
            new User("user13", "123", "https://i.pinimg.com/1200x/3a/07/0d/3a070dd1253de60dd66f04c11ff22f85.jpg"),

            new User("user14", "123", "https://news.store.rambler.ru/img/e3ea4f8957bb1a608f5f997279be134a?img-1-resize=width%3A1280%2Cheight%3A1280%2Cfit%3Acover&img-format=auto"),
            new User("user15", "123", "https://cs10.pikabu.ru/post_img/big/2019/06/10/10/1560189303130026525.jpg"),
            new User("user16", "123", "https://i.pinimg.com/1200x/3a/07/0d/3a070dd1253de60dd66f04c11ff22f85.jpg"),

            new User("user17", "123", "https://news.store.rambler.ru/img/e3ea4f8957bb1a608f5f997279be134a?img-1-resize=width%3A1280%2Cheight%3A1280%2Cfit%3Acover&img-format=auto"),
            new User("user18", "123", "https://cs10.pikabu.ru/post_img/big/2019/06/10/10/1560189303130026525.jpg"),
            new User("user19", "123", "https://i.pinimg.com/1200x/3a/07/0d/3a070dd1253de60dd66f04c11ff22f85.jpg"),

            new User("user20", "123", "https://news.store.rambler.ru/img/e3ea4f8957bb1a608f5f997279be134a?img-1-resize=width%3A1280%2Cheight%3A1280%2Cfit%3Acover&img-format=auto"),
            new User("user21", "123", "https://cs10.pikabu.ru/post_img/big/2019/06/10/10/1560189303130026525.jpg"),
            new User("user22", "123", "https://i.pinimg.com/1200x/3a/07/0d/3a070dd1253de60dd66f04c11ff22f85.jpg"),

            new User("user23", "123", "https://news.store.rambler.ru/img/e3ea4f8957bb1a608f5f997279be134a?img-1-resize=width%3A1280%2Cheight%3A1280%2Cfit%3Acover&img-format=auto"),
            new User("user24", "123", "https://cs10.pikabu.ru/post_img/big/2019/06/10/10/1560189303130026525.jpg"),
            new User("user25", "123", "https://i.pinimg.com/1200x/3a/07/0d/3a070dd1253de60dd66f04c11ff22f85.jpg"),
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
