using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Prototipo.Models;

namespace Prototipo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        [BindProperty]
        public UserModel UserLogin { get; set; }
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost() {

            if ((UserLogin.correo == "user") && (UserLogin.pass == "user"))
            {

                return RedirectToPage("/Cliente");

            }
            else if ((UserLogin.correo == "admin") && (UserLogin.pass == "admin"))
            {

                return RedirectToPage("/Admin");

            } 
            else if ((UserLogin.correo == "rh") && (UserLogin.pass == "rh"))
            {
                return RedirectToPage("/Reclutamiento");
            }
            else if ((UserLogin.correo == "empleado") && (UserLogin.pass == "empleado"))
            {
                return RedirectToPage("/ServicioCliente");
            }
            return Page();

        }
    }
}
