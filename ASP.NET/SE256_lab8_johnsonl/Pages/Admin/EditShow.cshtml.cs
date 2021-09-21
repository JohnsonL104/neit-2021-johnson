using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE256_lab5_johnsonl.Models;
using Microsoft.Extensions.Configuration;

namespace SE256_lab5_johnsonl.Pages.Admin
{
    public class EditShowModel : PageModel
    {
        private readonly IConfiguration _configuration;
        
        [BindProperty]
        public Show show { get; set; }
        public ShowDataAccessLayer factory;

        public EditShowModel(IConfiguration configuration)
        {
            _configuration = configuration;
            factory = new ShowDataAccessLayer(_configuration);
        }

        public ActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                show = factory.GetOneRecord(id);
            }

            if(show == null)
            {
                return NotFound();
            }
            return Page();
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            factory.UpdateShow(show);
            return RedirectToPage("/Admin/ControlPanel");
        }
    }
}
