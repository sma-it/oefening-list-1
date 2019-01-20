using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public enum RoomSize
    {
        Small,
        Medium,
        Big,
        MaxValue,
    }

    public partial class Room
    {
        public RoomSize Size { get; }
        public int Area { get; }

        private static Random random = new Random();

        public Room(RoomSize Size)
        {
            this.Size = Size;
            switch(Size)
            {
                case RoomSize.Small:
                    Area = 5 + random.Next((int)Size * 5);
                    break;
                case RoomSize.Medium:
                    Area = 10 + random.Next((int)Size * 5);
                    break;
                case RoomSize.Big:
                    Area = 20 + random.Next((int)Size * 5);
                    break;
            }
        }

        public override string ToString()
        {
            return "This is a " 
                + Size + " room with an area of " 
                + Area + " square meters.";
        }
    }
}
