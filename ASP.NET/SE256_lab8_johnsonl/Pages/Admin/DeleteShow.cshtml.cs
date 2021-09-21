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
    public class DeleteShowModel : PageModel
    {
        ShowDataAccessLayer factory;
        public Show show { get; set; }

        private readonly IConfiguration _configuration;

        public DeleteShowModel(IConfiguration configuration)
        {
            _configuration = configuration;
            factory = new ShowDataAccessLayer(_configuration);
        }
        public ActionResult OnGet(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            show = factory.GetOneRecord(id);

            if (show == null)
            {
                return NotFound();
            }
            return Page();
        }

        public ActionResult OnPost(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            factory.DeleteShow(id);
            return RedirectToPage("/Admin/ControlPanel");
        }
    }
}
