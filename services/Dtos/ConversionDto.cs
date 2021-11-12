﻿using RecipesAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Dtos
{
    public class ConversionDto
    {
        public float StartingQuantity { get; set; }

        public Unit StartingUnit { get; set; }

        public float NormativeQuantity { get; set; }

        public Unit NormativeUnit { get; set; }

        public float NormativePrice { get; set; }
    }
}
