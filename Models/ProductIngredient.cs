﻿namespace Final_RestaurantWebApp.Models
{
    public class ProductIngredient
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}