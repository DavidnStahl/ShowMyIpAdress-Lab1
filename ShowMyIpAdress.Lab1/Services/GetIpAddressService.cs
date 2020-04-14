
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;



namespace ShowMyIpAdress.Lab1.Models
{
    public class GetIpAddressService : IGetIpAddressService
    {
        public string GetIpAddress(IHttpContextAccessor accessor)
        {
            return accessor.HttpContext.Connection.LocalIpAddress.ToString();
        }
    }
}
