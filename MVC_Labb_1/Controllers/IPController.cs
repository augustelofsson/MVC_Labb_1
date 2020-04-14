using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Labb_1.Models;

namespace MVC_Labb_1.Controllers
{
    public class IPController : Controller
    {
        private readonly IGetIpAddressService _IGetIpAddressService;
        public IPController(IGetIpAddressService getIpAddressService)
        {
            _IGetIpAddressService = getIpAddressService;
        }
        public IActionResult Index()
        {
            var ip = _IGetIpAddressService.GetIpAddress();
            var IPModel = new IPAddress { IpAddress = ip };
            
            return View(IPModel);
        }
    }
}