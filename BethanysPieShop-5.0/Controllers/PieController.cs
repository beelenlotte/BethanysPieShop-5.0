﻿using BethanysPieShop_5._0.Models;
using BethanysPieShop_5._0.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop_5._0.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository) {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesLIstViewModel = new PiesListViewModel();
            piesLIstViewModel.Pies = _pieRepository.AllPies;
            ViewBag.CurrentCategory = "Cheese cakes";
            return View(piesLIstViewModel);
        }

        //'id' should be the same as the paramter in startup class for routing /{id:int}
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}