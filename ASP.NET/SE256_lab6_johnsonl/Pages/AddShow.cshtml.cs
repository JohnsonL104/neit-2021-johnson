using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SE256_lab5_johnsonl.Models;

namespace SE256_lab5_johnsonl.Pages
{
    public class AddShowModel : PageModel
    {
        [BindProperty]



        public Show show { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            IActionResult temp;
            if (!ModelState.IsValid)
            {
                temp = Page();
            }
            else
            {
                temp = Page();
            }
            return temp;
        }
    }
}
