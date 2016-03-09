using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Dond.Models
{
    public class DondDBContext : DbContext
    {
        //TODO Dbset leri ayarlayacaksınız.
        public DondDBContext() { }

        public DbSet<User> Users { get; set; }
    }
}
