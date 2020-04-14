using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShowMyIpAdress.Lab1.Models;
using ShowMyIpAdress.Lab1.ViewModels;

namespace ShowMyIpAdress.Lab1.Controllers
{
    public class ShowMyIpAddressController : Controller
    {
        private readonly IGetIpAddressService _getIpAddressService;
        private readonly IHttpContextAccessor _accessor;

        public ShowMyIpAddressController(IGetIpAddressService getIpAddressService, IHttpContextAccessor accessor)
        {
            _getIpAddressService = getIpAddressService;
            _accessor = accessor;
        }

        public IActionResult Index()
        {
            var viewModel = new IpAddressViewModel(_getIpAddressService.GetIpAddress(_accessor));
            return View(viewModel);
        }
    }
}