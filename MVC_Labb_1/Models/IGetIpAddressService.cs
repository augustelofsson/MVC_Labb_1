using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace MVC_Labb_1.Models
{
    public interface IGetIpAddressService
    {
        string GetIpAddress();
    }
    public class GetIpAddressService : IGetIpAddressService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public GetIpAddressService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        string IGetIpAddressService.GetIpAddress()
        {
            string ipAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();

            return ipAddress;
            
        }
    }
}
