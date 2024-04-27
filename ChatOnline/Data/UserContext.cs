using Microsoft.AspNetCore.Components;

namespace ChatOnline.Data
{
    public class UserContext
    {
        [Parameter]
        public static User CurrentUser { get; set; } = null;

        [Parameter]
        public static Chat Chat { get; set;}
    }
}
