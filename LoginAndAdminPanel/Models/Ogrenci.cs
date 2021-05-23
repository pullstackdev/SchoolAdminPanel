using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndAdminPanel.Models
{
    public class Ogrenci: BaseClass
    {
        public int Id { get; set; }

        //navigation property
        public Kurucu Kurucu { get; set; }
        public Ogretmen Ogretmen { get; set; } //1-1
        public Mudur Mudur { get; set; } //1-1
        public Okul Okul { get; set; } //1-1
    }
}
