using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using SE256_lab5_johnsonl.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_lab5_johnsonl.Pages
{
    public class IndexModel : PageModel
    {
        

        [BindProperty(SupportsGet =true)]

        public String FName { get; set; }

        private readonly IConfiguration _configuration;

        ShowDataAccessLayer factory;
        public List<Show> lst { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
            factory = new ShowDataAccessLayer(_configuration);
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FName))
            {
                FName = "You!";
            }
            lst = factory.GetActiveRecords().ToList();
        }
    }
}
