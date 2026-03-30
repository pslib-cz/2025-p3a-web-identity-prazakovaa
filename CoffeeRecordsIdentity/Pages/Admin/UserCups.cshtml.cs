using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoffeeRecordsIdentity.Models;

namespace CoffeeRecordsIdentity.Pages.Admin
{
    [Authorize(Policy = "AdminPolicy")]
    public class UserCupsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public UserCupsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CoffeeCup> UserCups { get; set; }

        [BindProperty]
        public string UserId { get; set; }

        public async Task OnGetAsync()
        {
            UserCups = new List <CoffeeCup>();
        }
    }
}