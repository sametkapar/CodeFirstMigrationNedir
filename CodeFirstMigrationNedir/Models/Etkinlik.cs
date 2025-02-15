using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace CodeFirstMigrationNedir.Models
{
    public class Etkinlik
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")] // not null olmaması için
        [StringLength(maximumLength: 50, ErrorMessage = "Etkinlik adı en fazla 50 karakter olmalıdır")] //nvarchar(50) 
        public string Isim { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tarih { get; set; }
        [StringLength(maximumLength: 50)]
        public string Resim { get; set; }
        public bool Durum { get; set; }
        public virtual ICollection<Soru> Sorular { get; set; }

    }
}