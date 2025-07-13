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
        private string use_map;
        private bool use_text;
        private string str_set;
        // Глобальные переменные формы
        float zoom = 0.5f; // коэффициент масштабирования
        Point mouseDownPosition; // точка нажатия мыши
        Point scrollPositionOnMouseDown; // положение скролла в момент нажатия
        private MapData currentMapData = new MapData();
        // выбраное изображение
        private string ResourceName;
        private string name_znak;
        Image overlayImage;      // изображение, которое будем рисовать по клику        
        

        public Form1()
        {
            InitializeComponent();
            panel_map.AutoScroll = false;
            this.DoubleBuffered = true;
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
            marker.Name_Znak = name_znak;
            currentMapData.Markers.Add(marker);
            if (marker.Name_Znak == null) return;
            comboBox_Delete_Znak.Items.Add(marker.Name_Znak);
            /*overlayImage = null;
            this.ResourceName = null;*/
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
            comboBox_Del_Text.Items.Add(str_set);

            //str_set = text_input.Text = "";
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
            currentMapData.Map = "октябрьской_городок";
            picture_map.Image = currentMapData.Get_Map();
            //overlayImage = Properties.Resources.знак_Т;
            panel_map.MouseWheel += panel1_MouseWheel;
            Add_Dictionary();
        }

        private void Add_Dictionary()
        {
            comboBox_protivnik.Items.Clear();
            foreach (var key in Save_Map.name_znak_protivnik.Keys)
            {
                comboBox_protivnik.Items.Add(key);
            }
            comboBox_own.Items.Clear();
            foreach (var key in Save_Map.name_znak_own.Keys)
            {
                comboBox_own.Items.Add(key);
            }

        }
        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            float oldZoom = zoom;
            if (e.Delta > 0)
                zoom *= 1.1f;
            else
                zoom /= 1.1f;

            // Ограничиваем масштаб
            zoom = Math.Max(0.1f, Math.Min(zoom, 2));

            // Получаем текущие значения прокрутки (AutoScrollPosition возвращает отрицательные значения)
            Point scrollPos = panel_map.AutoScrollPosition;

            // Пересчитываем размер PictureBox
            picture_map.Width = (int)(picture_map.Image.Width * zoom);
            picture_map.Height = (int)(picture_map.Image.Height * zoom);

            // Координаты мыши относительно панели с учётом прокрутки
            int mouseX = e.Location.X - scrollPos.X; // scrollPos.X отрицательное, поэтому минус
            int mouseY = e.Location.Y - scrollPos.Y;

            int newScrollX = (int)((panel_map.HorizontalScroll.Value + e.X) * (zoom / oldZoom) - e.X);
            int newScrollY = (int)((panel_map.VerticalScroll.Value + e.Y) * (zoom / oldZoom) - e.Y);

            // Плавное перемещение к новой позиции
            panel_map.AutoScrollPosition = new Point(
                Math.Max(0, Math.Min(newScrollX, panel_map.HorizontalScroll.Maximum)),
                Math.Max(0, Math.Min(newScrollY, panel_map.VerticalScroll.Maximum))
            );
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
                if(use_text == true)
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
            use_text = true;
            picture_test.Image = null;
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
                    picture_map.Image = currentMapData.Get_Map();
                    if(picture_map.Image == null)
                    {
                        MessageBox.Show("Нет доступной карты!");
                        return;
                    }
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            overlayImage = Properties.Resources.знак_верт;
            this.ResourceName = "знак_верт";
        }
        
        // выбор знака
        private void button_set_protivnik_Click(object sender, EventArgs e)
        {
            button_set_protivnik.BackColor = Color.Blue;
            button_set_own.BackColor = Color.White;
            string selected = comboBox_protivnik.SelectedItem?.ToString();
            if (selected == null) return;
            name_znak = selected;
            Selected_Znak(Save_Map.name_znak_protivnik[selected]);
        }

        private void button_set_own_Click(object sender, EventArgs e)
        {
            button_set_own.BackColor = Color.Red;
            button_set_protivnik.BackColor = Color.White;
            string selected = comboBox_own.SelectedItem?.ToString();
            if (selected == null) return;
            name_znak = selected;
            Selected_Znak(Save_Map.name_znak_own[selected]);
        }

        private void Selected_Znak(string resource_name)
        {
            if (resource_name == null) return;
            ResourceName = resource_name;
            Image image = Map_Marker.Get_Image(resource_name);
            int angle = (int)numericUpDown_angle.Value;
            overlayImage = Map_Marker.RotateImage(image, angle);
            picture_test.Image = overlayImage;
            use_text = false;
        }

        private void numericUpDown_angle_ValueChanged(object sender, EventArgs e)
        {
            Selected_Znak(ResourceName);
        }

        private void button_del_znak_Click(object sender, EventArgs e)
        {
            string selected = comboBox_Delete_Znak.SelectedItem?.ToString();
            // удаление до делать
            currentMapData.Markers.RemoveAll(znak => znak.Name_Znak == selected);
            picture_map.Image = currentMapData.Get_Map();
            UpdateMarkersUI(currentMapData.Markers);
            UpdateTextsUI(currentMapData.Texts);
        }

        private void button_del_text_Click(object sender, EventArgs e)
        {
            string selected = comboBox_Del_Text.SelectedItem?.ToString();
            currentMapData.Texts.RemoveAll(text => text.Text_map == selected);
            UpdateMarkersUI(currentMapData.Markers);
            UpdateTextsUI(currentMapData.Texts);
        }

        private void comboBox_protivnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_set_protivnik.BackColor = Color.White;
            button_set_own.BackColor = Color.White;
        }
    }
}
