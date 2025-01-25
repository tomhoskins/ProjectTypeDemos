﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public bool IsActive { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();

        public string PersonDisplayValue => Addresses.Count > 0 ? $"{FirstName} {LastName} - {Addresses[0].AddressDisplayValue}" :
                                                                  $"{FirstName} {LastName}";   
    }
}
