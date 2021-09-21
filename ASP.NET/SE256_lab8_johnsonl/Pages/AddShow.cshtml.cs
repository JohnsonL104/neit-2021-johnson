using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SE256_lab5_johnsonl.Models;

using Microsoft.Extensions.Configuration;
namespace SE256_lab5_johnsonl.Pages
{
    public class AddShowModel : PageModel
    {
        [BindProperty]



        public Show show { get; set; }

        private readonly IConfiguration _configuration;

        public AddShowModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
           
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
                if (show is null == false)
                {
                    ShowDataAccessLayer factory = new ShowDataAccessLayer(_configuration);
                    factory.Create(show);
                }
                temp = Page();
            }
            return temp;
        }
    }
}
