using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

       //This is done to write to a property, BindProperty lekhnai parcha
        //Making them writable
        
        [BindProperty(SupportsGet = true)]

        public string City { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrEmpty(City))
            {
                City = "The Web";
            }
        }
    }
}