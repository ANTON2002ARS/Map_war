
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
            this.group_menu = new System.Windows.Forms.GroupBox();
            this.button_map_1 = new System.Windows.Forms.Button();
            this.button_map_3 = new System.Windows.Forms.Button();
            this.button_map_2 = new System.Windows.Forms.Button();
            this.comboBox_Delete = new System.Windows.Forms.ComboBox();
            this.picture_map = new System.Windows.Forms.PictureBox();
            this.panel_map = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_RAEB = new System.Windows.Forms.Button();
            this.button_OU = new System.Windows.Forms.Button();
            this.button_POU = new System.Windows.Forms.Button();
            this.button_interfer = new System.Windows.Forms.Button();
            this.button_VOP = new System.Windows.Forms.Button();
            this.button_time_PVO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back_PVO = new System.Windows.Forms.Button();
            this.button_RAB = new System.Windows.Forms.Button();
            this.button_Fare = new System.Windows.Forms.Button();
            this.button_ABM = new System.Windows.Forms.Button();
            this.button_Running_transport = new System.Windows.Forms.Button();
            this.button_EZA = new System.Windows.Forms.Button();
            this.button_reach_of_aviation = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.button_Helicopters = new System.Windows.Forms.Button();
            this.button_W_Helicopters = new System.Windows.Forms.Button();
            this.button_А10А = new System.Windows.Forms.Button();
            this.button_52СМАКР = new System.Windows.Forms.Button();
            this.button_50F16 = new System.Windows.Forms.Button();
            this.button_30ALKM = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.group_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).BeginInit();
            this.panel_map.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(140, 44);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 711);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 73);
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
            this.button_open.Location = new System.Drawing.Point(4, 45);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(130, 23);
            this.button_open.TabIndex = 6;
            this.button_open.Text = "Открыть карту";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // group_menu
            // 
            this.group_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.group_menu.Controls.Add(this.button_map_1);
            this.group_menu.Controls.Add(this.button_map_3);
            this.group_menu.Controls.Add(this.button_map_2);
            this.group_menu.Controls.Add(this.button_open);
            this.group_menu.Controls.Add(this.button_save);
            this.group_menu.Location = new System.Drawing.Point(369, 711);
            this.group_menu.Name = "group_menu";
            this.group_menu.Size = new System.Drawing.Size(603, 73);
            this.group_menu.TabIndex = 8;
            this.group_menu.TabStop = false;
            this.group_menu.Text = "Управление";
            // 
            // button_map_1
            // 
            this.button_map_1.Location = new System.Drawing.Point(276, 19);
            this.button_map_1.Name = "button_map_1";
            this.button_map_1.Size = new System.Drawing.Size(130, 23);
            this.button_map_1.TabIndex = 9;
            this.button_map_1.Text = "Светлов";
            this.button_map_1.UseVisualStyleBackColor = true;
            this.button_map_1.Click += new System.EventHandler(this.button12_Click);
            // 
            // button_map_3
            // 
            this.button_map_3.Location = new System.Drawing.Point(412, 45);
            this.button_map_3.Name = "button_map_3";
            this.button_map_3.Size = new System.Drawing.Size(130, 23);
            this.button_map_3.TabIndex = 8;
            this.button_map_3.Text = "Ефремов";
            this.button_map_3.UseVisualStyleBackColor = true;
            this.button_map_3.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_map_2
            // 
            this.button_map_2.Location = new System.Drawing.Point(276, 45);
            this.button_map_2.Name = "button_map_2";
            this.button_map_2.Size = new System.Drawing.Size(130, 23);
            this.button_map_2.TabIndex = 7;
            this.button_map_2.Text = "Октябрьский городок";
            this.button_map_2.UseVisualStyleBackColor = true;
            this.button_map_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Delete
            // 
            this.comboBox_Delete.FormattingEnabled = true;
            this.comboBox_Delete.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_Delete.Location = new System.Drawing.Point(12, 597);
            this.comboBox_Delete.Name = "comboBox_Delete";
            this.comboBox_Delete.Size = new System.Drawing.Size(130, 21);
            this.comboBox_Delete.TabIndex = 9;
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
            this.panel_map.Size = new System.Drawing.Size(686, 700);
            this.panel_map.TabIndex = 1;
            this.panel_map.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button_RAEB);
            this.panel1.Controls.Add(this.button_OU);
            this.panel1.Controls.Add(this.button_POU);
            this.panel1.Controls.Add(this.button_interfer);
            this.panel1.Controls.Add(this.button_VOP);
            this.panel1.Controls.Add(this.button_time_PVO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_back_PVO);
            this.panel1.Controls.Add(this.button_RAB);
            this.panel1.Controls.Add(this.button_Fare);
            this.panel1.Controls.Add(this.button_ABM);
            this.panel1.Controls.Add(this.button_Running_transport);
            this.panel1.Controls.Add(this.button_EZA);
            this.panel1.Controls.Add(this.button_reach_of_aviation);
            this.panel1.Controls.Add(this.button_move);
            this.panel1.Controls.Add(this.button_Helicopters);
            this.panel1.Controls.Add(this.button_W_Helicopters);
            this.panel1.Controls.Add(this.button_А10А);
            this.panel1.Controls.Add(this.button_52СМАКР);
            this.panel1.Controls.Add(this.button_50F16);
            this.panel1.Controls.Add(this.button_30ALKM);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 534);
            this.panel1.TabIndex = 10;
            // 
            // button_RAEB
            // 
            this.button_RAEB.Location = new System.Drawing.Point(7, 570);
            this.button_RAEB.Margin = new System.Windows.Forms.Padding(0);
            this.button_RAEB.Name = "button_RAEB";
            this.button_RAEB.Size = new System.Drawing.Size(133, 23);
            this.button_RAEB.TabIndex = 34;
            this.button_RAEB.Text = "РЭБ";
            this.button_RAEB.UseVisualStyleBackColor = true;
            this.button_RAEB.Click += new System.EventHandler(this.button_RAEB_Click);
            // 
            // button_OU
            // 
            this.button_OU.Location = new System.Drawing.Point(7, 541);
            this.button_OU.Margin = new System.Windows.Forms.Padding(0);
            this.button_OU.Name = "button_OU";
            this.button_OU.Size = new System.Drawing.Size(133, 23);
            this.button_OU.TabIndex = 33;
            this.button_OU.Text = "ЦОУ";
            this.button_OU.UseVisualStyleBackColor = true;
            this.button_OU.Click += new System.EventHandler(this.button_OU_Click);
            // 
            // button_POU
            // 
            this.button_POU.Location = new System.Drawing.Point(6, 512);
            this.button_POU.Margin = new System.Windows.Forms.Padding(0);
            this.button_POU.Name = "button_POU";
            this.button_POU.Size = new System.Drawing.Size(133, 23);
            this.button_POU.TabIndex = 32;
            this.button_POU.Text = "ПОУ";
            this.button_POU.UseVisualStyleBackColor = true;
            this.button_POU.Click += new System.EventHandler(this.button_POU_Click);
            // 
            // button_interfer
            // 
            this.button_interfer.Location = new System.Drawing.Point(7, 483);
            this.button_interfer.Margin = new System.Windows.Forms.Padding(0);
            this.button_interfer.Name = "button_interfer";
            this.button_interfer.Size = new System.Drawing.Size(133, 23);
            this.button_interfer.TabIndex = 31;
            this.button_interfer.Text = "Постановка помех";
            this.button_interfer.UseVisualStyleBackColor = true;
            this.button_interfer.Click += new System.EventHandler(this.button_interfer_Click);
            // 
            // button_VOP
            // 
            this.button_VOP.Location = new System.Drawing.Point(7, 454);
            this.button_VOP.Margin = new System.Windows.Forms.Padding(0);
            this.button_VOP.Name = "button_VOP";
            this.button_VOP.Size = new System.Drawing.Size(133, 23);
            this.button_VOP.TabIndex = 30;
            this.button_VOP.Text = "ВОП";
            this.button_VOP.UseVisualStyleBackColor = true;
            this.button_VOP.Click += new System.EventHandler(this.button_VOP_Click);
            // 
            // button_time_PVO
            // 
            this.button_time_PVO.Location = new System.Drawing.Point(7, 425);
            this.button_time_PVO.Margin = new System.Windows.Forms.Padding(0);
            this.button_time_PVO.Name = "button_time_PVO";
            this.button_time_PVO.Size = new System.Drawing.Size(133, 23);
            this.button_time_PVO.TabIndex = 29;
            this.button_time_PVO.Text = "поз. вр. ПВО";
            this.button_time_PVO.UseVisualStyleBackColor = true;
            this.button_time_PVO.Click += new System.EventHandler(this.button_time_PVO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Обозначение противника";
            // 
            // button_back_PVO
            // 
            this.button_back_PVO.Location = new System.Drawing.Point(7, 396);
            this.button_back_PVO.Margin = new System.Windows.Forms.Padding(0);
            this.button_back_PVO.Name = "button_back_PVO";
            this.button_back_PVO.Size = new System.Drawing.Size(133, 23);
            this.button_back_PVO.TabIndex = 27;
            this.button_back_PVO.Text = "поз. запаснаяПВО";
            this.button_back_PVO.UseVisualStyleBackColor = true;
            this.button_back_PVO.Click += new System.EventHandler(this.button_back_PVO_Click);
            // 
            // button_RAB
            // 
            this.button_RAB.Location = new System.Drawing.Point(7, 367);
            this.button_RAB.Margin = new System.Windows.Forms.Padding(0);
            this.button_RAB.Name = "button_RAB";
            this.button_RAB.Size = new System.Drawing.Size(133, 23);
            this.button_RAB.TabIndex = 26;
            this.button_RAB.Text = "ОбрРЭБ";
            this.button_RAB.UseVisualStyleBackColor = true;
            this.button_RAB.Click += new System.EventHandler(this.button_RAB_Click);
            // 
            // button_Fare
            // 
            this.button_Fare.Location = new System.Drawing.Point(7, 338);
            this.button_Fare.Margin = new System.Windows.Forms.Padding(0);
            this.button_Fare.Name = "button_Fare";
            this.button_Fare.Size = new System.Drawing.Size(133, 23);
            this.button_Fare.TabIndex = 25;
            this.button_Fare.Text = "Рубеж огня";
            this.button_Fare.UseVisualStyleBackColor = true;
            this.button_Fare.Click += new System.EventHandler(this.button_Fare_Click);
            // 
            // button_ABM
            // 
            this.button_ABM.Location = new System.Drawing.Point(7, 309);
            this.button_ABM.Margin = new System.Windows.Forms.Padding(0);
            this.button_ABM.Name = "button_ABM";
            this.button_ABM.Size = new System.Drawing.Size(133, 23);
            this.button_ABM.TabIndex = 24;
            this.button_ABM.Text = "АБМ в засаде";
            this.button_ABM.UseVisualStyleBackColor = true;
            this.button_ABM.Click += new System.EventHandler(this.button_ABM_Click);
            // 
            // button_Running_transport
            // 
            this.button_Running_transport.Location = new System.Drawing.Point(7, 280);
            this.button_Running_transport.Margin = new System.Windows.Forms.Padding(0);
            this.button_Running_transport.Name = "button_Running_transport";
            this.button_Running_transport.Size = new System.Drawing.Size(133, 23);
            this.button_Running_transport.TabIndex = 23;
            this.button_Running_transport.Text = "Кочующая БМ";
            this.button_Running_transport.UseVisualStyleBackColor = true;
            this.button_Running_transport.Click += new System.EventHandler(this.button_Running_transport_Click);
            // 
            // button_EZA
            // 
            this.button_EZA.Location = new System.Drawing.Point(7, 251);
            this.button_EZA.Margin = new System.Windows.Forms.Padding(0);
            this.button_EZA.Name = "button_EZA";
            this.button_EZA.Size = new System.Drawing.Size(133, 23);
            this.button_EZA.TabIndex = 22;
            this.button_EZA.Text = "Е3А";
            this.button_EZA.UseVisualStyleBackColor = true;
            this.button_EZA.Click += new System.EventHandler(this.button_EZA_Click);
            // 
            // button_reach_of_aviation
            // 
            this.button_reach_of_aviation.Location = new System.Drawing.Point(7, 222);
            this.button_reach_of_aviation.Margin = new System.Windows.Forms.Padding(0);
            this.button_reach_of_aviation.Name = "button_reach_of_aviation";
            this.button_reach_of_aviation.Size = new System.Drawing.Size(133, 23);
            this.button_reach_of_aviation.TabIndex = 21;
            this.button_reach_of_aviation.Text = "Досигаемость авиации";
            this.button_reach_of_aviation.UseVisualStyleBackColor = true;
            this.button_reach_of_aviation.Click += new System.EventHandler(this.button_reach_of_aviation_Click);
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(7, 135);
            this.button_move.Margin = new System.Windows.Forms.Padding(0);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(133, 23);
            this.button_move.TabIndex = 19;
            this.button_move.Text = "Баражирование";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // button_Helicopters
            // 
            this.button_Helicopters.Location = new System.Drawing.Point(7, 164);
            this.button_Helicopters.Margin = new System.Windows.Forms.Padding(0);
            this.button_Helicopters.Name = "button_Helicopters";
            this.button_Helicopters.Size = new System.Drawing.Size(133, 23);
            this.button_Helicopters.TabIndex = 20;
            this.button_Helicopters.Text = "Вертолеты";
            this.button_Helicopters.UseVisualStyleBackColor = true;
            this.button_Helicopters.Click += new System.EventHandler(this.button_Helicopters_Click);
            // 
            // button_W_Helicopters
            // 
            this.button_W_Helicopters.Location = new System.Drawing.Point(7, 193);
            this.button_W_Helicopters.Margin = new System.Windows.Forms.Padding(0);
            this.button_W_Helicopters.Name = "button_W_Helicopters";
            this.button_W_Helicopters.Size = new System.Drawing.Size(133, 23);
            this.button_W_Helicopters.TabIndex = 18;
            this.button_W_Helicopters.Text = "Голые вертолеты";
            this.button_W_Helicopters.UseVisualStyleBackColor = true;
            this.button_W_Helicopters.Click += new System.EventHandler(this.button_W_Helicopters_Click);
            // 
            // button_А10А
            // 
            this.button_А10А.Location = new System.Drawing.Point(7, 106);
            this.button_А10А.Margin = new System.Windows.Forms.Padding(0);
            this.button_А10А.Name = "button_А10А";
            this.button_А10А.Size = new System.Drawing.Size(133, 23);
            this.button_А10А.TabIndex = 17;
            this.button_А10А.Text = "А10А";
            this.button_А10А.UseVisualStyleBackColor = true;
            this.button_А10А.Click += new System.EventHandler(this.button_А10А_Click);
            // 
            // button_52СМАКР
            // 
            this.button_52СМАКР.Location = new System.Drawing.Point(7, 77);
            this.button_52СМАКР.Margin = new System.Windows.Forms.Padding(0);
            this.button_52СМАКР.Name = "button_52СМАКР";
            this.button_52СМАКР.Size = new System.Drawing.Size(133, 23);
            this.button_52СМАКР.TabIndex = 16;
            this.button_52СМАКР.Text = "52СМАКР";
            this.button_52СМАКР.UseVisualStyleBackColor = true;
            this.button_52СМАКР.Click += new System.EventHandler(this.button_52СМАКР_Click);
            // 
            // button_50F16
            // 
            this.button_50F16.Location = new System.Drawing.Point(7, 48);
            this.button_50F16.Margin = new System.Windows.Forms.Padding(0);
            this.button_50F16.Name = "button_50F16";
            this.button_50F16.Size = new System.Drawing.Size(133, 23);
            this.button_50F16.TabIndex = 15;
            this.button_50F16.Text = "50F16";
            this.button_50F16.UseVisualStyleBackColor = true;
            this.button_50F16.Click += new System.EventHandler(this.button_50F16_Click);
            // 
            // button_30ALKM
            // 
            this.button_30ALKM.Location = new System.Drawing.Point(7, 19);
            this.button_30ALKM.Margin = new System.Windows.Forms.Padding(0);
            this.button_30ALKM.Name = "button_30ALKM";
            this.button_30ALKM.Size = new System.Drawing.Size(133, 23);
            this.button_30ALKM.TabIndex = 14;
            this.button_30ALKM.Text = "30ALKM";
            this.button_30ALKM.UseVisualStyleBackColor = true;
            this.button_30ALKM.Click += new System.EventHandler(this.button_30ALKM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 791);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_Delete);
            this.Controls.Add(this.group_menu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel_map);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1000, 39);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Карта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.group_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).EndInit();
            this.panel_map.ResumeLayout(false);
            this.panel_map.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_text;
        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.GroupBox group_menu;
        private System.Windows.Forms.ComboBox comboBox_Delete;
        private System.Windows.Forms.Button button_map_3;
        private System.Windows.Forms.Button button_map_2;
        private System.Windows.Forms.Button button_map_1;
        private System.Windows.Forms.PictureBox picture_map;
        private System.Windows.Forms.Panel panel_map;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_RAEB;
        private System.Windows.Forms.Button button_OU;
        private System.Windows.Forms.Button button_POU;
        private System.Windows.Forms.Button button_interfer;
        private System.Windows.Forms.Button button_VOP;
        private System.Windows.Forms.Button button_time_PVO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back_PVO;
        private System.Windows.Forms.Button button_RAB;
        private System.Windows.Forms.Button button_Fare;
        private System.Windows.Forms.Button button_ABM;
        private System.Windows.Forms.Button button_Running_transport;
        private System.Windows.Forms.Button button_EZA;
        private System.Windows.Forms.Button button_reach_of_aviation;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.Button button_Helicopters;
        private System.Windows.Forms.Button button_W_Helicopters;
        private System.Windows.Forms.Button button_А10А;
        private System.Windows.Forms.Button button_52СМАКР;
        private System.Windows.Forms.Button button_50F16;
        private System.Windows.Forms.Button button_30ALKM;
    }
}

