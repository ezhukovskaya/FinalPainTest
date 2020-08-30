using System;
using System.IO;

namespace FinalPaintTest.Framework.Constants.Paths
{
    public static class PathConstants
    {
        private static readonly string CurrentProjectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public static readonly string TestConfigurationPath = CurrentProjectPath + "/Framework/Configuration/config.xml";
        public static readonly string AppConfigurationPath = CurrentProjectPath + "/Framework/Configuration/application.xml";
    }
}