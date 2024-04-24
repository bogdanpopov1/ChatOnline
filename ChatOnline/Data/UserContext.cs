using Microsoft.AspNetCore.Components;

namespace ChatOnline.Data
{
    public class UserContext
    {
        [Parameter]
        public static User User { get; set; } = null;
    }
}
