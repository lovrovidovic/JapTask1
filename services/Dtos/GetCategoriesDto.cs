﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.Dtos
{
    public class GetCategoriesDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
