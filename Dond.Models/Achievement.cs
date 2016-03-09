using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dond.Models
{
    public class Achievement:BaseEntity
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string IconName { get; set; }
   
    }
}
