using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaster.Database.ModelDatabases
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName ="NVarchar(50)")]
        public string ProductName { get; set; }
        [Column(TypeName = "NVarchar(15)")]
        public string ProductCode { get; set; }
        public int Stock { get; set; }
        public uint Price { get; set; }

    }
}
