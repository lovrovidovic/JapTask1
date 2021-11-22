﻿using Recipes.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Api.Dtos
{
    public class GetRecipeDetailsDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public float TotalPrice { get; set; }

        public DateTime CreatedAt { get; set; }

        public IEnumerable<GetIngredientOfRecipeDto> Ingredients { get; set; }
    }
}
