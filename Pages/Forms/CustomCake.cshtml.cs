using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CakeShop.Pages.Forms
{
    public class CustomCakeModel : PageModel
    {
        [BindProperty]
        public Cakes food { get; set; }
        public void OnGet()
        {
        }
    }
}
