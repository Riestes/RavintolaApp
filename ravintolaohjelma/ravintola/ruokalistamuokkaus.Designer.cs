namespace ravintola
{
    partial class ruokalistamuokkaus
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
            this.otsikko = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.hintaNollaalvBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.annosIDBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tallennaButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.glutoncheckBox = new System.Windows.Forms.CheckBox();
            this.laktoncheckBox = new System.Windows.Forms.CheckBox();
            this.annosBox = new System.Windows.Forms.TextBox();
            this.hintaBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.suljeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // otsikko
            // 
            this.otsikko.AutoSize = true;
            this.otsikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otsikko.Location = new System.Drawing.Point(58, 9);
            this.otsikko.Name = "otsikko";
            this.otsikko.Size = new System.Drawing.Size(395, 42);
            this.otsikko.TabIndex = 0;
            this.otsikko.Text = "Ruokalistan muokkaus";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.suljeButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.hintaNollaalvBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.annosIDBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tallennaButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.glutoncheckBox);
            this.panel1.Controls.Add(this.laktoncheckBox);
            this.panel1.Controls.Add(this.annosBox);
            this.panel1.Controls.Add(this.hintaBox);
            this.panel1.Location = new System.Drawing.Point(6, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 122);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "€";
            // 
            // hintaNollaalvBox
            // 
            this.hintaNollaalvBox.Location = new System.Drawing.Point(298, 29);
            this.hintaNollaalvBox.Name = "hintaNollaalvBox";
            this.hintaNollaalvBox.ReadOnly = true;
            this.hintaNollaalvBox.Size = new System.Drawing.Size(46, 20);
            this.hintaNollaalvBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ALV 0%";
            // 
            // annosIDBox
            // 
            this.annosIDBox.Location = new System.Drawing.Point(298, 53);
            this.annosIDBox.Name = "annosIDBox";
            this.annosIDBox.ReadOnly = true;
            this.annosIDBox.Size = new System.Drawing.Size(36, 20);
            this.annosIDBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Annos ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ulosmyyntihinta";
            // 
            // tallennaButton
            // 
            this.tallennaButton.Location = new System.Drawing.Point(7, 10);
            this.tallennaButton.Name = "tallennaButton";
            this.tallennaButton.Size = new System.Drawing.Size(75, 85);
            this.tallennaButton.TabIndex = 5;
            this.tallennaButton.Text = "Tallenna";
            this.tallennaButton.UseVisualStyleBackColor = true;
            this.tallennaButton.Click += new System.EventHandler(this.tallennaButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "€";
            // 
            // glutoncheckBox
            // 
            this.glutoncheckBox.AutoSize = true;
            this.glutoncheckBox.Location = new System.Drawing.Point(91, 78);
            this.glutoncheckBox.Name = "glutoncheckBox";
            this.glutoncheckBox.Size = new System.Drawing.Size(80, 17);
            this.glutoncheckBox.TabIndex = 8;
            this.glutoncheckBox.Text = "Gluteeniton";
            this.glutoncheckBox.UseVisualStyleBackColor = true;
            // 
            // laktoncheckBox
            // 
            this.laktoncheckBox.AutoSize = true;
            this.laktoncheckBox.Location = new System.Drawing.Point(91, 55);
            this.laktoncheckBox.Name = "laktoncheckBox";
            this.laktoncheckBox.Size = new System.Drawing.Size(81, 17);
            this.laktoncheckBox.TabIndex = 7;
            this.laktoncheckBox.Text = "Laktoositon";
            this.laktoncheckBox.UseVisualStyleBackColor = true;
            // 
            // annosBox
            // 
            this.annosBox.Location = new System.Drawing.Point(121, 7);
            this.annosBox.Name = "annosBox";
            this.annosBox.Size = new System.Drawing.Size(286, 20);
            this.annosBox.TabIndex = 5;
            // 
            // hintaBox
            // 
            this.hintaBox.Location = new System.Drawing.Point(174, 29);
            this.hintaBox.Name = "hintaBox";
            this.hintaBox.Size = new System.Drawing.Size(47, 20);
            this.hintaBox.TabIndex = 6;
            this.hintaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hintaBox_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "annos1",
            "annos2",
            "annos3",
            "annos4",
            "annos5",
            "annos6"});
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(475, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 277);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(5, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 248);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ruokalista";
            // 
            // suljeButton
            // 
            this.suljeButton.Location = new System.Drawing.Point(408, 32);
            this.suljeButton.Name = "suljeButton";
            this.suljeButton.Size = new System.Drawing.Size(64, 65);
            this.suljeButton.TabIndex = 6;
            this.suljeButton.Text = "Sulje";
            this.suljeButton.UseVisualStyleBackColor = true;
            this.suljeButton.Click += new System.EventHandler(this.suljeButton_Click);
            // 
            // ruokalistamuokkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 355);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.otsikko);
            this.Name = "ruokalistamuokkaus";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikko;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox glutoncheckBox;
        private System.Windows.Forms.CheckBox laktoncheckBox;
        private System.Windows.Forms.TextBox annosBox;
        private System.Windows.Forms.TextBox hintaBox;
        private System.Windows.Forms.Button tallennaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox annosIDBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hintaNollaalvBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button suljeButton;
    }
}

