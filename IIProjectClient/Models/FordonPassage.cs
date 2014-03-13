using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace IIProjectClient.Models
{
    public class FordonPassage
    {
        public string FordonEPC { get; set; }
        public string PlatsEPC { get; set; }
        public DateTime Tid { get; set; }
        public string Platsnamn { get; set; }
        public string EVN { get; set; }
        public string Fordonsinnehavare { get; set; }
        public string UnderhållsansvarigtFöretag { get; set; }
        public string FordonsTypochUnderkategori { get; set; }
        public string GiltigtGodkännande { get; set; }


        public static FordonPassage FromXML(XElement xml)
        {

            return null;
        }
    }
}