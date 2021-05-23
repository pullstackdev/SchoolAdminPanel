using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndAdminPanel.Models
{
    public class Mudur : BaseClass
    {
        public int Id { get; set; }
        //navigation property
        public Kurucu Kurucu { get; set; }
        public Okul Okul { get; set; } //1-1 ilişki
        public List<Ogretmen> Ogretmens { get; set; }
        public List<Ogrenci> Ogrencis { get; set; }
    }
}
