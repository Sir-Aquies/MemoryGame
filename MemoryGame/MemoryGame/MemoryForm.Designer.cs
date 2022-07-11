namespace MemoryGame
{
    partial class MemoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryForm));
            this.GrayPic = new System.Windows.Forms.PictureBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.tilePanel = new System.Windows.Forms.Panel();
            this.sizeValue = new System.Windows.Forms.TextBox();
            this.movesLabel = new System.Windows.Forms.Label();
            this.movesValues = new System.Windows.Forms.Label();
            this.darkmode = new System.Windows.Forms.CheckBox();
            this.rainbowModeCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrayPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrayPic
            // 
            this.GrayPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrayPic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GrayPic.Enabled = false;
            this.GrayPic.Image = ((System.Drawing.Image)(resources.GetObject("GrayPic.Image")));
            this.GrayPic.Location = new System.Drawing.Point(12, 9);
            this.GrayPic.Name = "GrayPic";
            this.GrayPic.Size = new System.Drawing.Size(64, 67);
            this.GrayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GrayPic.TabIndex = 9;
            this.GrayPic.TabStop = false;
            this.GrayPic.Visible = false;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.Black;
            this.selectButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.selectButton.FlatAppearance.BorderSize = 20;
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.Color.White;
            this.selectButton.Location = new System.Drawing.Point(64, 281);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(142, 61);
            this.selectButton.TabIndex = 11;
            this.selectButton.Text = "Select Size";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // tilePanel
            // 
            this.tilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tilePanel.Location = new System.Drawing.Point(292, 9);
            this.tilePanel.MaximumSize = new System.Drawing.Size(780, 640);
            this.tilePanel.Name = "tilePanel";
            this.tilePanel.Padding = new System.Windows.Forms.Padding(10);
            this.tilePanel.Size = new System.Drawing.Size(780, 640);
            this.tilePanel.TabIndex = 12;
            this.tilePanel.TabStop = true;
            this.tilePanel.Visible = false;
            // 
            // sizeValue
            // 
            this.sizeValue.BackColor = System.Drawing.Color.Black;
            this.sizeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeValue.ForeColor = System.Drawing.Color.White;
            this.sizeValue.Location = new System.Drawing.Point(64, 213);
            this.sizeValue.Name = "sizeValue";
            this.sizeValue.Size = new System.Drawing.Size(142, 62);
            this.sizeValue.TabIndex = 13;
            // 
            // movesLabel
            // 
            this.movesLabel.AutoSize = true;
            this.movesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesLabel.ForeColor = System.Drawing.Color.White;
            this.movesLabel.Location = new System.Drawing.Point(14, 11);
            this.movesLabel.Name = "movesLabel";
            this.movesLabel.Size = new System.Drawing.Size(180, 52);
            this.movesLabel.TabIndex = 14;
            this.movesLabel.Text = "Moves: ";
            // 
            // movesValues
            // 
            this.movesValues.AutoSize = true;
            this.movesValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesValues.ForeColor = System.Drawing.Color.White;
            this.movesValues.Location = new System.Drawing.Point(173, 11);
            this.movesValues.Name = "movesValues";
            this.movesValues.Size = new System.Drawing.Size(47, 52);
            this.movesValues.TabIndex = 15;
            this.movesValues.Text = "0";
            // 
            // darkmode
            // 
            this.darkmode.AutoSize = true;
            this.darkmode.Checked = true;
            this.darkmode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkmode.ForeColor = System.Drawing.Color.White;
            this.darkmode.Location = new System.Drawing.Point(14, 110);
            this.darkmode.Name = "darkmode";
            this.darkmode.Size = new System.Drawing.Size(183, 41);
            this.darkmode.TabIndex = 16;
            this.darkmode.Text = "DarkMode";
            this.darkmode.UseVisualStyleBackColor = true;
            this.darkmode.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // rainbowModeCheckBox
            // 
            this.rainbowModeCheckBox.AutoSize = true;
            this.rainbowModeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainbowModeCheckBox.ForeColor = System.Drawing.Color.White;
            this.rainbowModeCheckBox.Location = new System.Drawing.Point(13, 66);
            this.rainbowModeCheckBox.Name = "rainbowModeCheckBox";
            this.rainbowModeCheckBox.Size = new System.Drawing.Size(239, 41);
            this.rainbowModeCheckBox.TabIndex = 17;
            this.rainbowModeCheckBox.Text = "RainbowMode";
            this.rainbowModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.movesValues);
            this.panel1.Controls.Add(this.darkmode);
            this.panel1.Controls.Add(this.rainbowModeCheckBox);
            this.panel1.Controls.Add(this.movesLabel);
            this.panel1.Location = new System.Drawing.Point(12, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 160);
            this.panel1.TabIndex = 18;
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tilePanel);
            this.Controls.Add(this.GrayPic);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.sizeValue);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "MemoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemoryGame";
            ((System.ComponentModel.ISupportInitialize)(this.GrayPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox GrayPic;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Panel tilePanel;
        private System.Windows.Forms.TextBox sizeValue;
        private System.Windows.Forms.Label movesLabel;
        private System.Windows.Forms.Label movesValues;
        private System.Windows.Forms.CheckBox darkmode;
        private System.Windows.Forms.CheckBox rainbowModeCheckBox;
        private System.Windows.Forms.Panel panel1;
    }
}

