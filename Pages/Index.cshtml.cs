using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace webapp_unity.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IDemoService _demoService;

        public IndexModel(ILogger<IndexModel> logger, IDemoService demoService)
        {
            _logger = logger;
            _demoService = demoService;
        }

        public void OnGet()
        {
            _demoService.Log();

        }
    }
}
