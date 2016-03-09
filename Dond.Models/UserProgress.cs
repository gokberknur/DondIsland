using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dond.Models
{
    public class UserProgress:BaseEntity
    {
        public int UserId { get; set; }
        public int PuzzleId { get; set; }
        public int Minute { get; set; }
        public int Session { get; set; }

    }
}
