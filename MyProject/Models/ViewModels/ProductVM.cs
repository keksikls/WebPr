﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }

        public IEnumerable<SelectListItem> ApplicationTypeSelectList { get; set; }

    }
}
