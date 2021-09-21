using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Activity5.Models;

using Microsoft.Extensions.Configuration;



namespace Activity5.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty(SupportsGet = true)]

        public String FName { get; set; }


        private readonly IConfiguration _configuration;

        TroubleTicketDataAccessLayer factory;
        public List<TroubleTicketModel> tix { get; set; }
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new TroubleTicketDataAccessLayer(_configuration);
        }
        

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FName))
            {
                FName = "You!";
            }

            tix = factory.GetActiveRecords().ToList();
        }
    }
}
