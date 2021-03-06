using RecipesAPI.Models.Base;
using RecipesAPI.Models.Enums;
using System.Collections.Generic;

namespace RecipesAPI.Models
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }

        public float NormativePrice { get; set; }

        public float NormativeQuantity { get; set; }

        public Unit NormativeUnit { get; set; }

        public IEnumerable<RecipeIngredient> RecipeIngredient { get; set; }
    }
}
