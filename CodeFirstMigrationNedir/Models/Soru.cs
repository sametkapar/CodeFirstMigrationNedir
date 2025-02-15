using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstMigrationNedir.Models
{
    public class Soru
    {
        public int ID { get; set; }
        public int Etkinlik_ID { get; set; } //int nullable olduğu için databasede not null olur. int? yaparsak nullable olur.
        [ForeignKey("Etkinlik_ID")]
        public virtual Etkinlik Etkinlik { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Isim { get; set; }
        public string Metin { get; set; }  
        public bool Durum { get; set;}
        
    }
}