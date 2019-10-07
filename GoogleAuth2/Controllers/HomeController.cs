﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GoogleAuth2.Models;
using System.Globalization;

namespace GoogleAuth2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var culture = CultureInfo.CreateSpecificCulture("th-TH");
            //var dateformat = new DateTimeFormatInfo
            //{
            //    ShortDatePattern = "MM/dd/yyyy",
            //    LongDatePattern = "MM/dd/yyyy hh:mm:ss tt"
            //};
            //culture.DateTimeFormat = dateformat;
            //var currentDate = DateTime.Now.ToString("MM/dd/yyyy", culture);
            //List<sdr> ss = new List<sdr>() {
            //    new sdr
            //    {
            //        aa=5
            //    },
            //    new sdr
            //    {
            //        aa=4
            //    },
            //};

            //var opop = ss ?? ss;
            //var fsd = ss.FirstOrDefault(a=>a.aa==88)?.aa;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult oauth2callback()
        {
            return View();
        }
        
    }
    class sdr {
        public int aa { get; set; }
        public int me { get; set; }
    }
}
