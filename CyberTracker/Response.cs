using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberTracker
{
    class Response
    {

        public static List<Track> getTracks()
        {
            return new List<Track>()
            {
                new Track() { Name = "opera", Description = "Lorem ipsum dolor sit amet", DangerType = DangerType.Medium},
                new Track() { Name = "opera", Description = "Lorem ipsum dolor sit amet", DangerType = DangerType.Low},
                new Track() { Name = "spotify", Description = "Lorem ipsum dolor sit amet", DangerType = DangerType.Low },
                new Track() { Name = "notepad", Description = "Lorem ipsum dolor sit amet", DangerType = DangerType.High },

            };
        }
    }
}
