﻿using RecipesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Dtos
{
    public class GetRecipeDetailsDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public DateTime CreatedAt { get; set; }

        public IEnumerable<GetIngredientOfRecipeDto> Ingredients { get; set; }
    }
}
