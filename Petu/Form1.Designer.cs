namespace Petu
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.LNazev = new System.Windows.Forms.Label();
            this.LMoney = new System.Windows.Forms.Label();
            this.LFood = new System.Windows.Forms.Label();
            this.LWater = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Water1 = new System.Windows.Forms.PictureBox();
            this.Water2 = new System.Windows.Forms.PictureBox();
            this.Water3 = new System.Windows.Forms.PictureBox();
            this.Water4 = new System.Windows.Forms.PictureBox();
            this.Water5 = new System.Windows.Forms.PictureBox();
            this.water10 = new System.Windows.Forms.PictureBox();
            this.water9 = new System.Windows.Forms.PictureBox();
            this.water8 = new System.Windows.Forms.PictureBox();
            this.water7 = new System.Windows.Forms.PictureBox();
            this.water6 = new System.Windows.Forms.PictureBox();
            this.food10 = new System.Windows.Forms.PictureBox();
            this.food9 = new System.Windows.Forms.PictureBox();
            this.food8 = new System.Windows.Forms.PictureBox();
            this.food7 = new System.Windows.Forms.PictureBox();
            this.food6 = new System.Windows.Forms.PictureBox();
            this.food5 = new System.Windows.Forms.PictureBox();
            this.food4 = new System.Windows.Forms.PictureBox();
            this.food3 = new System.Windows.Forms.PictureBox();
            this.Food2 = new System.Windows.Forms.PictureBox();
            this.Food1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(181, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Načíst";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadButton);
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(19, 338);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(724, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.ChangeProfile);
            // 
            // LNazev
            // 
            this.LNazev.AutoSize = true;
            this.LNazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LNazev.Location = new System.Drawing.Point(183, 21);
            this.LNazev.Name = "LNazev";
            this.LNazev.Size = new System.Drawing.Size(209, 55);
            this.LNazev.TabIndex = 2;
            this.LNazev.Text = "<nazev>";
            this.LNazev.Visible = false;
            // 
            // LMoney
            // 
            this.LMoney.AutoSize = true;
            this.LMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LMoney.Location = new System.Drawing.Point(519, 45);
            this.LMoney.Name = "LMoney";
            this.LMoney.Size = new System.Drawing.Size(127, 31);
            this.LMoney.TabIndex = 3;
            this.LMoney.Text = "<Money>";
            this.LMoney.Visible = false;
            // 
            // LFood
            // 
            this.LFood.AutoSize = true;
            this.LFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LFood.Location = new System.Drawing.Point(412, 119);
            this.LFood.Name = "LFood";
            this.LFood.Size = new System.Drawing.Size(54, 16);
            this.LFood.TabIndex = 4;
            this.LFood.Text = "<Food>";
            this.LFood.Visible = false;
            // 
            // LWater
            // 
            this.LWater.AutoSize = true;
            this.LWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LWater.Location = new System.Drawing.Point(412, 97);
            this.LWater.Name = "LWater";
            this.LWater.Size = new System.Drawing.Size(58, 16);
            this.LWater.TabIndex = 5;
            this.LWater.Text = "<Water>";
            this.LWater.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Water1
            // 
            this.Water1.BackColor = System.Drawing.Color.DodgerBlue;
            this.Water1.Location = new System.Drawing.Point(204, 97);
            this.Water1.Name = "Water1";
            this.Water1.Size = new System.Drawing.Size(16, 16);
            this.Water1.TabIndex = 7;
            this.Water1.TabStop = false;
            this.Water1.Visible = false;
            // 
            // Water2
            // 
            this.Water2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Water2.Location = new System.Drawing.Point(223, 97);
            this.Water2.Name = "Water2";
            this.Water2.Size = new System.Drawing.Size(16, 16);
            this.Water2.TabIndex = 8;
            this.Water2.TabStop = false;
            this.Water2.Visible = false;
            // 
            // Water3
            // 
            this.Water3.BackColor = System.Drawing.Color.DodgerBlue;
            this.Water3.Location = new System.Drawing.Point(242, 97);
            this.Water3.Name = "Water3";
            this.Water3.Size = new System.Drawing.Size(16, 16);
            this.Water3.TabIndex = 9;
            this.Water3.TabStop = false;
            this.Water3.Visible = false;
            // 
            // Water4
            // 
            this.Water4.BackColor = System.Drawing.Color.DodgerBlue;
            this.Water4.Location = new System.Drawing.Point(261, 97);
            this.Water4.Name = "Water4";
            this.Water4.Size = new System.Drawing.Size(16, 16);
            this.Water4.TabIndex = 10;
            this.Water4.TabStop = false;
            this.Water4.Visible = false;
            // 
            // Water5
            // 
            this.Water5.BackColor = System.Drawing.Color.DodgerBlue;
            this.Water5.Location = new System.Drawing.Point(280, 97);
            this.Water5.Name = "Water5";
            this.Water5.Size = new System.Drawing.Size(16, 16);
            this.Water5.TabIndex = 11;
            this.Water5.TabStop = false;
            this.Water5.Visible = false;
            // 
            // water10
            // 
            this.water10.BackColor = System.Drawing.Color.DodgerBlue;
            this.water10.Location = new System.Drawing.Point(375, 97);
            this.water10.Name = "water10";
            this.water10.Size = new System.Drawing.Size(16, 16);
            this.water10.TabIndex = 16;
            this.water10.TabStop = false;
            this.water10.Visible = false;
            // 
            // water9
            // 
            this.water9.BackColor = System.Drawing.Color.DodgerBlue;
            this.water9.Location = new System.Drawing.Point(356, 97);
            this.water9.Name = "water9";
            this.water9.Size = new System.Drawing.Size(16, 16);
            this.water9.TabIndex = 15;
            this.water9.TabStop = false;
            this.water9.Visible = false;
            // 
            // water8
            // 
            this.water8.BackColor = System.Drawing.Color.DodgerBlue;
            this.water8.Location = new System.Drawing.Point(337, 97);
            this.water8.Name = "water8";
            this.water8.Size = new System.Drawing.Size(16, 16);
            this.water8.TabIndex = 14;
            this.water8.TabStop = false;
            this.water8.Visible = false;
            // 
            // water7
            // 
            this.water7.BackColor = System.Drawing.Color.DodgerBlue;
            this.water7.Location = new System.Drawing.Point(318, 97);
            this.water7.Name = "water7";
            this.water7.Size = new System.Drawing.Size(16, 16);
            this.water7.TabIndex = 13;
            this.water7.TabStop = false;
            this.water7.Visible = false;
            // 
            // water6
            // 
            this.water6.BackColor = System.Drawing.Color.DodgerBlue;
            this.water6.Location = new System.Drawing.Point(299, 97);
            this.water6.Name = "water6";
            this.water6.Size = new System.Drawing.Size(16, 16);
            this.water6.TabIndex = 12;
            this.water6.TabStop = false;
            this.water6.Visible = false;
            // 
            // food10
            // 
            this.food10.BackColor = System.Drawing.Color.Tomato;
            this.food10.Location = new System.Drawing.Point(375, 119);
            this.food10.Name = "food10";
            this.food10.Size = new System.Drawing.Size(16, 16);
            this.food10.TabIndex = 26;
            this.food10.TabStop = false;
            this.food10.Visible = false;
            // 
            // food9
            // 
            this.food9.BackColor = System.Drawing.Color.Tomato;
            this.food9.Location = new System.Drawing.Point(356, 119);
            this.food9.Name = "food9";
            this.food9.Size = new System.Drawing.Size(16, 16);
            this.food9.TabIndex = 25;
            this.food9.TabStop = false;
            this.food9.Visible = false;
            // 
            // food8
            // 
            this.food8.BackColor = System.Drawing.Color.Tomato;
            this.food8.Location = new System.Drawing.Point(337, 119);
            this.food8.Name = "food8";
            this.food8.Size = new System.Drawing.Size(16, 16);
            this.food8.TabIndex = 24;
            this.food8.TabStop = false;
            this.food8.Visible = false;
            // 
            // food7
            // 
            this.food7.BackColor = System.Drawing.Color.Tomato;
            this.food7.Location = new System.Drawing.Point(318, 119);
            this.food7.Name = "food7";
            this.food7.Size = new System.Drawing.Size(16, 16);
            this.food7.TabIndex = 23;
            this.food7.TabStop = false;
            this.food7.Visible = false;
            // 
            // food6
            // 
            this.food6.BackColor = System.Drawing.Color.Tomato;
            this.food6.Location = new System.Drawing.Point(299, 119);
            this.food6.Name = "food6";
            this.food6.Size = new System.Drawing.Size(16, 16);
            this.food6.TabIndex = 22;
            this.food6.TabStop = false;
            this.food6.Visible = false;
            // 
            // food5
            // 
            this.food5.BackColor = System.Drawing.Color.Tomato;
            this.food5.Location = new System.Drawing.Point(280, 119);
            this.food5.Name = "food5";
            this.food5.Size = new System.Drawing.Size(16, 16);
            this.food5.TabIndex = 21;
            this.food5.TabStop = false;
            this.food5.Visible = false;
            // 
            // food4
            // 
            this.food4.BackColor = System.Drawing.Color.Tomato;
            this.food4.Location = new System.Drawing.Point(261, 119);
            this.food4.Name = "food4";
            this.food4.Size = new System.Drawing.Size(16, 16);
            this.food4.TabIndex = 20;
            this.food4.TabStop = false;
            this.food4.Visible = false;
            // 
            // food3
            // 
            this.food3.BackColor = System.Drawing.Color.Tomato;
            this.food3.Location = new System.Drawing.Point(242, 119);
            this.food3.Name = "food3";
            this.food3.Size = new System.Drawing.Size(16, 16);
            this.food3.TabIndex = 19;
            this.food3.TabStop = false;
            this.food3.Visible = false;
            // 
            // Food2
            // 
            this.Food2.BackColor = System.Drawing.Color.Tomato;
            this.Food2.Location = new System.Drawing.Point(223, 119);
            this.Food2.Name = "Food2";
            this.Food2.Size = new System.Drawing.Size(16, 16);
            this.Food2.TabIndex = 18;
            this.Food2.TabStop = false;
            this.Food2.Visible = false;
            // 
            // Food1
            // 
            this.Food1.BackColor = System.Drawing.Color.Tomato;
            this.Food1.Location = new System.Drawing.Point(204, 119);
            this.Food1.Name = "Food1";
            this.Food1.Size = new System.Drawing.Size(16, 16);
            this.Food1.TabIndex = 17;
            this.Food1.TabStop = false;
            this.Food1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(484, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // SelectButton
            // 
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectButton.Location = new System.Drawing.Point(441, 190);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 29);
            this.SelectButton.TabIndex = 28;
            this.SelectButton.Text = "Vybrat";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Location = new System.Drawing.Point(525, 194);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(67, 25);
            this.DeleteButton.TabIndex = 29;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeletePet);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.food10);
            this.Controls.Add(this.food9);
            this.Controls.Add(this.food8);
            this.Controls.Add(this.food7);
            this.Controls.Add(this.food6);
            this.Controls.Add(this.food5);
            this.Controls.Add(this.food4);
            this.Controls.Add(this.food3);
            this.Controls.Add(this.Food2);
            this.Controls.Add(this.Food1);
            this.Controls.Add(this.water10);
            this.Controls.Add(this.water9);
            this.Controls.Add(this.water8);
            this.Controls.Add(this.water7);
            this.Controls.Add(this.water6);
            this.Controls.Add(this.Water5);
            this.Controls.Add(this.Water4);
            this.Controls.Add(this.Water3);
            this.Controls.Add(this.Water2);
            this.Controls.Add(this.Water1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LWater);
            this.Controls.Add(this.LFood);
            this.Controls.Add(this.LMoney);
            this.Controls.Add(this.LNazev);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LNazev;
        private System.Windows.Forms.Label LMoney;
        private System.Windows.Forms.Label LFood;
        private System.Windows.Forms.Label LWater;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Water1;
        private System.Windows.Forms.PictureBox Water2;
        private System.Windows.Forms.PictureBox Water3;
        private System.Windows.Forms.PictureBox Water4;
        private System.Windows.Forms.PictureBox Water5;
        private System.Windows.Forms.PictureBox water10;
        private System.Windows.Forms.PictureBox water9;
        private System.Windows.Forms.PictureBox water8;
        private System.Windows.Forms.PictureBox water7;
        private System.Windows.Forms.PictureBox water6;
        private System.Windows.Forms.PictureBox food10;
        private System.Windows.Forms.PictureBox food9;
        private System.Windows.Forms.PictureBox food8;
        private System.Windows.Forms.PictureBox food7;
        private System.Windows.Forms.PictureBox food6;
        private System.Windows.Forms.PictureBox food5;
        private System.Windows.Forms.PictureBox food4;
        private System.Windows.Forms.PictureBox food3;
        private System.Windows.Forms.PictureBox Food2;
        private System.Windows.Forms.PictureBox Food1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

