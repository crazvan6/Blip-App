using Microsoft.AspNetCore.Identity;

namespace BlipApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Comment>? Comments { get; set; }
        public virtual ICollection<Post>? Posts { get; set; }
        public int FollowersCount { get; set; }
        public bool ProfileVisibility { get; set; } = false;
        public virtual ICollection<UserInGroup>? UserInGroup { get; set; }

    }
}
