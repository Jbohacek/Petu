namespace Petu.Games
{
    partial class GoldQuest
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
            this.EnemyMovement = new System.Windows.Forms.Timer(this.components);
            this.NaseScore = new System.Windows.Forms.Label();
            this.PressEnterToleave = new System.Windows.Forms.Label();
            this.MoneyAdd = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // EnemyMovement
            // 
            this.EnemyMovement.Interval = 250;
            this.EnemyMovement.Tick += new System.EventHandler(this.EnemyMove);
            // 
            // NaseScore
            // 
            this.NaseScore.Font = new System.Drawing.Font("Windows Command Prompt", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaseScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NaseScore.Location = new System.Drawing.Point(370, 503);
            this.NaseScore.Name = "NaseScore";
            this.NaseScore.Size = new System.Drawing.Size(261, 56);
            this.NaseScore.TabIndex = 1;
            this.NaseScore.Text = "0";
            this.NaseScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PressEnterToleave
            // 
            this.PressEnterToleave.Font = new System.Drawing.Font("Windows Command Prompt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PressEnterToleave.ForeColor = System.Drawing.SystemColors.Control;
            this.PressEnterToleave.Location = new System.Drawing.Point(275, 319);
            this.PressEnterToleave.Name = "PressEnterToleave";
            this.PressEnterToleave.Size = new System.Drawing.Size(449, 84);
            this.PressEnterToleave.TabIndex = 7;
            this.PressEnterToleave.Text = "Press \"Enter\" to Exit";
            this.PressEnterToleave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PressEnterToleave.Visible = false;
            // 
            // MoneyAdd
            // 
            this.MoneyAdd.Font = new System.Drawing.Font("Windows Command Prompt", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoneyAdd.ForeColor = System.Drawing.Color.Gold;
            this.MoneyAdd.Location = new System.Drawing.Point(275, 242);
            this.MoneyAdd.Name = "MoneyAdd";
            this.MoneyAdd.Size = new System.Drawing.Size(449, 84);
            this.MoneyAdd.TabIndex = 6;
            this.MoneyAdd.Text = "+ 50";
            this.MoneyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoneyAdd.Visible = false;
            // 
            // GameOver
            // 
            this.GameOver.Font = new System.Drawing.Font("Windows Command Prompt", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOver.ForeColor = System.Drawing.Color.Red;
            this.GameOver.Location = new System.Drawing.Point(275, 166);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(449, 84);
            this.GameOver.TabIndex = 5;
            this.GameOver.Text = "Game Over";
            this.GameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOver.Visible = false;
            // 
            // GoldQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(999, 568);
            this.Controls.Add(this.PressEnterToleave);
            this.Controls.Add(this.MoneyAdd);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.NaseScore);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GoldQuest";
            this.Text = "GoldQuest";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer EnemyMovement;
        private System.Windows.Forms.Label NaseScore;
        private System.Windows.Forms.Label PressEnterToleave;
        private System.Windows.Forms.Label MoneyAdd;
        private System.Windows.Forms.Label GameOver;
    }
}