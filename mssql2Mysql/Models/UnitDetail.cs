using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mssql2Mysql.Models
{
    public class UnitDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string LanguageCode { get; set; }
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public int UnitID { get; set; }
        public bool State { get; set; }
    }
}
