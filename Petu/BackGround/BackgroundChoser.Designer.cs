namespace Petu.BackGround
{
    partial class BackgroundChoser
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
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.PanelChoserBig = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Image = global::Petu.BasicImages.BackArrow;
            this.BackButton.Location = new System.Drawing.Point(12, 575);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 64);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackButton.TabIndex = 4;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.Goback);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackEnter);
            this.BackButton.MouseHover += new System.EventHandler(this.BackLeave);
            // 
            // PanelChoserBig
            // 
            this.PanelChoserBig.AutoScroll = true;
            this.PanelChoserBig.BackColor = System.Drawing.Color.Gray;
            this.PanelChoserBig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelChoserBig.Location = new System.Drawing.Point(12, 12);
            this.PanelChoserBig.Name = "PanelChoserBig";
            this.PanelChoserBig.Size = new System.Drawing.Size(1004, 557);
            this.PanelChoserBig.TabIndex = 5;
            // 
            // BackgroundChoser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1028, 643);
            this.Controls.Add(this.PanelChoserBig);
            this.Controls.Add(this.BackButton);
            this.Name = "BackgroundChoser";
            this.Text = "BackgroundChoser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.End);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.FlowLayoutPanel PanelChoserBig;
    }
}