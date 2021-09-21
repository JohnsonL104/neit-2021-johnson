using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity5.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty(SupportsGet = true)]

        public String FName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FName))
            {
                FName = "You!";
            }
        }
    }
}
