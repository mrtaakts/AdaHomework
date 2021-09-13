using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaHomework.Models.ViewModel
{
    public class RequestViewModel
    {
        public Train Tren { get; set; }
        public int RezervasyonYapilacakKisiSayisi { get; set; }
        public bool KisilerFarkliVagonlaraYerlestirilebilir { get; set; }
    }


}
