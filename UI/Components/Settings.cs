﻿using System;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class Settings : UserControl
    {
        public ushort Port { get; set; }

        public String PortString
        {
            get { return Port.ToString(); }
            set { Port = UInt16.Parse(value); }
        }

        public Settings()
        {
            InitializeComponent();
            Port = 16834;

            txtPort.DataBindings.Add("Text", this, "PortString", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var settingsNode = document.CreateElement("Settings");

            var portNode = document.CreateElement("Port");
            portNode.InnerText = PortString;
            settingsNode.AppendChild(portNode);

            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
            PortString = settings["Port"].InnerText;
        }
    }
}
