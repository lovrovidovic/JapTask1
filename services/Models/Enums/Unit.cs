﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RecipesAPI.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Unit
    {
        kg,
        g,
        ml,
        l,
        kom
    }
}
