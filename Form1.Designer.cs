
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.picture_map = new System.Windows.Forms.PictureBox();
            this.panel_map = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).BeginInit();
            this.panel_map.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 568);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Противник";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 586);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(130, 23);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Сохрание карты";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // picture_map
            // 
            this.picture_map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_map.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picture_map.Image = global::Map_war.Properties.Resources.СВЕТЛОВ;
            this.picture_map.Location = new System.Drawing.Point(3, 19);
            this.picture_map.Margin = new System.Windows.Forms.Padding(0);
            this.picture_map.Name = "picture_map";
            this.picture_map.Size = new System.Drawing.Size(693, 700);
            this.picture_map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_map.TabIndex = 0;
            this.picture_map.TabStop = false;
            this.picture_map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picture_map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel_map
            // 
            this.panel_map.AutoScroll = true;
            this.panel_map.Controls.Add(this.picture_map);
            this.panel_map.Location = new System.Drawing.Point(158, 12);
            this.panel_map.Name = "panel_map";
            this.panel_map.Size = new System.Drawing.Size(700, 750);
            this.panel_map.TabIndex = 1;
            this.panel_map.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Location = new System.Drawing.Point(857, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 568);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Противник";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 106);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 77);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(118, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(12, 615);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(130, 23);
            this.button_open.TabIndex = 6;
            this.button_open.Text = "Открыть карту";
            this.button_open.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel_map);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_save);
            this.Name = "Form1";
            this.Text = "Карта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).EndInit();
            this.panel_map.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picture_map;
        private System.Windows.Forms.Panel panel_map;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button_open;
    }
}

