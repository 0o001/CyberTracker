using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberTracker
{
    public enum DangerType
    {
        Low = 0,
        Medium = 1,
        High = 2
    }

    class Track: IEquatable<Track>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DangerType DangerType { get; set; }

        public bool Equals(Track other)
        {
            if (other is null)
                return false;

            return Name == other.Name && Description == other.Description && DangerType == other.DangerType;
        }

        public override bool Equals(object obj) => Equals(obj as Track);
        public override int GetHashCode() => (Name, Description, DangerType).GetHashCode();
    }
}
