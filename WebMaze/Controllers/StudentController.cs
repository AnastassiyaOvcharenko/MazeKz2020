﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebMaze.Models;

namespace WebMaze.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var models = new List<StudentViewModel>();

            for (int i = 0; i < 5; i++)
            {
                var model = new StudentViewModel();
                model.Second = DateTime.Now.Second + i * 2;
                model.CurentUserName = "Ivan" + i;
                model.DayOfWeek = DateTime.Now.DayOfWeek.ToString();
                models.Add(model);
            }

            return View(models);
        }

        public IActionResult Meiramov()
        {
            var models = new List<GirlViewModel>();

            var meiViewModel = new GirlViewModel();
            meiViewModel.Name = "mei";
            meiViewModel.Hegith  = 150;
            meiViewModel.Url = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a2/Mei_Overwatch.png/220px-Mei_Overwatch.png";
            models.Add(meiViewModel);

            var diva = new GirlViewModel();
            diva.Name = "diva";
            diva.Hegith = 150;
            diva.Url = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a2/Mei_Overwatch.png/220px-Mei_Overwatch.png";
            models.Add(diva);

            return View(models);
        }
        public IActionResult Ovcharenko()
        {
            var danceSchoolModels = new List<DanceSchoolViewModel>()
            {
                new DanceSchoolViewModel()
                {
                    SchoolName = "ProDance",
                    Address = "г.Алматы, ул.Маметовой, 67",
                    SiteUrl = "https://prodance.kz/"
                },
                new DanceSchoolViewModel()
                {
                    SchoolName = "LaDanza",
                    Address = "г. Алматы, пр. Достык, 341",
                    SiteUrl = "https://ladanza.kz/"
                },
                new DanceSchoolViewModel()
                {
                    SchoolName = "Free Way",
                    Address = "г. Алматы, ул. Курмангазы 107, угол ул Байтурсынова",
                    SiteUrl = "http://freedance.kz/"
                }
            };

            return View(danceSchoolModels);
        }
    }
}
