using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Durur.Modules.Generic.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Durur.Erp.Api.Pages.Shared
{
    public class HeaderModel : PageModel
    {
        [BindProperty]
        public User AuthUser { get; set; } = new User() { IsActive = false };

        public void OnGet()
        {
        }

    }
}
