﻿namespace WebSocketClient
{
    partial class WebSocketClient
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.messages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tagAntenna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tagObject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listAntennas = new System.Windows.Forms.ListBox();
            this.listTags = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.labelAntenna = new System.Windows.Forms.Label();
            this.labelObject = new System.Windows.Forms.Label();
            this.labelIDAntenna = new System.Windows.Forms.Label();
            this.labelIDObject = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.formatFile = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.listAngles = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.listDistances = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.currentAngle = new System.Windows.Forms.Label();
            this.currentDistance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filters = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label22 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.samples = new System.Windows.Forms.Label();
            this.timeLimit = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.samplesLimit = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messages
            // 
            this.messages.FormattingEnabled = true;
            this.messages.HorizontalExtent = 10000;
            this.messages.HorizontalScrollbar = true;
            this.messages.ItemHeight = 16;
            this.messages.Location = new System.Drawing.Point(12, 329);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(1105, 244);
            this.messages.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL : ";
            // 
            // serverUrl
            // 
            this.serverUrl.Location = new System.Drawing.Point(55, 29);
            this.serverUrl.Name = "serverUrl";
            this.serverUrl.Size = new System.Drawing.Size(265, 22);
            this.serverUrl.TabIndex = 4;
            this.serverUrl.Text = "ws://172.24.24.2:6093/";
            this.serverUrl.TextChanged += new System.EventHandler(this.serverUrl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Actived Antenna";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tagAntenna
            // 
            this.tagAntenna.Enabled = false;
            this.tagAntenna.Location = new System.Drawing.Point(117, 87);
            this.tagAntenna.Name = "tagAntenna";
            this.tagAntenna.Size = new System.Drawing.Size(152, 22);
            this.tagAntenna.TabIndex = 7;
            this.tagAntenna.TextChanged += new System.EventHandler(this.tagAntenna_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tag Antenna : ";
            // 
            // tagObject
            // 
            this.tagObject.Enabled = false;
            this.tagObject.Location = new System.Drawing.Point(98, 142);
            this.tagObject.Name = "tagObject";
            this.tagObject.Size = new System.Drawing.Size(171, 22);
            this.tagObject.TabIndex = 10;
            this.tagObject.TextChanged += new System.EventHandler(this.tagObject_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tag Object : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Listened Object";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Listening to Antenna :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Filters";
            // 
            // listAntennas
            // 
            this.listAntennas.FormattingEnabled = true;
            this.listAntennas.ItemHeight = 16;
            this.listAntennas.Location = new System.Drawing.Point(798, 28);
            this.listAntennas.Name = "listAntennas";
            this.listAntennas.Size = new System.Drawing.Size(115, 292);
            this.listAntennas.TabIndex = 13;
            this.listAntennas.SelectedIndexChanged += new System.EventHandler(this.listAntennas_SelectedIndexChanged);
            // 
            // listTags
            // 
            this.listTags.FormattingEnabled = true;
            this.listTags.ItemHeight = 16;
            this.listTags.Location = new System.Drawing.Point(919, 28);
            this.listTags.Name = "listTags";
            this.listTags.Size = new System.Drawing.Size(202, 292);
            this.listTags.TabIndex = 14;
            this.listTags.SelectedIndexChanged += new System.EventHandler(this.listTags_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(795, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "List of Antennas :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(916, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "List of Tags : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Listening to Object :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "ID Antenna :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "ID Object :";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(342, 9);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 31);
            this.connectButton.TabIndex = 21;
            this.connectButton.Text = "Open";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(342, 46);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 31);
            this.disconnectButton.TabIndex = 22;
            this.disconnectButton.Text = "Close";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // labelAntenna
            // 
            this.labelAntenna.AutoSize = true;
            this.labelAntenna.Location = new System.Drawing.Point(165, 199);
            this.labelAntenna.Name = "labelAntenna";
            this.labelAntenna.Size = new System.Drawing.Size(103, 17);
            this.labelAntenna.TabIndex = 23;
            this.labelAntenna.Text = "*******************\r\n";
            // 
            // labelObject
            // 
            this.labelObject.AutoSize = true;
            this.labelObject.Location = new System.Drawing.Point(153, 249);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(113, 17);
            this.labelObject.TabIndex = 24;
            this.labelObject.Text = "*********************\r\n";
            this.labelObject.Click += new System.EventHandler(this.labelObject_Click);
            // 
            // labelIDAntenna
            // 
            this.labelIDAntenna.AutoSize = true;
            this.labelIDAntenna.Location = new System.Drawing.Point(104, 223);
            this.labelIDAntenna.Name = "labelIDAntenna";
            this.labelIDAntenna.Size = new System.Drawing.Size(268, 17);
            this.labelIDAntenna.TabIndex = 25;
            this.labelIDAntenna.Text = "****************************************************";
            // 
            // labelIDObject
            // 
            this.labelIDObject.AutoSize = true;
            this.labelIDObject.Location = new System.Drawing.Point(93, 276);
            this.labelIDObject.Name = "labelIDObject";
            this.labelIDObject.Size = new System.Drawing.Size(278, 17);
            this.labelIDObject.TabIndex = 26;
            this.labelIDObject.Text = "******************************************************";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Messages Log :";
            // 
            // formatFile
            // 
            this.formatFile.Enabled = false;
            this.formatFile.Location = new System.Drawing.Point(653, 31);
            this.formatFile.Name = "formatFile";
            this.formatFile.Size = new System.Drawing.Size(37, 22);
            this.formatFile.TabIndex = 30;
            this.formatFile.Text = ".csv";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(445, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Name :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(445, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Output file";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(445, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "Distance : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(445, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "Controls parameters";
            // 
            // listAngles
            // 
            this.listAngles.FormattingEnabled = true;
            this.listAngles.ItemHeight = 16;
            this.listAngles.Location = new System.Drawing.Point(621, 112);
            this.listAngles.Name = "listAngles";
            this.listAngles.Size = new System.Drawing.Size(155, 164);
            this.listAngles.TabIndex = 35;
            this.listAngles.SelectedIndexChanged += new System.EventHandler(this.listAngles_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(618, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "Angle :";
            // 
            // listDistances
            // 
            this.listDistances.FormattingEnabled = true;
            this.listDistances.ItemHeight = 16;
            this.listDistances.Location = new System.Drawing.Point(448, 112);
            this.listDistances.Name = "listDistances";
            this.listDistances.Size = new System.Drawing.Size(155, 164);
            this.listDistances.TabIndex = 37;
            this.listDistances.SelectedIndexChanged += new System.EventHandler(this.listDistances_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(445, 292);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 17);
            this.label20.TabIndex = 39;
            this.label20.Text = "Current distance :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(628, 292);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 17);
            this.label21.TabIndex = 40;
            this.label21.Text = "Current angle :";
            // 
            // currentAngle
            // 
            this.currentAngle.AutoSize = true;
            this.currentAngle.Location = new System.Drawing.Point(736, 292);
            this.currentAngle.Name = "currentAngle";
            this.currentAngle.Size = new System.Drawing.Size(23, 17);
            this.currentAngle.TabIndex = 41;
            this.currentAngle.Text = "***";
            // 
            // currentDistance
            // 
            this.currentDistance.AutoSize = true;
            this.currentDistance.Location = new System.Drawing.Point(571, 292);
            this.currentDistance.Name = "currentDistance";
            this.currentDistance.Size = new System.Drawing.Size(33, 17);
            this.currentDistance.TabIndex = 42;
            this.currentDistance.Text = "*****";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 43;
            this.button1.Text = "Filters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.testButton);
            // 
            // filters
            // 
            this.filters.AutoSize = true;
            this.filters.Location = new System.Drawing.Point(365, 122);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(29, 17);
            this.filters.TabIndex = 44;
            this.filters.Text = "ON";
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(342, 142);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 31);
            this.cleanButton.TabIndex = 45;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(108, 584);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(348, 23);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 586);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 17);
            this.label22.TabIndex = 47;
            this.label22.Text = "File creation :";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(321, 179);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 23);
            this.clearButton.TabIndex = 48;
            this.clearButton.Text = "Clear All Files";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(807, 586);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 17);
            this.label23.TabIndex = 49;
            this.label23.Text = "Time :";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(857, 587);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 17);
            this.time.TabIndex = 50;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(993, 586);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 17);
            this.label24.TabIndex = 51;
            this.label24.Text = "Samples :";
            // 
            // samples
            // 
            this.samples.AutoSize = true;
            this.samples.Location = new System.Drawing.Point(1064, 587);
            this.samples.Name = "samples";
            this.samples.Size = new System.Drawing.Size(0, 17);
            this.samples.TabIndex = 52;
            // 
            // timeLimit
            // 
            this.timeLimit.Location = new System.Drawing.Point(697, 584);
            this.timeLimit.Name = "timeLimit";
            this.timeLimit.Size = new System.Drawing.Size(32, 22);
            this.timeLimit.TabIndex = 54;
            this.timeLimit.Text = "300";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(616, 587);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 17);
            this.label25.TabIndex = 53;
            this.label25.Text = "Time limit :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(739, 586);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 17);
            this.label26.TabIndex = 55;
            this.label26.Text = "seconds";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(469, 587);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 17);
            this.label27.TabIndex = 56;
            this.label27.Text = "Samples limit :";
            // 
            // samplesLimit
            // 
            this.samplesLimit.Enabled = false;
            this.samplesLimit.Location = new System.Drawing.Point(571, 585);
            this.samplesLimit.Name = "samplesLimit";
            this.samplesLimit.Size = new System.Drawing.Size(32, 22);
            this.samplesLimit.TabIndex = 57;
            this.samplesLimit.Text = "100";
            // 
            // fileName
            // 
            this.fileName.Enabled = false;
            this.fileName.Location = new System.Drawing.Point(495, 31);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(153, 22);
            this.fileName.TabIndex = 58;
            // 
            // WebSocketClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 621);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.samplesLimit);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.timeLimit);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.samples);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.filters);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentDistance);
            this.Controls.Add(this.currentAngle);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.listDistances);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.listAngles);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.formatFile);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelIDObject);
            this.Controls.Add(this.labelIDAntenna);
            this.Controls.Add(this.labelObject);
            this.Controls.Add(this.labelAntenna);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listTags);
            this.Controls.Add(this.listAntennas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tagObject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tagAntenna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messages);
            this.Name = "WebSocketClient";
            this.Text = "Simple WebSocketClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox messages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tagAntenna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tagObject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listAntennas;
        private System.Windows.Forms.ListBox listTags;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label labelAntenna;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.Label labelIDAntenna;
        private System.Windows.Forms.Label labelIDObject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox formatFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox listAngles;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox listDistances;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label currentAngle;
        private System.Windows.Forms.Label currentDistance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label filters;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label samples;
        private System.Windows.Forms.TextBox timeLimit;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox samplesLimit;
        private System.Windows.Forms.TextBox fileName;
    }
}

