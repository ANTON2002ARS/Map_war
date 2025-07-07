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
        private string str_set;
        // Глобальные переменные формы
        float zoom = 0.5f; // коэффициент масштабирования
        Point mouseDownPosition; // точка нажатия мыши
        Point scrollPositionOnMouseDown; // положение скролла в момент нажатия
        private MapData currentMapData = new MapData();

        Image overlayImage;      // изображение, которое будем рисовать по клику
        string ResourceName;    // название изображение из ресурсов

        public Form1()
        {
            InitializeComponent();
        }

        // символ на карту        
        private void Span_ZNAK(object sender, MouseEventArgs e)
        {
            Image img = picture_map.Image;
            if (img == null) return;
            if (overlayImage == null) return;

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

            Draw_Image(imageX, imageY, overlayImage);
            Map_Marker marker = new Map_Marker();            
            marker.Pos_X = imageX;
            marker.Pos_Y = imageY;
            marker.ResourceName = this.ResourceName;
            currentMapData.Markers.Add(marker);
            overlayImage = null;
            this.ResourceName = null;
            Console.WriteLine("Установка знака:" + marker.Pos_X + " " + marker.Pos_Y);
        }

        private void UpdateMarkersUI(List<Map_Marker> markers)
        {
            // Обновите элементы управления, которые отображают маркеры
            foreach (var marker in currentMapData.Markers)
            {
                Draw_Image(marker.Pos_X, marker.Pos_Y, marker.Get_ZNAK());
            }
        }

        private void UpdateTextsUI(List<Map_Text> texts)
        {
            // Обновите элементы управления, которые отображают тексты
            foreach (var text in currentMapData.Texts)
            {
                Draw_Text(text.Position, text.Text_map);
            }
        }       

        private void Draw_Image(float X, float Y, Image image)
        {
            // Масштаб для overlayImage
            float scale = 0.5f;
            int newWidth = (int)(image.Width * scale);
            int newHeight = (int)(image.Height * scale);
            // Смещаем, чтобы центрировать
            int drawX = (int)(X - newWidth / 2);
            int drawY = (int)(Y - newHeight / 2);
            // Получаем Bitmap для рисования (убедитесь, что это Bitmap)
            Bitmap baseImage = (Bitmap)picture_map.Image;

            using (Graphics g = Graphics.FromImage(baseImage))
            {
                g.DrawImage(image, new Rectangle(drawX, drawY, newWidth, newHeight));
            }

            picture_map.Invalidate();
        }

        // получить координаты мышки в маштабе
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
        // поставить текст
        private void Span_TEXT(MouseEventArgs e)
        {
            if (str_set == "")
                return;            
            button_text.BackColor = Color.White;

            Point imagePoint = TranslateZoomMousePosition(e.Location);
            Draw_Text(imagePoint, str_set);

            Map_Text map_text = new Map_Text();
            map_text.Position = imagePoint;
            map_text.Text_map = str_set;    
            currentMapData.Texts.Add(map_text);

            str_set = text_input.Text = "";
        }

        private void Draw_Text(Point Point_Klick, string text)
        {
            if (Point_Klick.X < 0 || Point_Klick.Y < 0 ||
                Point_Klick.X >= picture_map.Image.Width || Point_Klick.Y >= picture_map.Image.Height)
                return; // Клик вне изображения

            Bitmap bmp = new Bitmap(picture_map.Image);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                //string text = str_set;
                Font font = new Font("Arial", 24, FontStyle.Bold);
                Brush brush = Brushes.Black;
                // Рисуем текст с верхним левым углом в точке клика по изображению
                g.DrawString(text, font, brush, Point_Klick);
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
                if(str_set != "")
                {
                    Span_TEXT(e);
                }
                else
                {
                    Span_ZNAK(sender, e);
                }                
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

        private void button_text_Click(object sender, EventArgs e)
        {
            str_set = text_input.Text;
            button_text.BackColor = Color.Green;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Map files (*.map)|*.map|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "map";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;

                    // Перед сохранением обновите currentMapData из UI, если нужно
                    // Например, currentMapData.Markers = GetMarkersFromUI();
                    // currentMapData.Texts = GetTextsFromUI();
                    Save_Map save = new Save_Map();
                    save.SaveMapDataToFile(path, currentMapData);
                    MessageBox.Show("Файл сохранён успешно.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Map files (*.map)|*.map|All files (*.*)|*.*";
                openFileDialog.DefaultExt = "map";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    Save_Map save = new Save_Map();
                    currentMapData = save.LoadMapDataFromFile(path);

                    // Обновите интерфейс, например:

                    UpdateMarkersUI(currentMapData.Markers);
                    UpdateTextsUI(currentMapData.Texts);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Переключение карты сотрет все обозначение с карты",
           "Внимание",
            MessageBoxButtons.YesNo,     // Кнопки Да и Нет
           MessageBoxIcon.Question      // Значок вопроса
           );

            if (result == DialogResult.Yes)
            {
                picture_map.Image = Properties.Resources.СВЕТЛОВ;
                currentMapData.Clear_Data();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Переключение карты сотрет все обозначение с карты",    
            "Внимание",             
            MessageBoxButtons.YesNo,     // Кнопки Да и Нет
            MessageBoxIcon.Question      // Значок вопроса
            );

            if (result == DialogResult.Yes)
            {
                picture_map.Image = Properties.Resources.октябрьской_городок;
                currentMapData.Clear_Data();
            }  
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Переключение карты сотрет все обозначение с карты",
            "Внимание",
             MessageBoxButtons.YesNo,     // Кнопки Да и Нет
            MessageBoxIcon.Question      // Значок вопроса
            );

            if (result == DialogResult.Yes)
            {
                picture_map.Image = Properties.Resources.ефремов;
                currentMapData.Clear_Data();

            }
        }        

        private void button_30ALKM_Click(object sender, EventArgs e)
        {
            overlayImage = Properties.Resources.знак_верт;
            this.ResourceName = "знак_верт";
        }

        private void button_50F16_Click(object sender, EventArgs e)
        {
            //overlayImage = Properties.Resources.знак_50F16;
        }

        private void button_52СМАКР_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_52СМАКР;
        }

        private void button_А10А_Click(object sender, EventArgs e)
        {
           //  overlayImage = Properties.Resources.знак_А10А;
        }

        private void button_move_Click(object sender, EventArgs e)
        {
            //overlayImage = Properties.Resources.знак_баражирование;
        }

        private void button_Helicopters_Click(object sender, EventArgs e)
        {
            //overlayImage = Properties.Resources.знак_вертолеты;
        }

        private void button_W_Helicopters_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_голые_вертолет;
        }

        private void button_reach_of_aviation_Click(object sender, EventArgs e)
        {
            //overlayImage = Properties.Resources.знак_досигаемостьавиации;
        }

        private void button_EZA_Click(object sender, EventArgs e)
        {
            //overlayImage = Properties.Resources.знак_Е3А;
        }

        private void button_Running_transport_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_курсированиетранспорта;
        }

        private void button_ABM_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_Е3А;
        }

        private void button_Fare_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_направлениедвижениекружочковПВО;
        }

        private void button_RAB_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_обрРЭБ;
        }

        private void button_back_PVO_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_ПВО2;
        }

        private void button_time_PVO_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_обркп_тпу;
        }

        private void button_VOP_Click(object sender, EventArgs e)
        {
          //  overlayImage = Properties.Resources.знак_полувертолеты;
        }

        private void button_interfer_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_РЭБ;
        }

        private void button_POU_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_обркп_тпу;
        }

        private void button_OU_Click(object sender, EventArgs e)
        {
           // overlayImage = Properties.Resources.знак_РЛСквадрат;
        }

        private void button_RAEB_Click(object sender, EventArgs e)
        {
          //  overlayImage = Properties.Resources.знак_РЭБ;
        }
    }
}
