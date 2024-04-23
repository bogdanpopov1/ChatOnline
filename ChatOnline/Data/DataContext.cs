using Microsoft.AspNetCore.Components;

namespace ChatOnline.Data
{
    public class DataContext
    {
        [Parameter]
        public static List<User> usersList { get; set; } = new List<User>();
    }
}
