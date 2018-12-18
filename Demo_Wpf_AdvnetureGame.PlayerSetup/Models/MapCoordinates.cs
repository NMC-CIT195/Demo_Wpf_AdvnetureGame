using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_AdventureGame.Models
{
    public class MapCoordinates
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public MapCoordinates(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }
    }
}
