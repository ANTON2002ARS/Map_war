using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_war
{
    public class Map_Line
    {
        public Map_Line(List<Point> points)
        {
            this.Points = points;
        }

        public List<Point> getPoints => Points;

        List<Point> Points { get; set; }
    }
}
