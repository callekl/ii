using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;
using IIProjectService.ExternalServices;

namespace IIProjectService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {

        public IEnumerable<string> GetFilenames()
        {
            EpcisEventServiceClient epcisClient = new EpcisEventServiceClient();
            IEnumerable<string> filenames = epcisClient.GetFilenames();          

            return filenames;
        }

        public IEnumerable<XElement> GetAllLocations()
        {
            NamingServiceClient namingClient = new NamingServiceClient();
            XElement locations = namingClient.GetAllLocations();
            namingClient.Close();

            // Stycka upp en stor XML-fil till en lista med individuella XML-element.
            List<XElement> allLocations = new List<XElement>();
            foreach (XElement item in locations.Descendants("Locations").Elements("Location"))
            {
                allLocations.Add(item);
            }

            return allLocations;
        }

        public XElement GetEvent(string filename)
        {
            EpcisEventServiceClient eventClient = new EpcisEventServiceClient();
            XElement oneEvent = eventClient.GetEvent(filename);
            eventClient.Close();

            return oneEvent;
        }

        public IEnumerable<XElement> GetEvents(DateTime fromInclusive, DateTime toInclusive, string readPointEPC)
        {
            EpcisEventServiceClient eventClient = new EpcisEventServiceClient();
            IEnumerable<XElement> events = eventClient.GetEvents(fromInclusive, toInclusive, readPointEPC);
            eventClient.Close();

            return events;
        }

        public XElement GetVehicle(string epc)
        {
            NamingServiceClient namingClient = new NamingServiceClient();
            XElement oneVehicle = namingClient.GetVehicle(epc);
            namingClient.Close();

            return oneVehicle;
        }

        public XElement GetLocation(string epc)
        {
            NamingServiceClient namingClient = new NamingServiceClient();
            XElement oneLocation = namingClient.GetLocation(epc);
            namingClient.Close();

            return oneLocation;
        }
        

    }
}
