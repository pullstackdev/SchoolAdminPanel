using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndAdminPanel.Models
{
    public class Okul
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string Isim { get; set; }

        //navigation property
        public Kurucu Kurucu{ get; set; }
        public List<Ogretmen> Ogretmens { get; set; }
        public List<Ogrenci> Ogrencis { get; set; }
    }
}
