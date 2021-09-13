using AdaHomework.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaHomework.Services
{

    public interface IReservationService 
    {
        public ResponseViewModel Reservation(RequestViewModel request);
    }
}
