using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esite.ViewModel
{
    public class CategoryViewModel
    {

        public string Name { get; set; }
        public string Code { get; set; }
        //public int Id { get; set; }


        public IFormFile PImage { get; set; }
    }

}