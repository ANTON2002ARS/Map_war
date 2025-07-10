using System;
using System.Drawing;
using Newtonsoft.Json;

namespace Map_war
{
    public class Map_Marker
    {
        public string Resource_Map;
        public string ResourceName { get; set; }   // Имя ресурса
        public float Pos_X { get; set; }            // Координата X
        public float Pos_Y { get; set; }            // Координата Y        

        public Image Get_ZNAK()
        {
            // Получаем изображение из ресурсов по имени
            return (Image)Properties.Resources.ResourceManager.GetObject(ResourceName);
            
        }

        public Image Get_Map()
        {
            return (Image)Properties.Resources.ResourceManager.GetObject(Resource_Map);
        }

        public static Image RotateImage(Image img, float angle)
        {
            if (img == null) return null;

            // Создаём новый пустой Bitmap с увеличенным размером, чтобы уместить повернутое изображение
            Bitmap rotatedBmp = new Bitmap(img.Width, img.Height);
            rotatedBmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                // Перемещаем начало координат в центр изображения
                g.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
                // Поворачиваем
                g.RotateTransform(angle);
                // Возвращаем начало координат обратно
                g.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
                // Рисуем исходное изображение
                g.DrawImage(img, new Point(0, 0));
            }
            return rotatedBmp;
        }

    }
}