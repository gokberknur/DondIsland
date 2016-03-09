using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dond.Models
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Passwords { get; set; }
        public int CurrentSession { get; set; }


        public virtual ICollection<UserProgress> UserProgress { get; set; }
        public virtual ICollection<UserAchievement> UserAchievement { get; set; }

        public User()
        {
           UserProgress = new List<UserProgress>();
           UserAchievement = new List<UserAchievement>();
        }
    }
}
