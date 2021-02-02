using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mssql2Mysql.Models
{
    public class File
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string RelativePath { get; set; }
        public string FileName { get; set; }
        public string DownloadURLPath { get; set; }
        public bool State { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
