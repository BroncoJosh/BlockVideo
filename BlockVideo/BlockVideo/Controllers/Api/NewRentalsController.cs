﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BlockVideo.Dtos;

namespace BlockVideo.Controllers.Api
{
    public class NewRentalsController: ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            throw new NotImplementedException();

        }
    }
}