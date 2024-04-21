using Microsoft.AspNetCore.Components;

namespace ChatOnline.Data
{
    public class db_connection : ComponentBase
    {
        [Parameter]
        public List<User> usersList { get; set; } = new List<User>();

        [Parameter]
        public bool registrationTrigger { get; set; } = false;

        [Parameter]
        public bool signInTrigger { get; set; } = false;

    }
}
