using System.ComponentModel.DataAnnotations;

namespace BlipApp.Models
{
    public class UserInGroup
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? GroupId {  get; set; }
        public virtual ApplicationUser? User { get; set; }
        public virtual Group? Group { get; set; }

        

    }
}
