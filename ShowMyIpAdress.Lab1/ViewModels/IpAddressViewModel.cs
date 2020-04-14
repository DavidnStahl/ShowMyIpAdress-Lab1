using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowMyIpAdress.Lab1.ViewModels
{
    public class IpAddressViewModel
    {
        public IpAddressViewModel(string IpAdress)
        {
            this.IpAdress = IpAdress;
        }
        public string IpAdress { get; set; }
    }
}
