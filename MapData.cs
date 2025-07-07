using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_war
{
    public class MapData
    {
        public List<Map_Marker> Markers { get; set; } = new List<Map_Marker>();
        public List<Map_Text> Texts { get; set; } = new List<Map_Text>();

        public void Clear_Data()
        {
            Markers.Clear();
            Texts.Clear();
        }
    }
}
