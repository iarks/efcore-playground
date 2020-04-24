using System;
using System.Collections.Generic;
using System.Text;

namespace efcore_playground.entities
{
    public class AddressDTO
    {
        public AddressDTO(string streetName, int pin)
        {
            StreetName = streetName;
            Pin = pin;
        }

        public string StreetName { get; }
        public int Pin { get; }
    }
}
