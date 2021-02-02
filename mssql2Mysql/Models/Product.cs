using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mssql2Mysql.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string LanguageCode { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public int UnitID { get; set; }
        public Unit Unit { get; set; }
        public string Barcode { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public string Code { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public int Source { get; set; }
        public ICollection<File> Files { get; set; }
    }
}
