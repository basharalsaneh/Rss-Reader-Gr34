﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Category
    {
        public string Title { get; set; }

        public Category(string title)
        {
            Title = title;
        }

        private Category()
        {

        }
    }
}
