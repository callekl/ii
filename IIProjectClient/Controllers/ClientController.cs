using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using IIProjectClient.InternalService;
using IIProjectClient.Models;

namespace IIProjectClient.Controllers
{
    public class ClientController : Controller
    {

        // GET: /Client/
        public ActionResult Index()
        {
            Service1Client client = new Service1Client();

            List<Location> locationList = new List<Location>();

            foreach (var item in client.GetAllLocations())
            {
                Location location = Location.FromXml(item);
                locationList.Add(location);
            }

            return View(locationList);
        }

        [HttpPost]
        public ActionResult Index(DateTime fromTime, DateTime toTime, string location)
        {
            Service1Client client = new Service1Client();
            client.GetEvents(fromTime, toTime, location);

            //client.GetVehicle("urn:epc:id:giai:123456.1847447213244"); <<<--- Fungerar!
            client.Close();

            return View("Index");
        }

        public ActionResult Test()
        {
            Service1Client client = new Service1Client();

            List<XElement> lista = new List<XElement>();

            foreach (XElement item in client.GetAllLocations())
            {
                lista.Add(item);
            }

            return View(lista);
        }

        public ActionResult Test2()
        {
            Service1Client client = new Service1Client();

            List<string> filenames = new List<string>();

            foreach (string item in client.GetFilenames())
            {
                filenames.Add(item);
            } 

            return View();
        }
    }
}
