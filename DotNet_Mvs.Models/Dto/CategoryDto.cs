﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Mvc.Models.Dto
{
  public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}