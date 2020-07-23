using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Models
{
    public class Category
    {
       
            public int Id { get; set; }

            public string Name { get; set; }
            public string Code { get; set; }


            public string PImage { get; set; }
            public ICollection<Product> Products { get; set; }


        }

    }

