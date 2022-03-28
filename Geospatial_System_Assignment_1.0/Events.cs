using System;
using System.Linq;
using System.Xml.Linq;

namespace ICT365_Assignment1
{   
    /// <summary>
    /// events class
    /// </summary>
    public class Events
    {   
        private int eventID;                        //event id 
        private string eventName, desc, datetime;   // name of event, event description, datetimestamp 
        private double lat, lon;                    // latitude and longitude

        public Events() { }                         //default constructor

        public Events(int eventID, string eventName, string desc, double lat, double lon, string datetime){      //constructor with parameters 
            this.eventID = eventID;
            this.eventName = eventName;
            this.desc = desc;
            this.lat = lat;
            this.lon = lon;
            this.datetime = datetime;
        }

        //get/set for eventID
        public int EventID
        {
            get
            {
                return eventID;
            }

            set
            {
                eventID = value;
            }
        }

        //get/set for eventID
        public string EventName
        {
            get
            {
                return eventName;
            }
            set
            {
                eventName = value;
            }
        }

        //get/set for eventID
        public string Desc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }

        //get/set for eventID
        public double Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
            }
        }

        //get/set for eventID
        public double Lon
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
            }
        }

        //get/set for datetimestamp
        public string Datetime
        {
            get
            {
                return datetime;
            }

            set
            {
                datetime = value;
            }
        }
    }
}