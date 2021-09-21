using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SE256_lab5_johnsonl.Models;
using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace SE256_lab5_johnsonl.Pages.Admin
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ShowAdmin admin { get; set; }
        private readonly IConfiguration _configuration;
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            HttpContext.Session.SetInt32("test", 5);

        }

        public IActionResult OnPost()
        {
            IActionResult temp;
            List<ShowAdmin> lstShowAdmin = new List<ShowAdmin>();

            if (ModelState.IsValid == false)
            {
                temp = Page();

            }
            else
            {
                if(admin != null)
                {
                    ShowAdminDataAccessLayer factory = new ShowAdminDataAccessLayer(_configuration);
                    lstShowAdmin = factory.GetAdminLogin(admin).ToList();
                    if(lstShowAdmin.Count > 0)
                    {
                        HttpContext.Session.SetInt32("ShowAdminID", lstShowAdmin[0].ShowAdminID);
                        HttpContext.Session.SetString("ShowAdminEmail", lstShowAdmin[0].ShowAdminEmail);
                        temp = Redirect("/Admin/controlPanel");
                    }
                    else
                    {
                        admin.Feedback = "Login Faild.";
                        temp = Page();
                    }

                }
                else
                {
                    temp = Page();
                }
            }
            return temp;
        }
    }
}
