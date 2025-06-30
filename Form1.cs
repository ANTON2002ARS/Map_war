using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map_war
{
    public partial class Form1 : Form
    {
        // Глобальные переменные формы
        float zoom = 1.0f; // коэффициент масштабирования
        Point mouseDownPosition; // точка нажатия мыши
        Point scrollPositionOnMouseDown; // положение скролла в момент нажатия
        public List<Map_Marker> Markers { get; set; } = new List<Map_Marker>();

        Image overlayImage;      // изображение, которое будем рисовать по клику
        public Form1()
        {
            InitializeComponent();
        }


                
        private void Span_ZNAK(object sender, MouseEventArgs e)
        {
            Image img = picture_map.Image;
            if (img == null) return;

            int pbWidth = picture_map.Width;
            int pbHeight = picture_map.Height;
            int imgWidth = img.Width;
            int imgHeight = img.Height;

            float ratioWidth = (float)pbWidth / imgWidth;
            float ratioHeight = (float)pbHeight / imgHeight;
            float ratio = Math.Min(ratioWidth, ratioHeight);

            int displayedWidth = (int)(imgWidth * ratio);
            int displayedHeight = (int)(imgHeight * ratio);

            int offsetX = (pbWidth - displayedWidth) / 2;
            int offsetY = (pbHeight - displayedHeight) / 2;

            int x = e.X - offsetX;
            int y = e.Y - offsetY;

            if (x < 0 || y < 0 || x > displayedWidth || y > displayedHeight)
                return; // Клик вне изображения

            float imageX = x / ratio;
            float imageY = y / ratio;

            // Масштаб для overlayImage
            float scale = 0.5f;
            int newWidth = (int)(overlayImage.Width * scale);
            int newHeight = (int)(overlayImage.Height * scale);

            // Смещаем, чтобы центрировать
            int drawX = (int)(imageX - newWidth / 2);
            int drawY = (int)(imageY - newHeight / 2);

            // Получаем Bitmap для рисования (убедитесь, что это Bitmap)
            Bitmap baseImage = (Bitmap)picture_map.Image;

            using (Graphics g = Graphics.FromImage(baseImage))
            {
                g.DrawImage(overlayImage, new Rectangle(drawX, drawY, newWidth, newHeight));
            }

            picture_map.Invalidate();
        }
        private Point TranslateZoomMousePosition(Point coordinates)
        {
            if (picture_map.Image == null)
                return coordinates;

            int imgWidth = picture_map.Image.Width;
            int imgHeight = picture_map.Image.Height;

            int pbWidth = picture_map.Width;
            int pbHeight = picture_map.Height;

            float imageAspect = (float)imgWidth / imgHeight;
            float controlAspect = (float)pbWidth / pbHeight;

            float scaleFactor;
            int offsetX, offsetY;

            if (imageAspect > controlAspect)
            {
                scaleFactor = (float)pbWidth / imgWidth;
                offsetX = 0;
                offsetY = (int)((pbHeight - imgHeight * scaleFactor) / 2);
            }
            else
            {
                scaleFactor = (float)pbHeight / imgHeight;
                offsetX = (int)((pbWidth - imgWidth * scaleFactor) / 2);
                offsetY = 0;
            }

            int x = (int)((coordinates.X - offsetX) / scaleFactor);
            int y = (int)((coordinates.Y - offsetY) / scaleFactor);

            return new Point(x, y);
        }

        private void Span_TEXT(object sender, MouseEventArgs e)
        {
            Point imagePoint = TranslateZoomMousePosition(e.Location);

            if (imagePoint.X < 0 || imagePoint.Y < 0 ||
                imagePoint.X >= picture_map.Image.Width || imagePoint.Y >= picture_map.Image.Height)
                return; // Клик вне изображения

            Bitmap bmp = new Bitmap(picture_map.Image);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                string text = "Ваш текст";
                Font font = new Font("Arial", 16, FontStyle.Bold);
                Brush brush = Brushes.Red;

                // Рисуем текст с верхним левым углом в точке клика по изображению
                g.DrawString(text, font, brush, imagePoint);
            }

            picture_map.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            overlayImage = Properties.Resources.знак_Т;
            panel_map.MouseWheel += panel1_MouseWheel;

        }
        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            float oldZoom = zoom;
            if (e.Delta > 0)
                zoom *= 1.1f;
            else
                zoom /= 1.1f;

            // Ограничиваем масштаб
            zoom = Math.Max(0.1f, Math.Min(zoom, 10f));

            // Получаем текущие значения прокрутки (AutoScrollPosition возвращает отрицательные значения)
            Point scrollPos = panel_map.AutoScrollPosition;

            // Пересчитываем размер PictureBox
            picture_map.Width = (int)(picture_map.Image.Width * zoom);
            picture_map.Height = (int)(picture_map.Image.Height * zoom);

            // Координаты мыши относительно панели с учётом прокрутки
            int mouseX = e.Location.X - scrollPos.X; // scrollPos.X отрицательное, поэтому минус
            int mouseY = e.Location.Y - scrollPos.Y;

            // Рассчитываем новую позицию прокрутки, чтобы курсор остался на том же месте изображения
            int newScrollX = (int)(mouseX * (zoom / oldZoom) - e.Location.X);
            int newScrollY = (int)(mouseY * (zoom / oldZoom) - e.Location.Y);

            // Устанавливаем прокрутку (передаём положительные значения)
            panel_map.AutoScrollPosition = new Point(newScrollX, newScrollY);


        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel_map.Focus();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mouseDownPosition = e.Location;
                scrollPositionOnMouseDown = panel_map.AutoScrollPosition;
            }
            else if (e.Button == MouseButtons.Left)
            {
                //Span_ZNAK(sender, e);
                Span_TEXT(sender, e);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int dx = e.Location.X - mouseDownPosition.X;
                int dy = e.Location.Y - mouseDownPosition.Y;
                panel_map.AutoScrollPosition = new Point(-(scrollPositionOnMouseDown.X + dx),-(scrollPositionOnMouseDown.Y + dy));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save_Map save_Map = new Save_Map();
            save_Map.file_save();

        }
    }
}
