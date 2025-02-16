namespace Petu
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Item1Mark = new System.Windows.Forms.Label();
            this.Item2Mark = new System.Windows.Forms.Label();
            this.Item3Mark = new System.Windows.Forms.Label();
            this.BuyExample = new System.Windows.Forms.Label();
            this.SoldExample = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResetLabelTime = new System.Windows.Forms.Label();
            this.ResetToBackToNormal = new System.Windows.Forms.Timer(this.components);
            this.LMoney = new System.Windows.Forms.Label();
            this.Imoney = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.Item3Show = new System.Windows.Forms.PictureBox();
            this.Item2Show = new System.Windows.Forms.PictureBox();
            this.Item1Show = new System.Windows.Forms.PictureBox();
            this.RarityBox1 = new System.Windows.Forms.PictureBox();
            this.RarityBox2 = new System.Windows.Forms.PictureBox();
            this.RarityBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item3Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item2Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RarityBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RarityBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RarityBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Windows Command Prompt", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(249, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop";
            // 
            // Item1Mark
            // 
            this.Item1Mark.BackColor = System.Drawing.Color.Transparent;
            this.Item1Mark.Font = new System.Drawing.Font("Windows Command Prompt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Item1Mark.ForeColor = System.Drawing.Color.ForestGreen;
            this.Item1Mark.Location = new System.Drawing.Point(146, 336);
            this.Item1Mark.Name = "Item1Mark";
            this.Item1Mark.Size = new System.Drawing.Size(128, 41);
            this.Item1Mark.TabIndex = 5;
            this.Item1Mark.Text = "200,-";
            this.Item1Mark.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Item2Mark
            // 
            this.Item2Mark.BackColor = System.Drawing.Color.Transparent;
            this.Item2Mark.Font = new System.Drawing.Font("Windows Command Prompt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Item2Mark.ForeColor = System.Drawing.Color.ForestGreen;
            this.Item2Mark.Location = new System.Drawing.Point(319, 336);
            this.Item2Mark.Name = "Item2Mark";
            this.Item2Mark.Size = new System.Drawing.Size(128, 41);
            this.Item2Mark.TabIndex = 6;
            this.Item2Mark.Text = "200,-";
            this.Item2Mark.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Item3Mark
            // 
            this.Item3Mark.BackColor = System.Drawing.Color.Transparent;
            this.Item3Mark.Font = new System.Drawing.Font("Windows Command Prompt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Item3Mark.ForeColor = System.Drawing.Color.ForestGreen;
            this.Item3Mark.Location = new System.Drawing.Point(494, 336);
            this.Item3Mark.Name = "Item3Mark";
            this.Item3Mark.Size = new System.Drawing.Size(128, 41);
            this.Item3Mark.TabIndex = 7;
            this.Item3Mark.Text = "200,-";
            this.Item3Mark.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BuyExample
            // 
            this.BuyExample.Font = new System.Drawing.Font("Windows Command Prompt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuyExample.ForeColor = System.Drawing.Color.ForestGreen;
            this.BuyExample.Location = new System.Drawing.Point(11, 36);
            this.BuyExample.Name = "BuyExample";
            this.BuyExample.Size = new System.Drawing.Size(128, 41);
            this.BuyExample.TabIndex = 8;
            this.BuyExample.Text = "200,-";
            this.BuyExample.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuyExample.Visible = false;
            // 
            // SoldExample
            // 
            this.SoldExample.Font = new System.Drawing.Font("Windows Command Prompt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SoldExample.ForeColor = System.Drawing.Color.Red;
            this.SoldExample.Location = new System.Drawing.Point(5, 86);
            this.SoldExample.Name = "SoldExample";
            this.SoldExample.Size = new System.Drawing.Size(128, 41);
            this.SoldExample.TabIndex = 9;
            this.SoldExample.Text = "SOLD";
            this.SoldExample.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SoldExample.Visible = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(326, 407);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(116, 52);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "100,-\r\nReset Store";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButtonItems);
            // 
            // ResetLabelTime
            // 
            this.ResetLabelTime.AutoSize = true;
            this.ResetLabelTime.BackColor = System.Drawing.Color.Transparent;
            this.ResetLabelTime.Font = new System.Drawing.Font("Windows Command Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetLabelTime.Location = new System.Drawing.Point(531, 94);
            this.ResetLabelTime.Name = "ResetLabelTime";
            this.ResetLabelTime.Size = new System.Drawing.Size(86, 34);
            this.ResetLabelTime.TabIndex = 11;
            this.ResetLabelTime.Text = "Resets in..\r\n0 : 0 :0";
            this.ResetLabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetToBackToNormal
            // 
            this.ResetToBackToNormal.Interval = 500;
            this.ResetToBackToNormal.Tick += new System.EventHandler(this.GetBackToBlack);
            // 
            // LMoney
            // 
            this.LMoney.AutoSize = true;
            this.LMoney.BackColor = System.Drawing.Color.Transparent;
            this.LMoney.Font = new System.Drawing.Font("Windows Command Prompt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LMoney.ForeColor = System.Drawing.Color.White;
            this.LMoney.Location = new System.Drawing.Point(691, 31);
            this.LMoney.Name = "LMoney";
            this.LMoney.Size = new System.Drawing.Size(96, 24);
            this.LMoney.TabIndex = 28;
            this.LMoney.Text = "<Money>";
            // 
            // Imoney
            // 
            this.Imoney.BackColor = System.Drawing.Color.Transparent;
            this.Imoney.Image = global::Petu.BasicImages.Money;
            this.Imoney.Location = new System.Drawing.Point(653, 27);
            this.Imoney.Name = "Imoney";
            this.Imoney.Size = new System.Drawing.Size(32, 32);
            this.Imoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imoney.TabIndex = 29;
            this.Imoney.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Image = global::Petu.BasicImages.BackArrow;
            this.BackButton.Location = new System.Drawing.Point(12, 406);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 64);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackButton.TabIndex = 4;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.ReturnToMain);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackActive);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackLeave);
            // 
            // Item3Show
            // 
            this.Item3Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(157)))), ((int)(((byte)(97)))));
            this.Item3Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Item3Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Item3Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Item3Show.Location = new System.Drawing.Point(494, 163);
            this.Item3Show.Name = "Item3Show";
            this.Item3Show.Size = new System.Drawing.Size(128, 128);
            this.Item3Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Item3Show.TabIndex = 3;
            this.Item3Show.TabStop = false;
            // 
            // Item2Show
            // 
            this.Item2Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(157)))), ((int)(((byte)(97)))));
            this.Item2Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Item2Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Item2Show.Location = new System.Drawing.Point(319, 163);
            this.Item2Show.Name = "Item2Show";
            this.Item2Show.Size = new System.Drawing.Size(128, 128);
            this.Item2Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Item2Show.TabIndex = 2;
            this.Item2Show.TabStop = false;
            // 
            // Item1Show
            // 
            this.Item1Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(157)))), ((int)(((byte)(97)))));
            this.Item1Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Item1Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Item1Show.Location = new System.Drawing.Point(146, 162);
            this.Item1Show.Name = "Item1Show";
            this.Item1Show.Size = new System.Drawing.Size(128, 128);
            this.Item1Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Item1Show.TabIndex = 1;
            this.Item1Show.TabStop = false;
            // 
            // RarityBox1
            // 
            this.RarityBox1.Location = new System.Drawing.Point(136, 153);
            this.RarityBox1.Name = "RarityBox1";
            this.RarityBox1.Size = new System.Drawing.Size(150, 150);
            this.RarityBox1.TabIndex = 12;
            this.RarityBox1.TabStop = false;
            // 
            // RarityBox2
            // 
            this.RarityBox2.Location = new System.Drawing.Point(309, 153);
            this.RarityBox2.Name = "RarityBox2";
            this.RarityBox2.Size = new System.Drawing.Size(150, 150);
            this.RarityBox2.TabIndex = 13;
            this.RarityBox2.TabStop = false;
            // 
            // RarityBox3
            // 
            this.RarityBox3.Location = new System.Drawing.Point(483, 153);
            this.RarityBox3.Name = "RarityBox3";
            this.RarityBox3.Size = new System.Drawing.Size(150, 150);
            this.RarityBox3.TabIndex = 14;
            this.RarityBox3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(310, 397);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Imoney);
            this.Controls.Add(this.LMoney);
            this.Controls.Add(this.ResetLabelTime);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SoldExample);
            this.Controls.Add(this.BuyExample);
            this.Controls.Add(this.Item3Mark);
            this.Controls.Add(this.Item2Mark);
            this.Controls.Add(this.Item1Mark);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Item3Show);
            this.Controls.Add(this.Item2Show);
            this.Controls.Add(this.Item1Show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RarityBox1);
            this.Controls.Add(this.RarityBox2);
            this.Controls.Add(this.RarityBox3);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingShop);
            this.Load += new System.EventHandler(this.ShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item3Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item2Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RarityBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RarityBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RarityBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Item1Show;
        private System.Windows.Forms.PictureBox Item2Show;
        private System.Windows.Forms.PictureBox Item3Show;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Label Item1Mark;
        private System.Windows.Forms.Label Item2Mark;
        private System.Windows.Forms.Label Item3Mark;
        private System.Windows.Forms.Label BuyExample;
        private System.Windows.Forms.Label SoldExample;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label ResetLabelTime;
        private System.Windows.Forms.Timer ResetToBackToNormal;
        private System.Windows.Forms.PictureBox RarityBox1;
        private System.Windows.Forms.PictureBox RarityBox2;
        private System.Windows.Forms.PictureBox RarityBox3;
        private System.Windows.Forms.PictureBox Imoney;
        private System.Windows.Forms.Label LMoney;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}