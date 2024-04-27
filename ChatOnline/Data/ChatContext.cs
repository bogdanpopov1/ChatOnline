using Microsoft.AspNetCore.Components;

namespace ChatOnline.Data
{
    public class ChatContext
    {

        [Parameter]
        public static User UserRecipient { get; set;}
    }
}
