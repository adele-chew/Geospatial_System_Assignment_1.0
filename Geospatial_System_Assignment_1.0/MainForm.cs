using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Xml;
using System.Xml.Linq;
using WMPLib;
using System.IO;

namespace ICT365_Assignment1
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// main display of application (map)
        /// </summary>

        GMapOverlay markers = new GMapOverlay("Markers");                               //overlay with all markers
        GMapOverlay tempOverlay = new GMapOverlay("TempOverlay");                       //overlay for temporary marker and line to indicate nearest marker
        GMapOverlay geoprofile = new GMapOverlay("Geoprofile");                         //overlay for geoprofile
        EventsDictionary eventsDict = new EventsDictionary();                                   //events dictionary 
        int temp;                                                                       //temporary variable to store event id
        int counter;                                                                     //counter for number of events 
        string filepath, eType, eDesc;                                                  //temporary variable to store filepath, event type and event description
        double lat, lon;                                                                //temporary variable to store latitude and longitude
        List<PointLatLng> pointList = new List<PointLatLng>();                          //storing all points
        PeopleForm pplForm; 

        //add custom markers
        Bitmap markerBasic = (Bitmap)Image.FromFile("..\\..\\markers\\basic.png");
        Bitmap markerFB = (Bitmap)Image.FromFile("..\\..\\markers\\facebook.png");
        Bitmap markerHabit = (Bitmap)Image.FromFile("..\\..\\markers\\habit-track.png");
        Bitmap markerMood = (Bitmap)Image.FromFile("..\\..\\markers\\mood-track.png");
        Bitmap markerPhoto = (Bitmap)Image.FromFile("..\\..\\markers\\photo.png");
        Bitmap markerRemind = (Bitmap)Image.FromFile("..\\..\\markers\\reminder.png");
        Bitmap markerTrack = (Bitmap)Image.FromFile("..\\..\\markers\\tracklog.png");
        Bitmap markerTwit = (Bitmap)Image.FromFile("..\\..\\markers\\twitter.png");
        Bitmap markerVid = (Bitmap)Image.FromFile("..\\..\\markers\\video.png");

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setting up GMap.NET
            //GMapProviders.GoogleMap.ApiKey = "KEY EDITED OUT";
            GMaps.Instance.Mode = AccessMode.ServerAndCache; 
            map.CacheLocation = @"cache";
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.SetPositionByKeywords("Serangoon, Singapore");
            map.Overlays.Add(markers);                       //add markers overlay to the map
            map.Overlays.Add(geoprofile);                      //add geoprofile overlay
            map.Overlays.Add(tempOverlay);                   //overlay to create temporary marker and line polygon for retrieving information to map

            //hiding extra menus and panels
            panelEvents.Visible = false;
            videoPlayer.Hide();
            btnDownloadGPX.Hide();
            btnAddEvent.Hide();
            gBoxAddEvt.Hide();
            lblAddDesc.Hide();
            textAddDesc.Hide();
            btnUpload.Hide();
            btnSave.Hide();
            btnRetrieve.Hide();
            lblNearest.Hide();

            //adding items to combobox dropdown for selecting event type on add event menu
            comboBox.Items.Add("Facebook Status");
            comboBox.Items.Add("Tweet");
            comboBox.Items.Add("Photo");
            comboBox.Items.Add("Video");
            comboBox.Items.Add("Tracklog");
            comboBox.Items.Add("Habit Tracker");
            comboBox.Items.Add("Mood Tracker");
            comboBox.Items.Add("Reminder");
            comboBox.Items.Add("Miscellaneous");

            //populating markers with location information
            foreach (var data in eventsDict.GetDict())
            {
                createMarker(data.Value.EventID, data.Value.EventName, data.Value.Lat, data.Value.Lon);                
            }

            createCircle(pointList.ElementAt(1), 0.0075, 50);
            geoprofile.IsVisibile = false;

            //onclick marker event
            map.OnMarkerClick += (marker, mouseArgs) =>
            {
                temp = (int)marker.Tag;                                     //temporary variable stores the marker tag information
                panelEvents.Paint += new PaintEventHandler(panel1_Paint);   //calls and shows the event information panel
                panelEvents.Refresh();
                panelEvents.Show();
            };
        }

        //create marker method with custom markers for GUI
        private void createMarker(int id, string name,  double lat, double lon)
        {
            PointLatLng point = new PointLatLng(lat, lon);            
            GMapMarker marker; 

            if(name == "Facebook Status")
            {
                marker = new GMarkerGoogle(point, markerFB);
            }
            else if(name == "Habit Tracker")
            {
                marker = new GMarkerGoogle(point, markerHabit);
            }
            else if (name == "Mood Tracker")
            {
                marker = new GMarkerGoogle(point, markerMood);
            }
            else if (name == "Photo")
            {
                marker = new GMarkerGoogle(point, markerPhoto);
            }
            else if (name == "Reminder")
            {
                marker = new GMarkerGoogle(point, markerRemind);
            }
            else if (name == "Tracklog")
            {
                marker = new GMarkerGoogle(point, markerTrack);
            }
            else if (name == "Tweet")
            {
                marker = new GMarkerGoogle(point, markerTwit);
            }
            else if (name == "Video")
            {
                marker = new GMarkerGoogle(point, markerVid);
            }
            else
            {
                marker = new GMarkerGoogle(point, markerBasic);
            }

            marker.Tag = id;
            marker.ToolTipText = id.ToString();             //tagging markers with event ID information
            markers.Markers.Add(marker);                    //tool tip text displaying event id for markers
            map.Overlays.Add(markers);                      //add markers to overlay
            pointList.Add(point);
        }

        //create circle method for geoprofile
        private void createCircle(PointLatLng point, double radius, int segments)
        {
            //create a geoprofile based on user's first event log 
            //reusing code from https://stackoverflow.com/questions/9308673/how-to-draw-circle-on-the-map-using-gmap-net-in-c-sharp
            //from user elasticrash done on March 20th 2012, and edited by user Marco Sbrissa on April 2nd 2021 

            List<PointLatLng> circlePts = new List<PointLatLng>();          //list of points to create circle
            point = pointList.ElementAt(1);                     //first event location

            double seg = Math.PI * 2 / segments;                             //getting the radian value of each segment

            for (int i = 0; i < segments; i++)                               //for each segment of the circle
            {
                double theta = seg * i;                                     //basic angle multiplied by the segment
                double a = point.Lat + Math.Cos(theta) * radius;            //taking polar coordinates(radius, theta) and converting it to the x cartesian coordinate onto the map (cos(theta) functions on the x axis) 
                double b = point.Lng + Math.Sin(theta) * radius;            //taking polar coordinates(radius, theta) and converting it to the y cartesian coordinate onto the map (sin(theta) functions on the y axis)

                PointLatLng cirPt = new PointLatLng(a, b);                  //making a new point based on the coordinates obtained above to create a point of the circle

                circlePts.Add(cirPt);                                       //adds it to the pointlatlng list
            }
            GMapPolygon circle = new GMapPolygon(circlePts, "Circle");      //instantiates the circle, using the points from the circle from the circlePts list 

            geoprofile.Polygons.Add(circle);                               //adds the circle to the overlay 
        }

        //events information panel
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //creates Events object and finds the corresponding event id tag in dictionary into object
            Events markerEvent = eventsDict.GetDict()["Event " + temp.ToString()];    

            //inputs all related values into corresponding labels on panel
            lblEventIDValue.Text = markerEvent.EventID.ToString();
            lblEvent.Text = markerEvent.EventName;
            lblDescValue.Text = markerEvent.Desc;
            lblLat.Text = markerEvent.Lat.ToString();
            lblLong.Text = markerEvent.Lon.ToString();
            lblDateTime.Text = markerEvent.Datetime; 

            //if the marker event is a photo, display the photo
            if (markerEvent.EventName == "Photo")
            {
                pictBox1.Show(); 
                pictBox1.ImageLocation = markerEvent.Desc;
            }

            //if the marker event is a video, display the video
            //feature not implemented correctly: video player is not working. 
            if (markerEvent.EventName == "Video")
            {
                videoPlayer.Show();
                videoPlayer.URL = Path.Combine(
                                        AppDomain.CurrentDomain.BaseDirectory, markerEvent.Desc); 
            }

            //if the marker event is a tracklog, allow user to download the tracklog file
            if (markerEvent.EventName == "Tracklog")
            {
                btnDownloadGPX.Show();
                filepath = markerEvent.Desc;  
            }
        }

        //dpwnloads tracklog file into user's desktop directory
        private void btnDownloadGPX_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string downloadsPath = Path.Combine(path + Path.GetFileName(filepath));
            File.Copy(filepath, downloadsPath);
        }
        
        //hides panel and goes back to map when OK button is clicked 
        private void btnBack_Click(object sender, EventArgs e)
        {
            btnDownloadGPX.Hide();
            videoPlayer.close();
            videoPlayer.Hide();
            pictBox1.Hide(); 
            panelEvents.Hide(); 
        }

        //toggle geoprofile on/off
        private void toggleGeoProfile_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleGeoProfile.Checked == true)
            {
                geoprofile.IsVisibile = true;
                toggleGeoProfile.Text = "Close Geoprofile";

            }
            else if (toggleGeoProfile.Checked == false)
            {
                geoprofile.IsVisibile = false; 
                toggleGeoProfile.Text = "View Geoprofile";
            }
                
        }

        //go to people screen
        private void btnPeople_Click(object sender, EventArgs e)
        {
            if(pplForm == null)
            {
                pplForm = new PeopleForm();
            }
            this.Hide();
            pplForm.Show();
        }

        //when left mouse button is clicked on the map, the add event button and retrieve information button appears. 
        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {   
                //resets map to default
                if (toggleGeoProfile.Checked == true)
                {
                    toggleGeoProfile.Checked = false;
                    geoprofile.IsVisibile = false;
                }

                //removes old temporary marker
                if (tempOverlay.Markers.Count != 0)
                {
                    tempOverlay.Markers.RemoveAt(0);
                }

                //removes any polyline drawn from retrieving information
                if (tempOverlay.Polygons.Count != 0)
                {
                    tempOverlay.Polygons.RemoveAt(0);
                }

                //obtains latitude + longitude from mouse click location
                lon = map.FromLocalToLatLng(e.X, e.Y).Lng;
                lat = map.FromLocalToLatLng(e.X, e.Y).Lat;

                //creates new marker
                PointLatLng pos = new PointLatLng(lat, lon);    
                GMapMarker mark = new GMarkerGoogle(pos, markerBasic);
                tempOverlay.Markers.Add(mark);
                map.Overlays.Add(tempOverlay);

                btnAddEvent.Show();
                btnRetrieve.Show();
            }
        }

        //displays the add event menu 
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            gBoxAddEvt.Show();
            btnRetrieve.Hide(); 
        }

        //combobox dropdownlist for event type 
        private void comboDropDownEvents_SelectedValueChanged(object sender, EventArgs e)
        {
            eType = comboBox.SelectedItem.ToString();
            if (eType == "Tracklog"||eType == "Photo"||eType == "Video")
            {
                btnUpload.Show(); 
            }
            else
            {
                lblAddDesc.Show();
                textAddDesc.Show(); 
            }
        }

        //upload file to project directory
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @":C\";
            dialog.Title = "Please select a file to upload";

            if (eType == "Photo")                          //filters for photo type files
            {
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                filepath = "..\\..\\img";
            }
            else if (eType == "Video")                      //filters for video type files
            {
                dialog.Filter = "All Videos Files |*.dat; *.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                  " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm";
                filepath = "..\\..\\videos";
            }
            else if (eType == "Tracklog")                   //filters for .gpx type files
            {
                dialog.Filter = "GPX Files|*.gpx";
                filepath = "..\\..\\tracklog";
            }

            if (dialog.ShowDialog() == DialogResult.OK)     //saves it to project directory
            {
                var destinationFile = filepath + "\\" + Path.GetFileName(dialog.FileName);
                File.Copy(dialog.FileName, destinationFile);
                eDesc = destinationFile;
                btnSave.Show(); 
            }

        }

        //if text box value changes, allow save
        private void textAddDesc_TextChanged(object sender, EventArgs e)
        {
            eDesc = textAddDesc.Text;
            btnSave.Show();
        }

        //saves new event to events dictionary, xml file, and creates a marker for it. then hides add event menu
        private void btnSave_Click(object sender, EventArgs e)
        {
            counter = eventsDict.GetDict().Count;
            counter++; 
            eventsDict.AddEvent(counter.ToString(), counter, eType, eDesc, lat, lon, DateTime.Now.ToString("dddd, dd MMMM yyyy h:mm tt"));
            eventsDict.AddToXML(counter, eType, eDesc, lat, lon, DateTime.Now.ToString("dddd, dd MMMM yyyy h:mm tt"));
            createMarker(counter, eType, lat, lon);

            gBoxAddEvt.Hide(); 
        }

        //retrieve information. draws a line from click location to the nearest marker
        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            PointLatLng ptClick = new PointLatLng(lat, lon);
            double minDistance = getDistance(ptClick, pointList.ElementAt(0));
            PointLatLng ptNearest = pointList.ElementAt(0);

            for (int i = 0; i < markers.Markers.Count; i++)
            {
                if (getDistance(ptClick, pointList.ElementAt(i)) < minDistance)
                {
                    minDistance = getDistance(ptClick, pointList.ElementAt(i));
                    ptNearest = pointList.ElementAt(i); 
                } 
            }

            List<PointLatLng> getShortest = new List<PointLatLng>();
            getShortest.Add(ptClick);
            getShortest.Add(ptNearest);

            GMapPolygon line = new GMapPolygon(getShortest, "Retrieve Information");
            line.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            line.Stroke = new Pen(Color.Red, 1);
            tempOverlay.Polygons.Add(line);
        }

        //gets the distance between two points
        public double getDistance(PointLatLng p1, PointLatLng p2)
        {
            GMapRoute route = new GMapRoute("getDistance");
            route.Points.Add(p1);
            route.Points.Add(p2);
            double distance = route.Distance;
            route.Clear();
            route = null;

            return distance;
        }
    }
}
