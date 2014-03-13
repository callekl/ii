using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace IIProjectClient.Models
{
    public class Location
    {
        public string Epc { get; set; }
        public string Name { get; set; }

        public static Location FromXml(XElement xml)
        {
            Location location = new Location();
            location.Name = (string)xml.Element("Name");
            location.Epc = (string)xml.Element("Epc");

            return location;
        }
    }
}