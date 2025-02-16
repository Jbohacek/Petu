namespace Petu.Games
{
    partial class SheepHunt
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.Label();
            this.MoneyAdd = new System.Windows.Forms.Label();
            this.PressEnterToleave = new System.Windows.Forms.Label();
            this.ScoreLower = new System.Windows.Forms.Timer(this.components);
            this.AdderLabel = new System.Windows.Forms.Label();
            this.TimeToshotAgin = new System.Windows.Forms.Timer(this.components);
            this.LabelTimeToShot = new System.Windows.Forms.Label();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1067, 682);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Windows Command Prompt", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(367, 687);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "<Score>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameOver
            // 
            this.GameOver.Font = new System.Drawing.Font("Windows Command Prompt", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOver.ForeColor = System.Drawing.Color.Red;
            this.GameOver.Location = new System.Drawing.Point(311, 301);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(449, 84);
            this.GameOver.TabIndex = 2;
            this.GameOver.Text = "Game Over";
            this.GameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOver.Visible = false;
            // 
            // MoneyAdd
            // 
            this.MoneyAdd.Font = new System.Drawing.Font("Windows Command Prompt", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoneyAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MoneyAdd.Location = new System.Drawing.Point(311, 377);
            this.MoneyAdd.Name = "MoneyAdd";
            this.MoneyAdd.Size = new System.Drawing.Size(449, 84);
            this.MoneyAdd.TabIndex = 3;
            this.MoneyAdd.Text = "+ 50";
            this.MoneyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoneyAdd.Visible = false;
            // 
            // PressEnterToleave
            // 
            this.PressEnterToleave.Font = new System.Drawing.Font("Windows Command Prompt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PressEnterToleave.ForeColor = System.Drawing.SystemColors.Control;
            this.PressEnterToleave.Location = new System.Drawing.Point(311, 454);
            this.PressEnterToleave.Name = "PressEnterToleave";
            this.PressEnterToleave.Size = new System.Drawing.Size(449, 84);
            this.PressEnterToleave.TabIndex = 4;
            this.PressEnterToleave.Text = "Press \"Enter\" to Exit";
            this.PressEnterToleave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PressEnterToleave.Visible = false;
            // 
            // ScoreLower
            // 
            this.ScoreLower.Enabled = true;
            this.ScoreLower.Interval = 400;
            this.ScoreLower.Tick += new System.EventHandler(this.LowerScore);
            // 
            // AdderLabel
            // 
            this.AdderLabel.Font = new System.Drawing.Font("Windows Command Prompt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdderLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.AdderLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AdderLabel.Location = new System.Drawing.Point(381, 754);
            this.AdderLabel.Name = "AdderLabel";
            this.AdderLabel.Size = new System.Drawing.Size(293, 32);
            this.AdderLabel.TabIndex = 5;
            this.AdderLabel.Text = "<Score>";
            this.AdderLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TimeToshotAgin
            // 
            this.TimeToshotAgin.Interval = 10000;
            this.TimeToshotAgin.Tick += new System.EventHandler(this.ShowTimer);
            // 
            // LabelTimeToShot
            // 
            this.LabelTimeToShot.Font = new System.Drawing.Font("Windows Command Prompt", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTimeToShot.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTimeToShot.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LabelTimeToShot.Location = new System.Drawing.Point(818, 724);
            this.LabelTimeToShot.Name = "LabelTimeToShot";
            this.LabelTimeToShot.Size = new System.Drawing.Size(230, 54);
            this.LabelTimeToShot.TabIndex = 6;
            this.LabelTimeToShot.Text = "<Timer>";
            this.LabelTimeToShot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelTimeToShot.Visible = false;
            // 
            // Frame
            // 
            this.Frame.Interval = 1000;
            this.Frame.Tick += new System.EventHandler(this.FrameTick);
            // 
            // SheepHunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1070, 787);
            this.Controls.Add(this.LabelTimeToShot);
            this.Controls.Add(this.AdderLabel);
            this.Controls.Add(this.PressEnterToleave);
            this.Controls.Add(this.MoneyAdd);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SheepHunt";
            this.Text = "Gold Hunt";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPlay);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.Label MoneyAdd;
        private System.Windows.Forms.Label PressEnterToleave;
        private System.Windows.Forms.Timer ScoreLower;
        private System.Windows.Forms.Label AdderLabel;
        private System.Windows.Forms.Timer TimeToshotAgin;
        private System.Windows.Forms.Label LabelTimeToShot;
        private System.Windows.Forms.Timer Frame;
    }
}