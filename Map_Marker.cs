using System.Drawing;

namespace Map_war
{
    public class Map_Marker
    {
        public Image Znak { get; set; }     // Название обозначение
        public string Text_map {get; set; }       // Текст обозначение
        public Point Position { get; set; }       // Координата X Y
          
        public static Image Get_ZNAK(string name)
        {           
            return (Image)Properties.Resources.ResourceManager.GetObject(name);
        }
        
    }
}