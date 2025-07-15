
namespace Map_war
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_save = new System.Windows.Forms.Button();
            this.button_text = new System.Windows.Forms.Button();
            this.text_input = new System.Windows.Forms.TextBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button_map_1 = new System.Windows.Forms.Button();
            this.button_map_3 = new System.Windows.Forms.Button();
            this.button_map_2 = new System.Windows.Forms.Button();
            this.panel_map = new System.Windows.Forms.Panel();
            this.picture_map = new System.Windows.Forms.PictureBox();
            this.button_del_text = new System.Windows.Forms.Button();
            this.comboBox_Del_Text = new System.Windows.Forms.ComboBox();
            this.button_del_znak = new System.Windows.Forms.Button();
            this.comboBox_Delete_Znak = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_angle = new System.Windows.Forms.NumericUpDown();
            this.picture_test = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_protivnik = new System.Windows.Forms.ComboBox();
            this.button_set_protivnik = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_own = new System.Windows.Forms.ComboBox();
            this.button_set_own = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.DelButtonMain = new System.Windows.Forms.Button();
            this.panel_map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_test)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(436, 6);
            this.button_save.Margin = new System.Windows.Forms.Padding(6);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(418, 44);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Сохрание карты";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_text
            // 
            this.button_text.Location = new System.Drawing.Point(6, 105);
            this.button_text.Margin = new System.Windows.Forms.Padding(6);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(526, 56);
            this.button_text.TabIndex = 5;
            this.button_text.Text = "Добавить";
            this.button_text.UseVisualStyleBackColor = true;
            this.button_text.Click += new System.EventHandler(this.button_text_Click);
            // 
            // text_input
            // 
            this.text_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_input.Location = new System.Drawing.Point(6, 42);
            this.text_input.Margin = new System.Windows.Forms.Padding(6);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(522, 51);
            this.text_input.TabIndex = 8;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(6, 210);
            this.button_open.Margin = new System.Windows.Forms.Padding(6);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(418, 44);
            this.button_open.TabIndex = 6;
            this.button_open.Text = "Открыть карту";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_map_1
            // 
            this.button_map_1.Location = new System.Drawing.Point(6, 42);
            this.button_map_1.Margin = new System.Windows.Forms.Padding(6);
            this.button_map_1.Name = "button_map_1";
            this.button_map_1.Size = new System.Drawing.Size(418, 44);
            this.button_map_1.TabIndex = 9;
            this.button_map_1.Text = "Светлов";
            this.button_map_1.UseVisualStyleBackColor = true;
            this.button_map_1.Click += new System.EventHandler(this.button12_Click);
            // 
            // button_map_3
            // 
            this.button_map_3.Location = new System.Drawing.Point(6, 154);
            this.button_map_3.Margin = new System.Windows.Forms.Padding(6);
            this.button_map_3.Name = "button_map_3";
            this.button_map_3.Size = new System.Drawing.Size(418, 44);
            this.button_map_3.TabIndex = 8;
            this.button_map_3.Text = "Ефремов";
            this.button_map_3.UseVisualStyleBackColor = true;
            this.button_map_3.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_map_2
            // 
            this.button_map_2.Location = new System.Drawing.Point(6, 98);
            this.button_map_2.Margin = new System.Windows.Forms.Padding(6);
            this.button_map_2.Name = "button_map_2";
            this.button_map_2.Size = new System.Drawing.Size(418, 44);
            this.button_map_2.TabIndex = 7;
            this.button_map_2.Text = "Октябрьский городок";
            this.button_map_2.UseVisualStyleBackColor = true;
            this.button_map_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_map
            // 
            this.panel_map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_map.AutoScroll = true;
            this.panel_map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_map.Controls.Add(this.picture_map);
            this.panel_map.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_map.Location = new System.Drawing.Point(746, 23);
            this.panel_map.Margin = new System.Windows.Forms.Padding(6);
            this.panel_map.MaximumSize = new System.Drawing.Size(3998, 2306);
            this.panel_map.MinimumSize = new System.Drawing.Size(1738, 1421);
            this.panel_map.Name = "panel_map";
            this.panel_map.Padding = new System.Windows.Forms.Padding(10);
            this.panel_map.Size = new System.Drawing.Size(1750, 1421);
            this.panel_map.TabIndex = 1;
            this.panel_map.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // picture_map
            // 
            this.picture_map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_map.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picture_map.Image = global::Map_war.Properties.Resources.СВЕТЛОВ;
            this.picture_map.Location = new System.Drawing.Point(-1840, -2067);
            this.picture_map.Margin = new System.Windows.Forms.Padding(0);
            this.picture_map.Name = "picture_map";
            this.picture_map.Size = new System.Drawing.Size(5354, 5975);
            this.picture_map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_map.TabIndex = 0;
            this.picture_map.TabStop = false;
            this.picture_map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picture_map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // button_del_text
            // 
            this.button_del_text.Location = new System.Drawing.Point(0, 159);
            this.button_del_text.Margin = new System.Windows.Forms.Padding(0);
            this.button_del_text.Name = "button_del_text";
            this.button_del_text.Size = new System.Drawing.Size(266, 44);
            this.button_del_text.TabIndex = 37;
            this.button_del_text.Text = "Удалить текст";
            this.button_del_text.UseVisualStyleBackColor = true;
            this.button_del_text.Visible = false;
            this.button_del_text.Click += new System.EventHandler(this.button_del_text_Click);
            // 
            // comboBox_Del_Text
            // 
            this.comboBox_Del_Text.FormattingEnabled = true;
            this.comboBox_Del_Text.Location = new System.Drawing.Point(6, 120);
            this.comboBox_Del_Text.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Del_Text.Name = "comboBox_Del_Text";
            this.comboBox_Del_Text.Size = new System.Drawing.Size(256, 33);
            this.comboBox_Del_Text.TabIndex = 36;
            this.comboBox_Del_Text.Visible = false;
            // 
            // button_del_znak
            // 
            this.button_del_znak.Location = new System.Drawing.Point(0, 70);
            this.button_del_znak.Margin = new System.Windows.Forms.Padding(0);
            this.button_del_znak.Name = "button_del_znak";
            this.button_del_znak.Size = new System.Drawing.Size(266, 44);
            this.button_del_znak.TabIndex = 35;
            this.button_del_znak.Text = "Удалить знак";
            this.button_del_znak.UseVisualStyleBackColor = true;
            this.button_del_znak.Visible = false;
            this.button_del_znak.Click += new System.EventHandler(this.button_del_znak_Click);
            // 
            // comboBox_Delete_Znak
            // 
            this.comboBox_Delete_Znak.FormattingEnabled = true;
            this.comboBox_Delete_Znak.Location = new System.Drawing.Point(6, 31);
            this.comboBox_Delete_Znak.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Delete_Znak.Name = "comboBox_Delete_Znak";
            this.comboBox_Delete_Znak.Size = new System.Drawing.Size(256, 33);
            this.comboBox_Delete_Znak.TabIndex = 9;
            this.comboBox_Delete_Znak.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Свойства знака";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel1.Controls.Add(this.picture_test);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 352);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 414);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label7);
            this.flowLayoutPanel7.Controls.Add(this.numericUpDown_angle);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(16, 53);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel7.Size = new System.Drawing.Size(326, 58);
            this.flowLayoutPanel7.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 26);
            this.label7.TabIndex = 44;
            this.label7.Text = "Угол наклона";
            // 
            // numericUpDown_angle
            // 
            this.numericUpDown_angle.Location = new System.Drawing.Point(173, 12);
            this.numericUpDown_angle.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDown_angle.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numericUpDown_angle.Name = "numericUpDown_angle";
            this.numericUpDown_angle.Size = new System.Drawing.Size(116, 31);
            this.numericUpDown_angle.TabIndex = 43;
            this.numericUpDown_angle.ValueChanged += new System.EventHandler(this.numericUpDown_angle_ValueChanged);
            // 
            // picture_test
            // 
            this.picture_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_test.Location = new System.Drawing.Point(16, 123);
            this.picture_test.Margin = new System.Windows.Forms.Padding(6);
            this.picture_test.Name = "picture_test";
            this.picture_test.Size = new System.Drawing.Size(238, 229);
            this.picture_test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_test.TabIndex = 12;
            this.picture_test.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.comboBox_protivnik);
            this.flowLayoutPanel2.Controls.Add(this.button_set_protivnik);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 25);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(700, 150);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обозначение противника";
            // 
            // comboBox_protivnik
            // 
            this.comboBox_protivnik.FormattingEnabled = true;
            this.comboBox_protivnik.Items.AddRange(new object[] {
            ""});
            this.comboBox_protivnik.Location = new System.Drawing.Point(6, 31);
            this.comboBox_protivnik.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_protivnik.Name = "comboBox_protivnik";
            this.comboBox_protivnik.Size = new System.Drawing.Size(680, 33);
            this.comboBox_protivnik.TabIndex = 38;
            this.comboBox_protivnik.SelectedIndexChanged += new System.EventHandler(this.comboBox_protivnik_SelectedIndexChanged);
            // 
            // button_set_protivnik
            // 
            this.button_set_protivnik.Location = new System.Drawing.Point(0, 70);
            this.button_set_protivnik.Margin = new System.Windows.Forms.Padding(0);
            this.button_set_protivnik.Name = "button_set_protivnik";
            this.button_set_protivnik.Size = new System.Drawing.Size(690, 44);
            this.button_set_protivnik.TabIndex = 38;
            this.button_set_protivnik.Text = "Выбрать";
            this.button_set_protivnik.UseVisualStyleBackColor = true;
            this.button_set_protivnik.Click += new System.EventHandler(this.button_set_protivnik_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.comboBox_own);
            this.flowLayoutPanel3.Controls.Add(this.button_set_own);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(24, 188);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(700, 150);
            this.flowLayoutPanel3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Обозначение своих";
            // 
            // comboBox_own
            // 
            this.comboBox_own.FormattingEnabled = true;
            this.comboBox_own.Location = new System.Drawing.Point(6, 31);
            this.comboBox_own.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_own.Name = "comboBox_own";
            this.comboBox_own.Size = new System.Drawing.Size(680, 33);
            this.comboBox_own.TabIndex = 38;
            this.comboBox_own.SelectedIndexChanged += new System.EventHandler(this.comboBox_protivnik_SelectedIndexChanged);
            // 
            // button_set_own
            // 
            this.button_set_own.Location = new System.Drawing.Point(0, 70);
            this.button_set_own.Margin = new System.Windows.Forms.Padding(0);
            this.button_set_own.Name = "button_set_own";
            this.button_set_own.Size = new System.Drawing.Size(690, 44);
            this.button_set_own.TabIndex = 38;
            this.button_set_own.Text = "Выбрать";
            this.button_set_own.UseVisualStyleBackColor = true;
            this.button_set_own.Click += new System.EventHandler(this.button_set_own_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.comboBox_Delete_Znak);
            this.flowLayoutPanel4.Controls.Add(this.button_del_znak);
            this.flowLayoutPanel4.Controls.Add(this.comboBox_Del_Text);
            this.flowLayoutPanel4.Controls.Add(this.button_del_text);
            this.flowLayoutPanel4.Controls.Add(this.DelButtonMain);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(368, 354);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(356, 412);
            this.flowLayoutPanel4.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Удаление с карты";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.button_map_1);
            this.flowLayoutPanel5.Controls.Add(this.button_map_2);
            this.flowLayoutPanel5.Controls.Add(this.button_map_3);
            this.flowLayoutPanel5.Controls.Add(this.button_open);
            this.flowLayoutPanel5.Controls.Add(this.button_save);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(22, 987);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(460, 315);
            this.flowLayoutPanel5.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 36);
            this.label5.TabIndex = 38;
            this.label5.Text = "Управление";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel6.Controls.Add(this.label6);
            this.flowLayoutPanel6.Controls.Add(this.text_input);
            this.flowLayoutPanel6.Controls.Add(this.button_text);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(22, 779);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(702, 194);
            this.flowLayoutPanel6.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(511, 36);
            this.label6.TabIndex = 43;
            this.label6.Text = "Добавить обозначение на карту";
            // 
            // DelButtonMain
            // 
            this.DelButtonMain.Location = new System.Drawing.Point(3, 206);
            this.DelButtonMain.Name = "DelButtonMain";
            this.DelButtonMain.Size = new System.Drawing.Size(263, 80);
            this.DelButtonMain.TabIndex = 38;
            this.DelButtonMain.Text = "Удалить";
            this.DelButtonMain.UseVisualStyleBackColor = true;
            this.DelButtonMain.Click += new System.EventHandler(this.DelButtonMain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2532, 1467);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.panel_map);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(3814, 2011);
            this.MinimumSize = new System.Drawing.Size(2534, 1473);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Карта тактической задачи";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_map.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_test)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_text;
        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Button button_map_3;
        private System.Windows.Forms.Button button_map_2;
        private System.Windows.Forms.Button button_map_1;
        private System.Windows.Forms.PictureBox picture_map;
        private System.Windows.Forms.Panel panel_map;
        private System.Windows.Forms.Button button_del_text;
        private System.Windows.Forms.ComboBox comboBox_Del_Text;
        private System.Windows.Forms.Button button_del_znak;
        private System.Windows.Forms.ComboBox comboBox_Delete_Znak;
        private System.Windows.Forms.PictureBox picture_test;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_protivnik;
        private System.Windows.Forms.Button button_set_protivnik;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_own;
        private System.Windows.Forms.Button button_set_own;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_angle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button DelButtonMain;
    }
}

