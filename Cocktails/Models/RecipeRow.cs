﻿namespace Cocktails.Models
{
    public class RecipeRow
    {
        public int ID { get; set; }
        public int CocktailID { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public decimal Amount { get; set; }
        public Unit Unit { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, CocktailID: {CocktailID}, Ingredient: ({Ingredient}), Amount: {Amount}, Unit: {Unit}";
        }
    }
}