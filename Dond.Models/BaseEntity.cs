using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dond.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public Guid Guid { get; set; }
        public bool IsActive { get; set; }

        public BaseEntity()
        {
            CreateDate = DateTimeOffset.UtcNow;
            Guid = new Guid();
            IsActive = true;
        }
    }
}
