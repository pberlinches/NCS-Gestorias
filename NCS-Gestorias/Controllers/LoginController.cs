using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NCS_Gestorias.Models;

namespace NCS_Gestorias.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        Models.Clientes modelo = new Clientes();
        List<Clientes> listaClientesResultado = new List<Clientes>();

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public ActionResult Login()
        {
           
            return View();
        }


        

        
        
    }
}
