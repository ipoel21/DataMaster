using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaster.Aplications.ApplicationServices.ProductServices.Dto
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int Stock { get; set; }
        public uint Price { get; set; }
    }
}
