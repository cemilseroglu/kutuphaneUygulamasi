using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneUygulamasi.Data
{
    class Kitap:KitapTur
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public DateTime BasimTarihi { get; set; }
        public KitapTur Kitapturu { get; set; }
        public string YazarAd { get; set; }
        public int SayfaSayisi { get; set; }
        public string Aciklama { get; set; }
        public DateTime? OduncAlinmaTarihi { get; set; }
    }
}
