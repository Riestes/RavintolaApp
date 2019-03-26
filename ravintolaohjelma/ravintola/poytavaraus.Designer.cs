namespace ravintola
{
    partial class poytavaraus
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label etunimiLabel;
            System.Windows.Forms.Label sukunimiLabel;
            System.Windows.Forms.Label kloLabel;
            System.Windows.Forms.Label pvmLabel;
            System.Windows.Forms.Label pöytänroLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.varauksetDataSet1 = new ravintola.VarauksetDataSet1();
            this.varauksetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varauksetTableAdapter = new ravintola.VarauksetDataSet1TableAdapters.VarauksetTableAdapter();
            this.tableAdapterManager1 = new ravintola.VarauksetDataSet1TableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.etunimiTextBox = new System.Windows.Forms.TextBox();
            this.sukunimiTextBox = new System.Windows.Forms.TextBox();
            this.kloTextBox = new System.Windows.Forms.TextBox();
            this.pvmTextBox = new System.Windows.Forms.TextBox();
            this.pöytänroTextBox = new System.Windows.Forms.TextBox();
            this.varauksetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            etunimiLabel = new System.Windows.Forms.Label();
            sukunimiLabel = new System.Windows.Forms.Label();
            kloLabel = new System.Windows.Forms.Label();
            pvmLabel = new System.Windows.Forms.Label();
            pöytänroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(6, 11);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 16;
            idLabel.Text = "Id:";
            // 
            // etunimiLabel
            // 
            etunimiLabel.AutoSize = true;
            etunimiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            etunimiLabel.Location = new System.Drawing.Point(6, 37);
            etunimiLabel.Name = "etunimiLabel";
            etunimiLabel.Size = new System.Drawing.Size(44, 13);
            etunimiLabel.TabIndex = 18;
            etunimiLabel.Text = "Etunimi:";
            // 
            // sukunimiLabel
            // 
            sukunimiLabel.AutoSize = true;
            sukunimiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sukunimiLabel.Location = new System.Drawing.Point(6, 63);
            sukunimiLabel.Name = "sukunimiLabel";
            sukunimiLabel.Size = new System.Drawing.Size(53, 13);
            sukunimiLabel.TabIndex = 20;
            sukunimiLabel.Text = "Sukunimi:";
            // 
            // kloLabel
            // 
            kloLabel.AutoSize = true;
            kloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kloLabel.Location = new System.Drawing.Point(6, 89);
            kloLabel.Name = "kloLabel";
            kloLabel.Size = new System.Drawing.Size(25, 13);
            kloLabel.TabIndex = 22;
            kloLabel.Text = "Klo:";
            // 
            // pvmLabel
            // 
            pvmLabel.AutoSize = true;
            pvmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pvmLabel.Location = new System.Drawing.Point(6, 115);
            pvmLabel.Name = "pvmLabel";
            pvmLabel.Size = new System.Drawing.Size(31, 13);
            pvmLabel.TabIndex = 24;
            pvmLabel.Text = "Pvm:";
            // 
            // pöytänroLabel
            // 
            pöytänroLabel.AutoSize = true;
            pöytänroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pöytänroLabel.Location = new System.Drawing.Point(6, 141);
            pöytänroLabel.Name = "pöytänroLabel";
            pöytänroLabel.Size = new System.Drawing.Size(52, 13);
            pöytänroLabel.TabIndex = 26;
            pöytänroLabel.Text = "Pöytänro:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(65, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Lisää";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(65, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Tallenna";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(65, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Poista";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // varauksetDataSet1
            // 
            this.varauksetDataSet1.DataSetName = "VarauksetDataSet1";
            this.varauksetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varauksetBindingSource
            // 
            this.varauksetBindingSource.DataMember = "Varaukset";
            this.varauksetBindingSource.DataSource = this.varauksetDataSet1;
            // 
            // varauksetTableAdapter
            // 
            this.varauksetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = ravintola.VarauksetDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VarauksetTableAdapter = this.varauksetTableAdapter;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.varauksetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(65, 8);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(37, 20);
            this.idTextBox.TabIndex = 17;
            // 
            // etunimiTextBox
            // 
            this.etunimiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.varauksetBindingSource, "Etunimi", true));
            this.etunimiTextBox.Location = new System.Drawing.Point(65, 34);
            this.etunimiTextBox.Name = "etunimiTextBox";
            this.etunimiTextBox.Size = new System.Drawing.Size(100, 20);
            this.etunimiTextBox.TabIndex = 19;
            // 
            // sukunimiTextBox
            // 
            this.sukunimiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.varauksetBindingSource, "Sukunimi", true));
            this.sukunimiTextBox.Location = new System.Drawing.Point(65, 60);
            this.sukunimiTextBox.Name = "sukunimiTextBox";
            this.sukunimiTextBox.Size = new System.Drawing.Size(100, 20);
            this.sukunimiTextBox.TabIndex = 21;
            // 
            // kloTextBox
            // 
            this.kloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.varauksetBindingSource, "Klo", true));
            this.kloTextBox.Location = new System.Drawing.Point(65, 86);
            this.kloTextBox.Name = "kloTextBox";
            this.kloTextBox.Size = new System.Drawing.Size(100, 20);
            this.kloTextBox.TabIndex = 23;
            // 
            // pvmTextBox
            // 
            this.pvmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.varauksetBindingSource, "Pvm", true));
            this.pvmTextBox.Location = new System.Drawing.Point(65, 112);
            this.pvmTextBox.Name = "pvmTextBox";
            this.pvmTextBox.Size = new System.Drawing.Size(100, 20);
            this.pvmTextBox.TabIndex = 25;
            // 
            // pöytänroTextBox
            // 
            this.pöytänroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.varauksetBindingSource, "Pöytänro", true));
            this.pöytänroTextBox.Location = new System.Drawing.Point(65, 138);
            this.pöytänroTextBox.Name = "pöytänroTextBox";
            this.pöytänroTextBox.Size = new System.Drawing.Size(37, 20);
            this.pöytänroTextBox.TabIndex = 27;
            // 
            // varauksetDataGridView
            // 
            this.varauksetDataGridView.AutoGenerateColumns = false;
            this.varauksetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varauksetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.varauksetDataGridView.DataSource = this.varauksetBindingSource;
            this.varauksetDataGridView.Location = new System.Drawing.Point(180, 12);
            this.varauksetDataGridView.Name = "varauksetDataGridView";
            this.varauksetDataGridView.Size = new System.Drawing.Size(628, 233);
            this.varauksetDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Etunimi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Etunimi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sukunimi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sukunimi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Klo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Klo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pvm";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pvm";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pöytänro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pöytänro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // poytavaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(822, 258);
            this.Controls.Add(this.varauksetDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(etunimiLabel);
            this.Controls.Add(this.etunimiTextBox);
            this.Controls.Add(sukunimiLabel);
            this.Controls.Add(this.sukunimiTextBox);
            this.Controls.Add(kloLabel);
            this.Controls.Add(this.kloTextBox);
            this.Controls.Add(pvmLabel);
            this.Controls.Add(this.pvmTextBox);
            this.Controls.Add(pöytänroLabel);
            this.Controls.Add(this.pöytänroTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "poytavaraus";
            this.Text = "Pöytävaraus";
            this.Load += new System.EventHandler(this.poytavaraus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private VarauksetDataSet1 varauksetDataSet1;
        private System.Windows.Forms.BindingSource varauksetBindingSource;
        private VarauksetDataSet1TableAdapters.VarauksetTableAdapter varauksetTableAdapter;
        private VarauksetDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox etunimiTextBox;
        private System.Windows.Forms.TextBox sukunimiTextBox;
        private System.Windows.Forms.TextBox kloTextBox;
        private System.Windows.Forms.TextBox pvmTextBox;
        private System.Windows.Forms.TextBox pöytänroTextBox;
        private System.Windows.Forms.DataGridView varauksetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}