using AdaHomework.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaHomework.Services
{
    // api deploy edilecek
    // api docker edilecek
    // api github'a readme ile atılacak
    public class ReservationService : IReservationService
    {
        public ResponseViewModel Reservation(RequestViewModel request)
        {
            if (request.KisilerFarkliVagonlaraYerlestirilebilir == true)
            {
                List<YerlesimAyrinti> yerlesimPlani = new List<YerlesimAyrinti>();

                var dinamikKisi = request.RezervasyonYapilacakKisiSayisi;

                foreach (var item in request.Tren.Vagonlar)
                {
                    var currentPercent = Math.Ceiling((double)item.DoluKoltukAdet / item.Kapasite * 100);
                    var maxDoluKoltuk = (double)70 * item.Kapasite/ 100;
                    var maxUser = Math.Floor((double)maxDoluKoltuk - item.DoluKoltukAdet);

                    if (maxUser < 0)
                        continue;

                    else if (dinamikKisi - maxUser <= 0)
                    {
                        yerlesimPlani.Add(new YerlesimAyrinti { KisiSayisi = dinamikKisi, VagonAdi = item.Ad });
                        ResponseViewModel response = new ResponseViewModel { RezervasyonYapilabilir = true, YerlesimAyrinti = yerlesimPlani };
                        return response;
                    }
                    else
                    {
                        yerlesimPlani.Add(new YerlesimAyrinti { KisiSayisi = (int)maxUser, VagonAdi = item.Ad });
                        dinamikKisi -= (int)maxUser;
                    }

                }
                if(dinamikKisi<=0)
                    return new ResponseViewModel { RezervasyonYapilabilir = true, YerlesimAyrinti = yerlesimPlani };
                else
                    return new ResponseViewModel { RezervasyonYapilabilir = false, YerlesimAyrinti = new List<YerlesimAyrinti>()};

            }
            else
            {
                foreach (var item in request.Tren.Vagonlar)
                {
                    var yuzdeliksonuc = (float)(item.DoluKoltukAdet + request.RezervasyonYapilacakKisiSayisi) / (item.Kapasite) * 100;
                    if (yuzdeliksonuc < 70)
                    {
                        List<YerlesimAyrinti> yerlesims = new() { new YerlesimAyrinti { KisiSayisi = request.RezervasyonYapilacakKisiSayisi, VagonAdi = item.Ad } };
                        ResponseViewModel resp = new() { RezervasyonYapilabilir = true, YerlesimAyrinti = yerlesims };
                        return resp;
                    }
                }
                return new ResponseViewModel { RezervasyonYapilabilir = false, YerlesimAyrinti = new List<YerlesimAyrinti>() };
            }
        }
    }
}
