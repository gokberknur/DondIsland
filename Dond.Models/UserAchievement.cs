using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dond.Models
{
   public class UserAchievement : BaseEntity
    {
        public int UserId { get; set; }
        public int AchievementId { get; set; }
    }
}
