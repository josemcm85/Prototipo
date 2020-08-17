using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Prototipo.Models;


namespace Prototipo.Pages.Shared
{


    public class ConsultaModel : PageModel
    {


        private readonly ILogger<ConsultaModel> _logger;



        [BindProperty]
        public Cuenta CuentaPg { get; set; }


        public ConsultaModel(ILogger<ConsultaModel> logger)
        {
            _logger = logger;
        }


     
    }

}