using DataMaster.Database.ModelDatabases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaster.Database.DataMasterContext
{
    public class DMContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DMContext(DbContextOptions<DMContext> option):base(option) { }
    }
}
