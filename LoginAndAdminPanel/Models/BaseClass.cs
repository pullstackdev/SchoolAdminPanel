using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndAdminPanel.Models
{
    public class BaseClass
    {
        public BaseClass()
        {
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string Isim { get; set; }
        public string KullaniciAdi { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

    }
    public enum Role
    {
        KurucuAdmin = 1,
        MudurAdmin = 2,
        OgretmenAdmin = 3,
        OgrenciAdmin = 4
    }
}
