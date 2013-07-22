using System;
using System.Configuration;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;

namespace BIT.PilotlessPlane.Client
{
    internal static class Global
    {
        public enum CoordinateSystemsEnum
        {
            LeftHandedSystem = -1,
            RightHandedSystem = 1
        }

        public static readonly Font EnglishFont = new Font("Arial", 11F);

        public static readonly Font SmallEnglishFont = new Font("Arial", 7F);

        public static readonly Font SmallChineseFont = new Font("宋体", 9F);

        public static readonly CoordinateSystemsEnum CoordinateSystem = CoordinateSystemsEnum.RightHandedSystem;

        public static bool UseLocal
        {
            get { return bool.Parse(ConfigurationManager.AppSettings["UseLocal"]); }
        }

        public static int LocalDelay
        {
            get { return int.Parse(ConfigurationManager.AppSettings["LocalDelay"], CultureInfo.InvariantCulture); }
        }

        public static string PortName
        {
            get { return ConfigurationManager.AppSettings["PortName"]; }
        }

        public static int BaudRate
        {
            get { return int.Parse(ConfigurationManager.AppSettings["BaudRate"], CultureInfo.InvariantCulture); }
            set { ConfigurationManager.AppSettings["BaudRate"] = value.ToString(CultureInfo.InvariantCulture); }
        }

        public static System.IO.Ports.Parity Parity
        {
            get { return ParseEnum<System.IO.Ports.Parity>(ConfigurationManager.AppSettings["Parity"]); }
        }

        public static int DataBits
        {
            get { return int.Parse(ConfigurationManager.AppSettings["DataBits"], CultureInfo.InvariantCulture); }
        }

        public static System.IO.Ports.StopBits StopBits
        {
            get { return ParseEnum<System.IO.Ports.StopBits>(ConfigurationManager.AppSettings["StopBits"]); }
        }

        private static T ParseEnum<T>(string value)
        {
            Contract.Requires(typeof(T).IsEnum);

            return (T)Enum.Parse(typeof(T), value);
        }
    }
}
