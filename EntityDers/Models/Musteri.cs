using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityDers.Models
{
    public class Musteri
    {
        [Key]
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Adresi { get; set; }


    }
}
