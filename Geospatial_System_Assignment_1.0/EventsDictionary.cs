using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    /// <summary>
    /// Events Dictionary class to store dictionary of events 
    /// </summary>
    public class EventsDictionary
    {

        static XDocument file = XMLFile.getFile;            //call to singleton
        static string ns = "http://www.lifeloggers.org/your-life-log-events";      //string variable to store namespace
        Dictionary<string, Events> dict = new Dictionary<string, Events>();

        public EventsDictionary()
        {
            //create variables to store element's XName
            var elemEvent = XName.Get("Event", ns);
            var eventId = XName.Get("eventid", ns);
            var eventName = XName.Get("event-name", ns);
            var eventDesc = XName.Get("event-desc", ns);
            var lat = XName.Get("lat", ns);
            var lon = XName.Get("long", ns);
            var datetime = XName.Get("datetimestamp", ns);
            int i = 0;   //counter variable

            //temporary events collection to store values from xml 
            var events =
            from elem in file.Descendants(elemEvent)
            select new Events()
            {
                EventID = (int)elem.Element(eventId),
                EventName = (string)elem.Element(eventName),
                Desc = (string)elem.Element(eventDesc),
                Lat = (double)elem.Element(lat),
                Lon = (double)elem.Element(lon),
                Datetime = (string)elem.Element(datetime)
            };

            //populate dictionary 
            foreach (var data in events)
            {
                i++;
                dict.Add(("Event " + i.ToString()), new Events(data.EventID, data.EventName, data.Desc, data.Lat, data.Lon, data.Datetime));
            }
        }

        public Dictionary<string, Events> GetDict()                          //getter for dictionary
        {
            return dict; 
        }

        public void AddEvent(string i, int id, string eventName, string desc, double lat, double lon, string datetime)
        {
            dict.Add("Event " + i, new Events(id, eventName, desc, lat, lon, datetime));
        }

        //add event to xml file
        public void AddToXML(int id, string eventName, string desc, double lat, double lon, string datetime)
        {
            XNamespace soap = "http://www.w3.org/2001/12/soap-envelope";            //soap namespace
            XNamespace name = "http://www.lifeloggers.org/your-life-log-events";    //body namespace

            file.Root.Element(soap + "Body").Add(new XElement(name + "Event", new XElement(name + "eventid", id),
                                                                     new XElement(name + "event-name", eventName),
                                                                     new XElement(name + "event-desc", desc),
                                                                     new XElement(name + "lat", lat),
                                                                     new XElement(name + "long", lon),
                                                                     new XElement(name + "datetimestamp", datetime)));

            file.Save(@"..\..\lle-events.xml");
        }

        //read the instructions wrong and created a remove event instead of retrieve event 
        /*remove event from xml file
        public void RemoveEvent(int id)
        {
            XNamespace soap = "http://www.w3.org/2001/12/soap-envelope";
            XNamespace ns = "http://www.lifeloggers.org/your-life-log-events";

            //query to obtain the node matching event id
            var query = file.Descendants(ns + "Event").Where(x => x.Element(ns + "eventid").Value.Equals(id.ToString()));      //select nodes where eventid is equal to parameter id 

            //remove the information from that node
            query.Remove();
            
            file.Save(@"..\..\lle-events.xml");
        }*/
    }
}
