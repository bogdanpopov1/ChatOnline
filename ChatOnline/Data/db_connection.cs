using Microsoft.AspNetCore.Components;

namespace ChatOnline.Data
{
    public class db_connection : ComponentBase
    {
        [Parameter]
        public static List<User> usersList { get; set; } = new List<User>();

        [Parameter]
        public static bool registrationTrigger { get; set; } = false;

        [Parameter]
        public static bool signInTrigger { get; set; } = false;

    }
}
