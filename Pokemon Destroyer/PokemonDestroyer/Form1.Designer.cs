namespace PokemonDestroyer
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNormal = new System.Windows.Forms.CheckBox();
            this.cbDark = new System.Windows.Forms.CheckBox();
            this.cbShiny = new System.Windows.Forms.CheckBox();
            this.cbMystic = new System.Windows.Forms.CheckBox();
            this.cbShadow = new System.Windows.Forms.CheckBox();
            this.cbMetallic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "DESTROY ! :D";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Keep Searching";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ghost Map",
            "Grass Map",
            "Cave Map",
            "Electric Map",
            "Fire Map",
            "Ice Map"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Types";
            // 
            // cbNormal
            // 
            this.cbNormal.AutoSize = true;
            this.cbNormal.Location = new System.Drawing.Point(139, 29);
            this.cbNormal.Name = "cbNormal";
            this.cbNormal.Size = new System.Drawing.Size(59, 17);
            this.cbNormal.TabIndex = 7;
            this.cbNormal.Text = "Normal";
            this.cbNormal.UseVisualStyleBackColor = true;
            // 
            // cbDark
            // 
            this.cbDark.AutoSize = true;
            this.cbDark.Location = new System.Drawing.Point(139, 51);
            this.cbDark.Name = "cbDark";
            this.cbDark.Size = new System.Drawing.Size(49, 17);
            this.cbDark.TabIndex = 8;
            this.cbDark.Text = "Dark";
            this.cbDark.UseVisualStyleBackColor = true;
            // 
            // cbShiny
            // 
            this.cbShiny.AutoSize = true;
            this.cbShiny.Location = new System.Drawing.Point(139, 74);
            this.cbShiny.Name = "cbShiny";
            this.cbShiny.Size = new System.Drawing.Size(52, 17);
            this.cbShiny.TabIndex = 9;
            this.cbShiny.Text = "Shiny";
            this.cbShiny.UseVisualStyleBackColor = true;
            // 
            // cbMystic
            // 
            this.cbMystic.AutoSize = true;
            this.cbMystic.Location = new System.Drawing.Point(139, 97);
            this.cbMystic.Name = "cbMystic";
            this.cbMystic.Size = new System.Drawing.Size(56, 17);
            this.cbMystic.TabIndex = 10;
            this.cbMystic.Text = "Mystic";
            this.cbMystic.UseVisualStyleBackColor = true;
            // 
            // cbShadow
            // 
            this.cbShadow.AutoSize = true;
            this.cbShadow.Location = new System.Drawing.Point(139, 120);
            this.cbShadow.Name = "cbShadow";
            this.cbShadow.Size = new System.Drawing.Size(65, 17);
            this.cbShadow.TabIndex = 11;
            this.cbShadow.Text = "Shadow";
            this.cbShadow.UseVisualStyleBackColor = true;
            // 
            // cbMetallic
            // 
            this.cbMetallic.AutoSize = true;
            this.cbMetallic.Location = new System.Drawing.Point(139, 143);
            this.cbMetallic.Name = "cbMetallic";
            this.cbMetallic.Size = new System.Drawing.Size(62, 17);
            this.cbMetallic.TabIndex = 12;
            this.cbMetallic.Text = "Metallic";
            this.cbMetallic.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 169);
            this.Controls.Add(this.cbMetallic);
            this.Controls.Add(this.cbShadow);
            this.Controls.Add(this.cbMystic);
            this.Controls.Add(this.cbShiny);
            this.Controls.Add(this.cbDark);
            this.Controls.Add(this.cbNormal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Pokemon Destroyer v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNormal;
        private System.Windows.Forms.CheckBox cbDark;
        private System.Windows.Forms.CheckBox cbShiny;
        private System.Windows.Forms.CheckBox cbMystic;
        private System.Windows.Forms.CheckBox cbShadow;
        private System.Windows.Forms.CheckBox cbMetallic;
    }
}

