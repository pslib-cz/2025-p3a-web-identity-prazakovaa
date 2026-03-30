using CoffeeRecordsIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoffeeRecordsIdentity.Pages.Admin
{
    [Authorize(Policy = "AdminPolicy")]
    public class UsersModel : PageModel
    {

        private readonly UserManager<ApplicationUser> _userManager;

        public UsersModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IList<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();

    }
}
