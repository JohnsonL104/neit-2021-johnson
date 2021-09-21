using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

using SE256_lab5_johnsonl.Models;

using Microsoft.Extensions.Configuration;
namespace SE256_lab5_johnsonl.Pages.Admin
{
    public class ControlPanelModel : PageModel
    {
        private readonly IConfiguration _configuration;
        ShowDataAccessLayer factory;
        public List<Show> tix { get; set; }


        public ControlPanelModel(IConfiguration configuration)
        {
            _configuration = configuration;
            factory = new ShowDataAccessLayer(_configuration);
        }

        public IActionResult OnGet()
        {
            IActionResult temp;

            if(HttpContext.Session.GetString("ShowAdminEmail") is null)
            {
                temp = RedirectToPage("/Admin/Index");
            }
            else
            {
                tix = factory.GetActiveRecords().ToList();

                temp = Page();
            }
            return temp;
        }
    }
}
