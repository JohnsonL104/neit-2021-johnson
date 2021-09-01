using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SE256_lab5_johnsonl.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet =true)]

        public String FName { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FName))
            {
                FName = "You!";
            }
        }
    }
}
