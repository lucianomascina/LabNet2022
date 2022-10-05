﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class CategoryView
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }
    }
}