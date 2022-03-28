using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            /*for testing 
            
            EventsDictionary dict = new EventsDictionary(); 

            foreach (KeyValuePair<string, Events> kvp in dict.GetDict())
            {
                Console.WriteLine($"Key: {kvp.Key}");
                Console.WriteLine($"EventName: {kvp.Value.EventName} \tDescription: {kvp.Value.Desc} " +
                    $"\tLatitude, Longitude: {kvp.Value.Lat}, {kvp.Value.Lon} \tDate Time: {kvp.Value.Datetime}");
            }*/
        }
    }
}