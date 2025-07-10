
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.radioButton_135 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_180 = new System.Windows.Forms.RadioButton();
            this.radioButton_225 = new System.Windows.Forms.RadioButton();
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
            this.radioButton_90 = new System.Windows.Forms.RadioButton();
            this.radioButton_45 = new System.Windows.Forms.RadioButton();
            this.radioButton_0 = new System.Windows.Forms.RadioButton();
            this.radioButton_270 = new System.Windows.Forms.RadioButton();
            this.radioButton_315 = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.panel_map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_test)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(139, 32);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(130, 23);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Сохрание карты";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.button_text);
            this.groupBox3.Controls.Add(this.text_input);
            this.groupBox3.Location = new System.Drawing.Point(12, 781);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 68);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить обозначение на карту";
            // 
            // button_text
            // 
            this.button_text.Location = new System.Drawing.Point(220, 22);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(126, 29);
            this.button_text.TabIndex = 5;
            this.button_text.Text = "Добавить";
            this.button_text.UseVisualStyleBackColor = true;
            this.button_text.Click += new System.EventHandler(this.button_text_Click);
            // 
            // text_input
            // 
            this.text_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_input.Location = new System.Drawing.Point(6, 21);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(207, 29);
            this.text_input.TabIndex = 8;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(3, 32);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(130, 23);
            this.button_open.TabIndex = 6;
            this.button_open.Text = "Открыть карту";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_map_1
            // 
            this.button_map_1.Location = new System.Drawing.Point(78, 3);
            this.button_map_1.Name = "button_map_1";
            this.button_map_1.Size = new System.Drawing.Size(130, 23);
            this.button_map_1.TabIndex = 9;
            this.button_map_1.Text = "Светлов";
            this.button_map_1.UseVisualStyleBackColor = true;
            this.button_map_1.Click += new System.EventHandler(this.button12_Click);
            // 
            // button_map_3
            // 
            this.button_map_3.Location = new System.Drawing.Point(350, 3);
            this.button_map_3.Name = "button_map_3";
            this.button_map_3.Size = new System.Drawing.Size(130, 23);
            this.button_map_3.TabIndex = 8;
            this.button_map_3.Text = "Ефремов";
            this.button_map_3.UseVisualStyleBackColor = true;
            this.button_map_3.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_map_2
            // 
            this.button_map_2.Location = new System.Drawing.Point(214, 3);
            this.button_map_2.Name = "button_map_2";
            this.button_map_2.Size = new System.Drawing.Size(130, 23);
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
            this.panel_map.Controls.Add(this.picture_map);
            this.panel_map.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_map.Location = new System.Drawing.Point(185, 12);
            this.panel_map.Name = "panel_map";
            this.panel_map.Padding = new System.Windows.Forms.Padding(5);
            this.panel_map.Size = new System.Drawing.Size(987, 770);
            this.panel_map.TabIndex = 1;
            this.panel_map.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // picture_map
            // 
            this.picture_map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_map.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picture_map.Image = global::Map_war.Properties.Resources.СВЕТЛОВ;
            this.picture_map.Location = new System.Drawing.Point(0, 0);
            this.picture_map.Margin = new System.Windows.Forms.Padding(0);
            this.picture_map.Name = "picture_map";
            this.picture_map.Size = new System.Drawing.Size(5420, 5998);
            this.picture_map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_map.TabIndex = 0;
            this.picture_map.TabStop = false;
            this.picture_map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picture_map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // button_del_text
            // 
            this.button_del_text.Location = new System.Drawing.Point(0, 90);
            this.button_del_text.Margin = new System.Windows.Forms.Padding(0);
            this.button_del_text.Name = "button_del_text";
            this.button_del_text.Size = new System.Drawing.Size(133, 23);
            this.button_del_text.TabIndex = 37;
            this.button_del_text.Text = "Удалить текст";
            this.button_del_text.UseVisualStyleBackColor = true;
            // 
            // comboBox_Del_Text
            // 
            this.comboBox_Del_Text.FormattingEnabled = true;
            this.comboBox_Del_Text.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_Del_Text.Location = new System.Drawing.Point(3, 66);
            this.comboBox_Del_Text.Name = "comboBox_Del_Text";
            this.comboBox_Del_Text.Size = new System.Drawing.Size(130, 21);
            this.comboBox_Del_Text.TabIndex = 36;
            // 
            // button_del_znak
            // 
            this.button_del_znak.Location = new System.Drawing.Point(0, 40);
            this.button_del_znak.Margin = new System.Windows.Forms.Padding(0);
            this.button_del_znak.Name = "button_del_znak";
            this.button_del_znak.Size = new System.Drawing.Size(133, 23);
            this.button_del_znak.TabIndex = 35;
            this.button_del_znak.Text = "Удалить знак";
            this.button_del_znak.UseVisualStyleBackColor = true;
            // 
            // comboBox_Delete_Znak
            // 
            this.comboBox_Delete_Znak.FormattingEnabled = true;
            this.comboBox_Delete_Znak.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_Delete_Znak.Location = new System.Drawing.Point(3, 16);
            this.comboBox_Delete_Znak.Name = "comboBox_Delete_Znak";
            this.comboBox_Delete_Znak.Size = new System.Drawing.Size(130, 21);
            this.comboBox_Delete_Znak.TabIndex = 9;
            // 
            // radioButton_135
            // 
            this.radioButton_135.AutoSize = true;
            this.radioButton_135.Location = new System.Drawing.Point(3, 85);
            this.radioButton_135.Name = "radioButton_135";
            this.radioButton_135.Size = new System.Drawing.Size(92, 17);
            this.radioButton_135.TabIndex = 15;
            this.radioButton_135.Text = "135 градусов";
            this.radioButton_135.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Свойства знака";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_0);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_45);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_90);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_135);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_180);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_225);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_270);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_315);
            this.flowLayoutPanel1.Controls.Add(this.picture_test);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 183);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(167, 340);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // radioButton_180
            // 
            this.radioButton_180.AutoSize = true;
            this.radioButton_180.Location = new System.Drawing.Point(3, 108);
            this.radioButton_180.Name = "radioButton_180";
            this.radioButton_180.Size = new System.Drawing.Size(92, 17);
            this.radioButton_180.TabIndex = 17;
            this.radioButton_180.Text = "180 градусов";
            this.radioButton_180.UseVisualStyleBackColor = true;
            // 
            // radioButton_225
            // 
            this.radioButton_225.AutoSize = true;
            this.radioButton_225.Location = new System.Drawing.Point(3, 131);
            this.radioButton_225.Name = "radioButton_225";
            this.radioButton_225.Size = new System.Drawing.Size(92, 17);
            this.radioButton_225.TabIndex = 18;
            this.radioButton_225.Text = "225 градусов";
            this.radioButton_225.UseVisualStyleBackColor = true;
            // 
            // picture_test
            // 
            this.picture_test.Location = new System.Drawing.Point(3, 200);
            this.picture_test.Name = "picture_test";
            this.picture_test.Size = new System.Drawing.Size(120, 120);
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
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(167, 79);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обозначение противника";
            // 
            // comboBox_protivnik
            // 
            this.comboBox_protivnik.FormattingEnabled = true;
            this.comboBox_protivnik.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_protivnik.Location = new System.Drawing.Point(3, 16);
            this.comboBox_protivnik.Name = "comboBox_protivnik";
            this.comboBox_protivnik.Size = new System.Drawing.Size(130, 21);
            this.comboBox_protivnik.TabIndex = 38;
            // 
            // button_set_protivnik
            // 
            this.button_set_protivnik.Location = new System.Drawing.Point(0, 40);
            this.button_set_protivnik.Margin = new System.Windows.Forms.Padding(0);
            this.button_set_protivnik.Name = "button_set_protivnik";
            this.button_set_protivnik.Size = new System.Drawing.Size(133, 23);
            this.button_set_protivnik.TabIndex = 38;
            this.button_set_protivnik.Text = "Выбрать";
            this.button_set_protivnik.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.comboBox_own);
            this.flowLayoutPanel3.Controls.Add(this.button_set_own);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 98);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(167, 79);
            this.flowLayoutPanel3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Обозначение своих";
            // 
            // comboBox_own
            // 
            this.comboBox_own.FormattingEnabled = true;
            this.comboBox_own.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_own.Location = new System.Drawing.Point(3, 16);
            this.comboBox_own.Name = "comboBox_own";
            this.comboBox_own.Size = new System.Drawing.Size(130, 21);
            this.comboBox_own.TabIndex = 38;
            // 
            // button_set_own
            // 
            this.button_set_own.Location = new System.Drawing.Point(0, 40);
            this.button_set_own.Margin = new System.Windows.Forms.Padding(0);
            this.button_set_own.Name = "button_set_own";
            this.button_set_own.Size = new System.Drawing.Size(133, 23);
            this.button_set_own.TabIndex = 38;
            this.button_set_own.Text = "Выбрать";
            this.button_set_own.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.comboBox_Delete_Znak);
            this.flowLayoutPanel4.Controls.Add(this.button_del_znak);
            this.flowLayoutPanel4.Controls.Add(this.comboBox_Del_Text);
            this.flowLayoutPanel4.Controls.Add(this.button_del_text);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 608);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(166, 157);
            this.flowLayoutPanel4.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
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
            this.flowLayoutPanel5.Location = new System.Drawing.Point(369, 788);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(551, 65);
            this.flowLayoutPanel5.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Управление";
            // 
            // radioButton_90
            // 
            this.radioButton_90.AutoSize = true;
            this.radioButton_90.Location = new System.Drawing.Point(3, 62);
            this.radioButton_90.Name = "radioButton_90";
            this.radioButton_90.Size = new System.Drawing.Size(86, 17);
            this.radioButton_90.TabIndex = 20;
            this.radioButton_90.Text = "90 градусов";
            this.radioButton_90.UseVisualStyleBackColor = true;
            // 
            // radioButton_45
            // 
            this.radioButton_45.AutoSize = true;
            this.radioButton_45.Location = new System.Drawing.Point(3, 39);
            this.radioButton_45.Name = "radioButton_45";
            this.radioButton_45.Size = new System.Drawing.Size(86, 17);
            this.radioButton_45.TabIndex = 21;
            this.radioButton_45.Text = "45 градусов";
            this.radioButton_45.UseVisualStyleBackColor = true;
            // 
            // radioButton_0
            // 
            this.radioButton_0.AutoSize = true;
            this.radioButton_0.Checked = true;
            this.radioButton_0.Location = new System.Drawing.Point(3, 16);
            this.radioButton_0.Name = "radioButton_0";
            this.radioButton_0.Size = new System.Drawing.Size(80, 17);
            this.radioButton_0.TabIndex = 22;
            this.radioButton_0.TabStop = true;
            this.radioButton_0.Text = "0 градусов";
            this.radioButton_0.UseVisualStyleBackColor = true;
            // 
            // radioButton_270
            // 
            this.radioButton_270.AutoSize = true;
            this.radioButton_270.Location = new System.Drawing.Point(3, 154);
            this.radioButton_270.Name = "radioButton_270";
            this.radioButton_270.Size = new System.Drawing.Size(92, 17);
            this.radioButton_270.TabIndex = 23;
            this.radioButton_270.Text = "270 градусов";
            this.radioButton_270.UseVisualStyleBackColor = true;
            // 
            // radioButton_315
            // 
            this.radioButton_315.AutoSize = true;
            this.radioButton_315.Location = new System.Drawing.Point(3, 177);
            this.radioButton_315.Name = "radioButton_315";
            this.radioButton_315.Size = new System.Drawing.Size(92, 17);
            this.radioButton_315.TabIndex = 24;
            this.radioButton_315.Text = "315 градусов";
            this.radioButton_315.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel_map);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1000, 39);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel_map.ResumeLayout(false);
            this.panel_map.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_test)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.RadioButton radioButton_135;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton_180;
        private System.Windows.Forms.RadioButton radioButton_225;
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
        private System.Windows.Forms.RadioButton radioButton_0;
        private System.Windows.Forms.RadioButton radioButton_45;
        private System.Windows.Forms.RadioButton radioButton_90;
        private System.Windows.Forms.RadioButton radioButton_270;
        private System.Windows.Forms.RadioButton radioButton_315;
    }
}

