namespace VultronOBU
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vultronLCD1 = new VultronOBU.VultronLCD();
            this.btn_Down = new VultronOBU.VultronSpecButton();
            this.btn_Up = new VultronOBU.VultronSpecButton();
            this.vultronButton2 = new VultronOBU.VultronButton();
            this.vultronButton1 = new VultronOBU.VultronButton();
            this.btn_B = new VultronOBU.VultronButton();
            this.btn_A = new VultronOBU.VultronButton();
            this.btn_PS = new VultronOBU.VultronButton();
            this.btn_Enter = new VultronOBU.VultronSpecButton();
            this.btn_Clear = new VultronOBU.VultronSpecButton();
            this.btn_Repeat = new VultronOBU.VultronSpecButton();
            this.btn_Num0 = new VultronOBU.VultronButton();
            this.btn_Num9 = new VultronOBU.VultronButton();
            this.btn_Num8 = new VultronOBU.VultronButton();
            this.btn_Num7 = new VultronOBU.VultronButton();
            this.btn_Num6 = new VultronOBU.VultronButton();
            this.btn_Num4 = new VultronOBU.VultronButton();
            this.btn_Num5 = new VultronOBU.VultronButton();
            this.btn_Num3 = new VultronOBU.VultronButton();
            this.btn_Num2 = new VultronOBU.VultronButton();
            this.btn_Num1 = new VultronOBU.VultronButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::VultronOBU.Properties.Resources.vultron_ures;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 290);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vultronLCD1
            // 
            this.vultronLCD1.BackColor = System.Drawing.Color.Black;
            this.vultronLCD1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vultronLCD1.Font = new System.Drawing.Font("LCD Solid", 10F);
            this.vultronLCD1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.vultronLCD1.Location = new System.Drawing.Point(83, 67);
            this.vultronLCD1.Name = "vultronLCD1";
            this.vultronLCD1.ReadOnly = true;
            this.vultronLCD1.Size = new System.Drawing.Size(191, 70);
            this.vultronLCD1.TabIndex = 23;
            this.vultronLCD1.Text = "";
            // 
            // btn_Down
            // 
            this.btn_Down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(48)))));
            this.btn_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Down.Font = new System.Drawing.Font("Arial", 16F);
            this.btn_Down.ForeColor = System.Drawing.Color.White;
            this.btn_Down.Location = new System.Drawing.Point(292, 212);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(42, 42);
            this.btn_Down.TabIndex = 22;
            this.btn_Down.Text = "↓";
            this.btn_Down.UseVisualStyleBackColor = false;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(48)))));
            this.btn_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Up.Font = new System.Drawing.Font("Arial", 16F);
            this.btn_Up.ForeColor = System.Drawing.Color.White;
            this.btn_Up.Location = new System.Drawing.Point(292, 157);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(42, 42);
            this.btn_Up.TabIndex = 21;
            this.btn_Up.Text = " ↑";
            this.btn_Up.UseVisualStyleBackColor = false;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // vultronButton2
            // 
            this.vultronButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.vultronButton2.FlatAppearance.BorderSize = 0;
            this.vultronButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vultronButton2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.vultronButton2.ForeColor = System.Drawing.Color.Black;
            this.vultronButton2.Location = new System.Drawing.Point(191, 211);
            this.vultronButton2.Name = "vultronButton2";
            this.vultronButton2.Size = new System.Drawing.Size(42, 42);
            this.vultronButton2.TabIndex = 20;
            this.vultronButton2.Text = "D";
            this.vultronButton2.UseVisualStyleBackColor = false;
            // 
            // vultronButton1
            // 
            this.vultronButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.vultronButton1.FlatAppearance.BorderSize = 0;
            this.vultronButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vultronButton1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.vultronButton1.ForeColor = System.Drawing.Color.Black;
            this.vultronButton1.Location = new System.Drawing.Point(140, 211);
            this.vultronButton1.Name = "vultronButton1";
            this.vultronButton1.Size = new System.Drawing.Size(42, 42);
            this.vultronButton1.TabIndex = 19;
            this.vultronButton1.Text = "C";
            this.vultronButton1.UseVisualStyleBackColor = false;
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_B.FlatAppearance.BorderSize = 0;
            this.btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_B.ForeColor = System.Drawing.Color.Black;
            this.btn_B.Location = new System.Drawing.Point(91, 211);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(42, 42);
            this.btn_B.TabIndex = 18;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = false;
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_A.FlatAppearance.BorderSize = 0;
            this.btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_A.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_A.ForeColor = System.Drawing.Color.Black;
            this.btn_A.Location = new System.Drawing.Point(42, 211);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(42, 42);
            this.btn_A.TabIndex = 17;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = false;
            // 
            // btn_PS
            // 
            this.btn_PS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_PS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PS.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btn_PS.ForeColor = System.Drawing.Color.White;
            this.btn_PS.Location = new System.Drawing.Point(240, 211);
            this.btn_PS.Name = "btn_PS";
            this.btn_PS.Size = new System.Drawing.Size(42, 42);
            this.btn_PS.TabIndex = 16;
            this.btn_PS.Text = "P/S";
            this.btn_PS.UseVisualStyleBackColor = false;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(48)))));
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Arial", 6F);
            this.btn_Enter.ForeColor = System.Drawing.Color.White;
            this.btn_Enter.Location = new System.Drawing.Point(444, 211);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(42, 42);
            this.btn_Enter.TabIndex = 15;
            this.btn_Enter.Text = "ENTER";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Arial", 6F);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(343, 211);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(42, 42);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_Repeat
            // 
            this.btn_Repeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Repeat.Font = new System.Drawing.Font("Arial", 4.5F);
            this.btn_Repeat.ForeColor = System.Drawing.Color.White;
            this.btn_Repeat.Location = new System.Drawing.Point(42, 157);
            this.btn_Repeat.Name = "btn_Repeat";
            this.btn_Repeat.Size = new System.Drawing.Size(42, 42);
            this.btn_Repeat.TabIndex = 13;
            this.btn_Repeat.Text = "REPEAT";
            this.btn_Repeat.UseVisualStyleBackColor = false;
            // 
            // btn_Num0
            // 
            this.btn_Num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num0.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Num0.ForeColor = System.Drawing.Color.White;
            this.btn_Num0.Location = new System.Drawing.Point(395, 211);
            this.btn_Num0.Name = "btn_Num0";
            this.btn_Num0.Size = new System.Drawing.Size(42, 42);
            this.btn_Num0.TabIndex = 12;
            this.btn_Num0.Text = "0";
            this.btn_Num0.UseVisualStyleBackColor = false;
            // 
            // btn_Num9
            // 
            this.btn_Num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Num9.ForeColor = System.Drawing.Color.White;
            this.btn_Num9.Location = new System.Drawing.Point(444, 156);
            this.btn_Num9.Name = "btn_Num9";
            this.btn_Num9.Size = new System.Drawing.Size(42, 42);
            this.btn_Num9.TabIndex = 11;
            this.btn_Num9.Text = "9";
            this.btn_Num9.UseVisualStyleBackColor = false;
            // 
            // btn_Num8
            // 
            this.btn_Num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Num8.ForeColor = System.Drawing.Color.White;
            this.btn_Num8.Location = new System.Drawing.Point(394, 156);
            this.btn_Num8.Name = "btn_Num8";
            this.btn_Num8.Size = new System.Drawing.Size(42, 42);
            this.btn_Num8.TabIndex = 10;
            this.btn_Num8.Text = "8";
            this.btn_Num8.UseVisualStyleBackColor = false;
            // 
            // btn_Num7
            // 
            this.btn_Num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Num7.ForeColor = System.Drawing.Color.White;
            this.btn_Num7.Location = new System.Drawing.Point(343, 156);
            this.btn_Num7.Name = "btn_Num7";
            this.btn_Num7.Size = new System.Drawing.Size(42, 42);
            this.btn_Num7.TabIndex = 9;
            this.btn_Num7.Text = "7";
            this.btn_Num7.UseVisualStyleBackColor = false;
            // 
            // btn_Num6
            // 
            this.btn_Num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Num6.ForeColor = System.Drawing.Color.White;
            this.btn_Num6.Location = new System.Drawing.Point(444, 101);
            this.btn_Num6.Name = "btn_Num6";
            this.btn_Num6.Size = new System.Drawing.Size(42, 42);
            this.btn_Num6.TabIndex = 8;
            this.btn_Num6.Text = "6";
            this.btn_Num6.UseVisualStyleBackColor = false;
            // 
            // btn_Num4
            // 
            this.btn_Num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Num4.ForeColor = System.Drawing.Color.White;
            this.btn_Num4.Location = new System.Drawing.Point(343, 101);
            this.btn_Num4.Name = "btn_Num4";
            this.btn_Num4.Size = new System.Drawing.Size(42, 42);
            this.btn_Num4.TabIndex = 7;
            this.btn_Num4.Text = "4";
            this.btn_Num4.UseVisualStyleBackColor = false;
            // 
            // btn_Num5
            // 
            this.btn_Num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Num5.ForeColor = System.Drawing.Color.White;
            this.btn_Num5.Location = new System.Drawing.Point(394, 101);
            this.btn_Num5.Name = "btn_Num5";
            this.btn_Num5.Size = new System.Drawing.Size(42, 42);
            this.btn_Num5.TabIndex = 6;
            this.btn_Num5.Text = "5";
            this.btn_Num5.UseVisualStyleBackColor = false;
            // 
            // btn_Num3
            // 
            this.btn_Num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Num3.ForeColor = System.Drawing.Color.White;
            this.btn_Num3.Location = new System.Drawing.Point(444, 46);
            this.btn_Num3.Name = "btn_Num3";
            this.btn_Num3.Size = new System.Drawing.Size(42, 42);
            this.btn_Num3.TabIndex = 5;
            this.btn_Num3.Text = "3";
            this.btn_Num3.UseVisualStyleBackColor = false;
            // 
            // btn_Num2
            // 
            this.btn_Num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Num2.ForeColor = System.Drawing.Color.White;
            this.btn_Num2.Location = new System.Drawing.Point(393, 46);
            this.btn_Num2.Name = "btn_Num2";
            this.btn_Num2.Size = new System.Drawing.Size(42, 42);
            this.btn_Num2.TabIndex = 4;
            this.btn_Num2.Text = "2";
            this.btn_Num2.UseVisualStyleBackColor = false;
            // 
            // btn_Num1
            // 
            this.btn_Num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Num1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Num1.ForeColor = System.Drawing.Color.White;
            this.btn_Num1.Location = new System.Drawing.Point(343, 46);
            this.btn_Num1.Name = "btn_Num1";
            this.btn_Num1.Size = new System.Drawing.Size(42, 42);
            this.btn_Num1.TabIndex = 1;
            this.btn_Num1.Text = "1";
            this.btn_Num1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 290);
            this.Controls.Add(this.vultronLCD1);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.vultronButton2);
            this.Controls.Add(this.vultronButton1);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.btn_PS);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Repeat);
            this.Controls.Add(this.btn_Num0);
            this.Controls.Add(this.btn_Num9);
            this.Controls.Add(this.btn_Num8);
            this.Controls.Add(this.btn_Num7);
            this.Controls.Add(this.btn_Num6);
            this.Controls.Add(this.btn_Num4);
            this.Controls.Add(this.btn_Num5);
            this.Controls.Add(this.btn_Num3);
            this.Controls.Add(this.btn_Num2);
            this.Controls.Add(this.btn_Num1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(554, 329);
            this.MinimumSize = new System.Drawing.Size(554, 329);
            this.Name = "Form1";
            this.Text = "Vultron vezérlő";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private VultronButton btn_Num1;
        private VultronButton btn_Num2;
        private VultronButton btn_Num3;
        private VultronButton btn_Num5;
        private VultronButton btn_Num4;
        private VultronButton btn_Num6;
        private VultronButton btn_Num7;
        private VultronButton btn_Num8;
        private VultronButton btn_Num9;
        private VultronButton btn_Num0;
        private VultronSpecButton btn_Repeat;
        private VultronSpecButton btn_Clear;
        private VultronSpecButton btn_Enter;
        private VultronButton btn_PS;
        private VultronButton btn_A;
        private VultronButton btn_B;
        private VultronButton vultronButton1;
        private VultronButton vultronButton2;
        private VultronSpecButton btn_Up;
        private VultronSpecButton btn_Down;
        private VultronLCD vultronLCD1;
        private System.Windows.Forms.Timer timer1;
    }
}

