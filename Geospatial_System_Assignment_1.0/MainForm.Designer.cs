
namespace ICT365_Assignment1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.toggleGeoProfile = new System.Windows.Forms.CheckBox();
            this.lblNearest = new System.Windows.Forms.Label();
            this.gBoxAddEvt = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblAddDesc = new System.Windows.Forms.Label();
            this.textAddDesc = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.lblAddType = new System.Windows.Forms.Label();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblMenuHead = new System.Windows.Forms.Label();
            this.panelEvents = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.gpBoxEvent = new System.Windows.Forms.GroupBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnDownloadGPX = new System.Windows.Forms.Button();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.pictBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescValue = new System.Windows.Forms.Label();
            this.lblEventDesc = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblEventIDValue = new System.Windows.Forms.Label();
            this.lblEventID = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.gBoxAddEvt.SuspendLayout();
            this.panelEvents.SuspendLayout();
            this.gpBoxEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(611, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 18;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(611, 450);
            this.map.TabIndex = 1;
            this.map.Zoom = 15D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSideMenu.BackColor = System.Drawing.Color.Linen;
            this.panelSideMenu.Controls.Add(this.toggleGeoProfile);
            this.panelSideMenu.Controls.Add(this.lblNearest);
            this.panelSideMenu.Controls.Add(this.gBoxAddEvt);
            this.panelSideMenu.Controls.Add(this.btnPeople);
            this.panelSideMenu.Controls.Add(this.btnAddEvent);
            this.panelSideMenu.Controls.Add(this.btnRetrieve);
            this.panelSideMenu.Controls.Add(this.lblMenuHead);
            this.panelSideMenu.Location = new System.Drawing.Point(609, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(192, 450);
            this.panelSideMenu.TabIndex = 2;
            // 
            // toggleGeoProfile
            // 
            this.toggleGeoProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleGeoProfile.Appearance = System.Windows.Forms.Appearance.Button;
            this.toggleGeoProfile.AutoSize = true;
            this.toggleGeoProfile.Location = new System.Drawing.Point(47, 91);
            this.toggleGeoProfile.Name = "toggleGeoProfile";
            this.toggleGeoProfile.Size = new System.Drawing.Size(91, 23);
            this.toggleGeoProfile.TabIndex = 18;
            this.toggleGeoProfile.Text = "View Geoprofile";
            this.toggleGeoProfile.UseVisualStyleBackColor = true;
            this.toggleGeoProfile.CheckedChanged += new System.EventHandler(this.toggleGeoProfile_CheckedChanged);
            // 
            // lblNearest
            // 
            this.lblNearest.AutoSize = true;
            this.lblNearest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNearest.Location = new System.Drawing.Point(3, 354);
            this.lblNearest.Name = "lblNearest";
            this.lblNearest.Size = new System.Drawing.Size(192, 17);
            this.lblNearest.TabIndex = 16;
            this.lblNearest.Text = "Get From Nearest Marker";
            // 
            // gBoxAddEvt
            // 
            this.gBoxAddEvt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxAddEvt.Controls.Add(this.btnSave);
            this.gBoxAddEvt.Controls.Add(this.btnUpload);
            this.gBoxAddEvt.Controls.Add(this.lblAddDesc);
            this.gBoxAddEvt.Controls.Add(this.textAddDesc);
            this.gBoxAddEvt.Controls.Add(this.comboBox);
            this.gBoxAddEvt.Controls.Add(this.lblAddType);
            this.gBoxAddEvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAddEvt.Location = new System.Drawing.Point(1, 175);
            this.gBoxAddEvt.Name = "gBoxAddEvt";
            this.gBoxAddEvt.Size = new System.Drawing.Size(188, 162);
            this.gBoxAddEvt.TabIndex = 15;
            this.gBoxAddEvt.TabStop = false;
            this.gBoxAddEvt.Text = "Add Event";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(101, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(9, 125);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 9;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblAddDesc
            // 
            this.lblAddDesc.AutoSize = true;
            this.lblAddDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesc.Location = new System.Drawing.Point(6, 65);
            this.lblAddDesc.Name = "lblAddDesc";
            this.lblAddDesc.Size = new System.Drawing.Size(69, 15);
            this.lblAddDesc.TabIndex = 8;
            this.lblAddDesc.Text = "Description";
            // 
            // textAddDesc
            // 
            this.textAddDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddDesc.Location = new System.Drawing.Point(9, 83);
            this.textAddDesc.Name = "textAddDesc";
            this.textAddDesc.Size = new System.Drawing.Size(167, 20);
            this.textAddDesc.TabIndex = 7;
            this.textAddDesc.TextChanged += new System.EventHandler(this.textAddDesc_TextChanged);
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(55, 31);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 23);
            this.comboBox.TabIndex = 6;
            this.comboBox.SelectedValueChanged += new System.EventHandler(this.comboDropDownEvents_SelectedValueChanged);
            // 
            // lblAddType
            // 
            this.lblAddType.AutoSize = true;
            this.lblAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddType.Location = new System.Drawing.Point(6, 36);
            this.lblAddType.Name = "lblAddType";
            this.lblAddType.Size = new System.Drawing.Size(43, 15);
            this.lblAddType.TabIndex = 5;
            this.lblAddType.Text = "Event: ";
            // 
            // btnPeople
            // 
            this.btnPeople.Location = new System.Drawing.Point(47, 52);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(91, 23);
            this.btnPeople.TabIndex = 4;
            this.btnPeople.Text = "View People";
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(47, 144);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(91, 23);
            this.btnAddEvent.TabIndex = 3;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(33, 379);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(123, 23);
            this.btnRetrieve.TabIndex = 2;
            this.btnRetrieve.Text = "Retrieve Information";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lblMenuHead
            // 
            this.lblMenuHead.AutoSize = true;
            this.lblMenuHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuHead.Location = new System.Drawing.Point(65, 14);
            this.lblMenuHead.Name = "lblMenuHead";
            this.lblMenuHead.Size = new System.Drawing.Size(63, 24);
            this.lblMenuHead.TabIndex = 1;
            this.lblMenuHead.Text = "Menu";
            // 
            // panelEvents
            // 
            this.panelEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEvents.Controls.Add(this.btnBack);
            this.panelEvents.Controls.Add(this.gpBoxEvent);
            this.panelEvents.Location = new System.Drawing.Point(12, 14);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(577, 412);
            this.panelEvents.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(465, 374);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 26);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "OK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gpBoxEvent
            // 
            this.gpBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxEvent.Controls.Add(this.lblDateTime);
            this.gpBoxEvent.Controls.Add(this.btnDownloadGPX);
            this.gpBoxEvent.Controls.Add(this.videoPlayer);
            this.gpBoxEvent.Controls.Add(this.label1);
            this.gpBoxEvent.Controls.Add(this.pictBox1);
            this.gpBoxEvent.Controls.Add(this.lblDescValue);
            this.gpBoxEvent.Controls.Add(this.lblEventDesc);
            this.gpBoxEvent.Controls.Add(this.lblEvent);
            this.gpBoxEvent.Controls.Add(this.lblEventName);
            this.gpBoxEvent.Controls.Add(this.lblLong);
            this.gpBoxEvent.Controls.Add(this.lblLat);
            this.gpBoxEvent.Controls.Add(this.lblLatitude);
            this.gpBoxEvent.Controls.Add(this.lblEventIDValue);
            this.gpBoxEvent.Controls.Add(this.lblEventID);
            this.gpBoxEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxEvent.Location = new System.Drawing.Point(15, 14);
            this.gpBoxEvent.Name = "gpBoxEvent";
            this.gpBoxEvent.Size = new System.Drawing.Size(536, 354);
            this.gpBoxEvent.TabIndex = 1;
            this.gpBoxEvent.TabStop = false;
            this.gpBoxEvent.Text = "Event";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(6, 264);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(42, 18);
            this.lblDateTime.TabIndex = 14;
            this.lblDateTime.Text = "value";
            // 
            // btnDownloadGPX
            // 
            this.btnDownloadGPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadGPX.Location = new System.Drawing.Point(15, 302);
            this.btnDownloadGPX.Name = "btnDownloadGPX";
            this.btnDownloadGPX.Size = new System.Drawing.Size(161, 28);
            this.btnDownloadGPX.TabIndex = 12;
            this.btnDownloadGPX.Text = "Download GPX File";
            this.btnDownloadGPX.UseVisualStyleBackColor = true;
            this.btnDownloadGPX.Click += new System.EventHandler(this.btnDownloadGPX_Click);
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(212, 119);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(299, 211);
            this.videoPlayer.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Longitude:";
            // 
            // pictBox1
            // 
            this.pictBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictBox1.Location = new System.Drawing.Point(212, 119);
            this.pictBox1.Name = "pictBox1";
            this.pictBox1.Size = new System.Drawing.Size(299, 211);
            this.pictBox1.TabIndex = 9;
            this.pictBox1.TabStop = false;
            // 
            // lblDescValue
            // 
            this.lblDescValue.AutoSize = true;
            this.lblDescValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescValue.Location = new System.Drawing.Point(20, 147);
            this.lblDescValue.Name = "lblDescValue";
            this.lblDescValue.Size = new System.Drawing.Size(42, 18);
            this.lblDescValue.TabIndex = 8;
            this.lblDescValue.Text = "value";
            // 
            // lblEventDesc
            // 
            this.lblEventDesc.AutoSize = true;
            this.lblEventDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDesc.Location = new System.Drawing.Point(6, 119);
            this.lblEventDesc.Name = "lblEventDesc";
            this.lblEventDesc.Size = new System.Drawing.Size(110, 20);
            this.lblEventDesc.TabIndex = 7;
            this.lblEventDesc.Text = "Description: ";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(77, 77);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(42, 18);
            this.lblEvent.TabIndex = 6;
            this.lblEvent.Text = "value";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(6, 76);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(65, 20);
            this.lblEventName.TabIndex = 5;
            this.lblEventName.Text = "Event: ";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.Location = new System.Drawing.Point(331, 78);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(75, 18);
            this.lblLong.TabIndex = 4;
            this.lblLong.Text = "valueLong";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(317, 40);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(62, 18);
            this.lblLat.TabIndex = 3;
            this.lblLat.Text = "valueLat";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(231, 38);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(80, 20);
            this.lblLatitude.TabIndex = 2;
            this.lblLatitude.Text = "Latitude:";
            // 
            // lblEventIDValue
            // 
            this.lblEventIDValue.AutoSize = true;
            this.lblEventIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventIDValue.Location = new System.Drawing.Point(96, 38);
            this.lblEventIDValue.Name = "lblEventIDValue";
            this.lblEventIDValue.Size = new System.Drawing.Size(42, 18);
            this.lblEventIDValue.TabIndex = 1;
            this.lblEventIDValue.Text = "value";
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.Location = new System.Drawing.Point(6, 37);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(84, 20);
            this.lblEventID.TabIndex = 0;
            this.lblEventID.Text = "Event ID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEvents);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.gBoxAddEvt.ResumeLayout(false);
            this.gBoxAddEvt.PerformLayout();
            this.panelEvents.ResumeLayout(false);
            this.gpBoxEvent.ResumeLayout(false);
            this.gpBoxEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Label lblMenuHead;
        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gpBoxEvent;
        private System.Windows.Forms.PictureBox pictBox1;
        private System.Windows.Forms.Label lblDescValue;
        private System.Windows.Forms.Label lblEventDesc;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblEventIDValue;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.Button btnDownloadGPX;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.GroupBox gBoxAddEvt;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label lblAddType;
        private System.Windows.Forms.Label lblAddDesc;
        private System.Windows.Forms.TextBox textAddDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblNearest;
        private System.Windows.Forms.CheckBox toggleGeoProfile;
    }
}

