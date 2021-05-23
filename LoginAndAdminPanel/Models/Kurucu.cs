using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndAdminPanel.Models
{
    public class Kurucu : BaseClass
    {
        public int Id { get; set; }
        //public int Isim { get; set; }

        //navigation property
        public List<Okul> Okuls { get; set; } //1-sonsuz
        public List<Mudur> Mudurs { get; set; } //1-1 ilişki
        public List<Ogretmen> Ogretmens { get; set; }
        public List<Ogrenci> Ogrencis { get; set; }
    }
}
