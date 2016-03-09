using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dond.Models
{
    public class Puzzle : BaseEntity
    {
        public string Name { get; set; }
        public string Icon_Name { get; set; }
        public int Score_Multipiller { get; set; }
    }
}
