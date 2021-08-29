
namespace ColdWarScript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.weaponCombo = new System.Windows.Forms.ComboBox();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.smoothSlider = new System.Windows.Forms.TrackBar();
            this.smoothLabel = new System.Windows.Forms.Label();
            this.smoothValue = new System.Windows.Forms.Label();
            this.enableLabel = new System.Windows.Forms.Label();
            this.border1 = new System.Windows.Forms.Label();
            this.border2 = new System.Windows.Forms.Label();
            this.border3 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.smoothSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.enableCheckBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.enableCheckBox.Location = new System.Drawing.Point(168, 14);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(15, 14);
            this.enableCheckBox.TabIndex = 0;
            this.enableCheckBox.UseVisualStyleBackColor = false;
            this.enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // weaponCombo
            // 
            this.weaponCombo.AccessibleName = "weaponSelection";
            this.weaponCombo.BackColor = System.Drawing.Color.White;
            this.weaponCombo.ForeColor = System.Drawing.Color.DimGray;
            this.weaponCombo.FormattingEnabled = true;
            this.weaponCombo.Items.AddRange(new object[] {
            "Krig",
            "LC10",
            "XM4",
            "AK47U"});
            this.weaponCombo.Location = new System.Drawing.Point(168, 47);
            this.weaponCombo.Name = "weaponCombo";
            this.weaponCombo.Size = new System.Drawing.Size(121, 25);
            this.weaponCombo.TabIndex = 1;
            this.weaponCombo.SelectedIndexChanged += new System.EventHandler(this.weaponCombo_SelectedIndexChanged);
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.BackColor = System.Drawing.Color.Transparent;
            this.weaponLabel.Location = new System.Drawing.Point(26, 52);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(137, 17);
            this.weaponLabel.TabIndex = 2;
            this.weaponLabel.Text = "Weapon Selection:";
            // 
            // smoothSlider
            // 
            this.smoothSlider.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.smoothSlider.Location = new System.Drawing.Point(168, 84);
            this.smoothSlider.Maximum = 5;
            this.smoothSlider.Minimum = 1;
            this.smoothSlider.Name = "smoothSlider";
            this.smoothSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.smoothSlider.Size = new System.Drawing.Size(121, 45);
            this.smoothSlider.TabIndex = 1;
            this.smoothSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.smoothSlider.Value = 1;
            this.smoothSlider.Scroll += new System.EventHandler(this.smoothSlider_Scroll);
            // 
            // smoothLabel
            // 
            this.smoothLabel.AutoSize = true;
            this.smoothLabel.BackColor = System.Drawing.Color.Transparent;
            this.smoothLabel.Location = new System.Drawing.Point(26, 96);
            this.smoothLabel.Name = "smoothLabel";
            this.smoothLabel.Size = new System.Drawing.Size(91, 17);
            this.smoothLabel.TabIndex = 4;
            this.smoothLabel.Text = "Smoothness:";
            // 
            // smoothValue
            // 
            this.smoothValue.AccessibleName = "smoothValue";
            this.smoothValue.AutoSize = true;
            this.smoothValue.BackColor = System.Drawing.Color.Transparent;
            this.smoothValue.Location = new System.Drawing.Point(297, 96);
            this.smoothValue.Name = "smoothValue";
            this.smoothValue.Size = new System.Drawing.Size(14, 17);
            this.smoothValue.TabIndex = 5;
            this.smoothValue.Text = "1";
            // 
            // enableLabel
            // 
            this.enableLabel.AutoSize = true;
            this.enableLabel.BackColor = System.Drawing.Color.Transparent;
            this.enableLabel.Location = new System.Drawing.Point(29, 12);
            this.enableLabel.Name = "enableLabel";
            this.enableLabel.Size = new System.Drawing.Size(56, 17);
            this.enableLabel.TabIndex = 6;
            this.enableLabel.Text = "Enable";
            // 
            // border1
            // 
            this.border1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border1.Location = new System.Drawing.Point(29, 81);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(260, 2);
            this.border1.TabIndex = 7;
            this.border1.Text = "                  ";
            // 
            // border2
            // 
            this.border2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border2.Location = new System.Drawing.Point(29, 37);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(260, 2);
            this.border2.TabIndex = 8;
            this.border2.Text = "                  ";
            // 
            // border3
            // 
            this.border3.BackColor = System.Drawing.Color.Black;
            this.border3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border3.Location = new System.Drawing.Point(29, 128);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(260, 2);
            this.border3.TabIndex = 9;
            this.border3.Text = "                  ";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Smallest Pixel-7", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(287, 138);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(75, 14);
            this.versionLabel.TabIndex = 10;
            this.versionLabel.Text = "Version: 1.1";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(370, 159);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.border3);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.border1);
            this.Controls.Add(this.enableLabel);
            this.Controls.Add(this.smoothValue);
            this.Controls.Add(this.smoothLabel);
            this.Controls.Add(this.smoothSlider);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.weaponCombo);
            this.Controls.Add(this.enableCheckBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Smallest Pixel-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ColdWar Recoil Assist";
            ((System.ComponentModel.ISupportInitialize)(this.smoothSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox gunSelection;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.ComboBox weaponCombo;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.TrackBar smoothSlider;
        private System.Windows.Forms.Label smoothLabel;
        private System.Windows.Forms.Label smoothValue;
        private System.Windows.Forms.Label enableLabel;
        private System.Windows.Forms.Label border1;
        private System.Windows.Forms.Label border2;
        private System.Windows.Forms.Label border3;
        private System.Windows.Forms.Label versionLabel;

        public object Style { get; private set; }
    }
}

