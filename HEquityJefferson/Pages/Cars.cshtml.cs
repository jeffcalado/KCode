﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HEquityJefferson.Data;
using HEquityJefferson.Model;

namespace HEquityJefferson.Pages
{
    public class CarsModel : PageModel
    {
        private readonly HEquityJefferson.Data.HEquityJeffersonContext _context;

        public CarsModel(HEquityJefferson.Data.HEquityJeffersonContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get; set; }
        public string Message { get; set; }
        public string Success { get; set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }



        public async void OnPostCheck(int id, decimal price, decimal guessprice)
        {

            var Minprice = price - 5000;
            var MaxPrice = price + 5000;
       

            guessprice = !string.IsNullOrEmpty(Request.Form["guessprice"]) ? Convert.ToDecimal(Request.Form["guessprice"]):0;

            if ( guessprice >= Minprice && guessprice <=MaxPrice)
            {
                Success = "1";
                Message = @"Aww yeah, You are great! Iuupeee!";

            }
            else
            {
                Success = "0";
                Message = "Nice try =( ";
            }

           

            await OnGetAsync();
            
        }



    }
}
