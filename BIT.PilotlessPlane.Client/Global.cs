using System.Drawing;

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

        public static readonly CoordinateSystemsEnum CoordinateSystem = CoordinateSystemsEnum.RightHandedSystem;
    }
}
