using System;
using System.Drawing;
using Newtonsoft.Json;

namespace Map_war
{
    public class Map_Marker
    {
        public string ResourceName { get; set; }   // Имя ресурса
        public float Pos_X { get; set; }            // Координата X
        public float Pos_Y { get; set; }            // Координата Y

        //[NonSerialized]
       // [JsonIgnore] private Image _znak;

      /*  public Image Znak
        {
            get
            {
                if (_znak == null && !string.IsNullOrEmpty(ResourceName))
                {
                    _znak = Get_ZNAK(ResourceName);
                }
                return _znak;
            }
            set
            {
                _znak = value;
            }
        }*/

        public Image Get_ZNAK()
        {
            // Получаем изображение из ресурсов по имени
            return (Image)Properties.Resources.ResourceManager.GetObject(ResourceName);
            
        }

        /*public void RestoreImage()
        {
            _znak = Get_ZNAK(ResourceName);
        }*/

    }
}