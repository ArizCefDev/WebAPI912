using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Valyuta
    {
        public int ID { get; set; }
        public string Ad { get; set; }//USD

        [Range(1, 100)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Mezenne { get; set; } //1.7000

        [Range(1, 100)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Alis { get; set; } //1.6080

        [Range(1, 100)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Satis { get; set; } //1.7020

    }
}
