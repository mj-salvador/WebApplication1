using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IAppConfig appConfig;

        public string TestConfig { get; set; }


        public IndexModel(ILogger<IndexModel> logger, IAppConfig appConfig)
        {
            _logger = logger;
            this.appConfig = appConfig;
            this.TestConfig = this.appConfig.GetTestValue();
        }

        public void OnGet()
        {

        }
    }
}
