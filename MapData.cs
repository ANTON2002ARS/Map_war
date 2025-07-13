using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_war
{
    public class MapData
    {
        public string Map;
        public List<Map_Marker> Markers { get; set; } = new List<Map_Marker>();
        public List<Map_Text> Texts { get; set; } = new List<Map_Text>();

        public void Clear_Data()
        {
            Markers.Clear();
            Texts.Clear();
        }
        public Image Get_Map()
        {           
            if(Map == null)
            {
                Console.WriteLine("Карта равна нулю");
            }
            if(Map == "")
            {
                Console.WriteLine("Название нет");
            }
            return (Image)Properties.Resources.ResourceManager.GetObject(Map);
        }
    }
}
