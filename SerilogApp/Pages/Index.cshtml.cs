using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerilogApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("You requested shit.");

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    if(i == 47)
                    {
                        throw new Exception("Demo exception");
                    }
                    else
                    {
                        _logger.LogInformation("The value of i is {iValue}", i);
                    }
                }
            }
            catch (Exception ex)
            { 
                _logger.LogError($"We caught this error: {ex}");
            }
        }
    }
}
