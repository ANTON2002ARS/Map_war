using System;
using System.Drawing;

namespace Map_war
{
    public class Map_Marker
    {
        public string ResourceName { get; set; }   // Имя ресурса
        public float Pos_X { get; set; }       // Координата X Y
        public float Pos_Y { get; set; }       // Координата X Y

        [NonSerialized] // Не сериализуемое поле
        public Image Znak;

        public static Image Get_ZNAK(string name)
        {           
            return (Image)Properties.Resources.ResourceManager.GetObject(name);
        }

        public void RestoreImage()
        {
            Znak = Get_ZNAK(ResourceName);
        }

    }
}