using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ICT365_Assignment1
{
    public partial class PeopleForm : Form
    {
        /// <summary>
        /// People screen
        /// </summary>

        PeopleDictionary pplDict = new PeopleDictionary();
        int counter;
        MainForm main;
        int index;
        string photopath; 

        public PeopleForm()
        {
            InitializeComponent();
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            gBoxAddPpl.Hide();
            panelInfo.Hide();

            for (int i = 0; i < pplDict.GetDict().Count; i++)
            {
                People person = pplDict.GetDict()["Person " + (i+1).ToString()];
                listPpl.Items.Insert(i, (person.FirstName + " " + person.LastName + Environment.NewLine));
            }
        }

        private void btnAddPpl_Click(object sender, EventArgs e)
        {
            gBoxAddPpl.Show(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gBoxAddPpl.Hide();
            counter = pplDict.GetDict().Count; 
            counter++;
            pplDict.addPeople(counter, textAddFName.Text, textAddLName.Text, textAddRs.Text, textAddAdrs.Text, textAddNo.Text, photopath);
            listPpl.Items.Insert(counter-1, (textAddFName.Text + " " + textAddLName.Text + Environment.NewLine));
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = @":C\",
                Title = "Please select a file to upload",
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };

            if (dialog.ShowDialog() == DialogResult.OK)     //saves it to project directory
            {
                var filepath = "..\\..\\people";
                photopath = filepath + "\\" + Path.GetFileName(dialog.FileName);
                File.Copy(dialog.FileName, photopath);
            }                
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            if(main == null)
            {
                main = new MainForm(); 
            }

            this.Hide();
            main.ShowDialog();
        }

        private void listPpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listPpl.SelectedIndex+1; 
            panelInfo.Paint += new PaintEventHandler(panelInfo_Paint);   //calls and shows the event information panel
            panelInfo.Refresh();
            panelInfo.Show(); 
        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {
            People personPanel = pplDict.GetDict()["Person " + index.ToString()];

            pictureBox1.ImageLocation = personPanel.Photopath;
            lblNameVal.Text = personPanel.FirstName + " " + personPanel.LastName;
            lblRsVal.Text = personPanel.Relationship;
            lblAddVal.Text = personPanel.Address;
            lblContactVal.Text = personPanel.Contact;
        }

        private void btnCloseInfo_Click(object sender, EventArgs e)
        {
            panelInfo.Hide(); 
        }
    }
}
