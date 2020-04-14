using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowMyIpAdress.Lab1.Models
{
    public interface IGetIpAddressService
    {
        string GetIpAddress(IHttpContextAccessor accessor);
    }
}
