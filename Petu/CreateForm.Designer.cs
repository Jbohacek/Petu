namespace Petu
{
    partial class CreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TNazev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CAbilityToDie = new System.Windows.Forms.CheckBox();
            this.OrignalPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Windows Command Prompt", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet Creation";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Windows Command Prompt", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(582, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.VyberObrazku);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Windows Command Prompt", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(434, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Upload);
            // 
            // TNazev
            // 
            this.TNazev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.TNazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TNazev.ForeColor = System.Drawing.SystemColors.Control;
            this.TNazev.Location = new System.Drawing.Point(33, 103);
            this.TNazev.Name = "TNazev";
            this.TNazev.Size = new System.Drawing.Size(366, 40);
            this.TNazev.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Windows Command Prompt", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateButton.Font = new System.Drawing.Font("Windows Command Prompt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CreateButton.Location = new System.Drawing.Point(33, 273);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(148, 45);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.Create);
            // 
            // CAbilityToDie
            // 
            this.CAbilityToDie.AutoSize = true;
            this.CAbilityToDie.Font = new System.Drawing.Font("Windows Command Prompt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CAbilityToDie.ForeColor = System.Drawing.SystemColors.Control;
            this.CAbilityToDie.Location = new System.Drawing.Point(53, 149);
            this.CAbilityToDie.Name = "CAbilityToDie";
            this.CAbilityToDie.Size = new System.Drawing.Size(242, 26);
            this.CAbilityToDie.TabIndex = 8;
            this.CAbilityToDie.Text = "Possibility of death";
            this.CAbilityToDie.UseVisualStyleBackColor = true;
            // 
            // OrignalPanel
            // 
            this.OrignalPanel.AutoScroll = true;
            this.OrignalPanel.BackColor = System.Drawing.Color.Gray;
            this.OrignalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrignalPanel.Location = new System.Drawing.Point(447, 54);
            this.OrignalPanel.Name = "OrignalPanel";
            this.OrignalPanel.Size = new System.Drawing.Size(243, 211);
            this.OrignalPanel.TabIndex = 9;
            this.OrignalPanel.Visible = false;
            // 
            // ShowPicture
            // 
            this.ShowPicture.BackColor = System.Drawing.Color.Silver;
            this.ShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowPicture.Location = new System.Drawing.Point(434, 9);
            this.ShowPicture.Name = "ShowPicture";
            this.ShowPicture.Size = new System.Drawing.Size(256, 256);
            this.ShowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPicture.TabIndex = 1;
            this.ShowPicture.TabStop = false;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(701, 330);
            this.Controls.Add(this.OrignalPanel);
            this.Controls.Add(this.CAbilityToDie);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNazev);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowPicture);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zavíraní);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ShowPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TNazev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.CheckBox CAbilityToDie;
        private System.Windows.Forms.FlowLayoutPanel OrignalPanel;
    }
}