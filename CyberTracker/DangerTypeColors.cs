using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberTracker
{
    class DangerTypeColors
    {
        public static Color GetColor(DangerType dangerType)
        {
            switch (dangerType)
            {
                case DangerType.Low:
                default:
                    return Color.SteelBlue;
                case DangerType.Medium:
                    return Color.DarkOrange;
                case DangerType.High:
                    return Color.DarkRed;
            }
        }
    }
}
