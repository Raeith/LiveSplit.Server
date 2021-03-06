﻿using LiveSplit.Model;
using System;

[assembly: LiveSplit.UI.Components.ComponentFactory(typeof(LiveSplit.UI.Components.Factory))]

namespace LiveSplit.UI.Components
{
    public class Factory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "LiveSplit Server"; }
        }

        public string Description
        {
            get { return "Allows a remote connection and control of LiveSplit by starting a small server within LiveSplit."; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Control; }
        }

        public IComponent Create(LiveSplitState state)
        {
           return new Component(state);
        }

        public string UpdateName
        {
            get { return ComponentName; }
        }

        public string UpdateURL
        {
            get { return "http://livesplit.org/update/"; }
        }

        public Version Version
        {
            get { return Version.Parse("1.2.0"); }
        }

        public string XMLURL
        {
            get { return "http://livesplit.org/update/Components/LiveSplit.Server.xml"; }
        }
    }
}
