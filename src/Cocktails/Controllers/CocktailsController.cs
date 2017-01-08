﻿using System.Collections.Generic;
using Cocktails.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cocktails.Controllers
{
    public class CocktailsController : Controller
    {
        private static readonly IList<Cocktail> Cocktails = new List<Cocktail>
        {
            new Cocktail { Id = 1, Name = "Mai Tai",
                Image = "mai-tai_small.jpg",
                Ingredients = new List<string>
            {
                "4 cl white rum",
                "2 cl dark rum",
                "1.5 cl orange curaçao",
                "1.5 cl Orgeat syrup",
                "1 cl fresh lime juice"
            }, Instructions = "Shake ingredients with ice, strain into a glass. Serve with a straw." },
            new Cocktail { Id = 2, Name = "Cosmopolitan",
                Image = "cosmopolitan_small.jpg",
                Ingredients = new List<string>
            {
                "4 cl Citron Vodka",
                "1.5 cl Cointreau",
                "3 cl Cranberry juice",
                "1.5 cl Fresh lime juice"
            }, Instructions = "Fill a cocktail shaker with ice. Add all ingredients, then shake. Strain into a large cocktail glass. Garnish with a slice of lime." },
            new Cocktail { Id = 3, Name = "Mojito",
                Image = "mojito_small.jpg",
                Ingredients = new List<string>
            {
                "4 cl White Cuban Rum",
                "3 cl Fresh lime juice",
                "6 Mint sprigs",
                "2 teaspoons white sugar",
                "Soda water"
            }, Instructions = "Muddle leaves of mint with lime juice and sugar. Add splash of soda water, fill the glass with cracked ice. " +
                              "Pour rum into glass, top with soda water. Garnish with leaves of mint and slice of lemon, serve with straw." },
            new Cocktail
            {
                Id = 4, Name = "Dry Martini" ,
                Ingredients = new List<string>
                {
                    "6 cl Gin",
                    "1 cl Dry Vermouth"
                },
                Instructions = "Pour gin and vermouth into mixing glass with ice. Stir. Strain in a chilled martini glass. Squeeze oil from lemon peel to the drink or garnish with olives."
            }
        };
         
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            return Json(Cocktails);
        }
    }
}