using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AddressModel
    {
        public string StreetAddress { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string ZipCode { get; set; } = "";

        // Equivalent to commented out prop below, uses lambda expression
        public string AddressDisplayValue => $"{StreetAddress}, {City}, {State}  {ZipCode}";
        
        /*
        public string FullAddressView
        {
            get { return $"{StreetAddress}, {City}, {State}  {ZipCode}"; }
        }
        */
    }
}
