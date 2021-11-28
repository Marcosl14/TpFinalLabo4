using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TPFinalLabo4.Models
{
    public class SupplierProduct
    { 
        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
