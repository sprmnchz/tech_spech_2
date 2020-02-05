namespace tech_spech_2
{
    partial class search
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
            this.tech_specDataSet1 = new tech_spech_2.tech_specDataSet1();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.DataTable2TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.фирмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерОборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серийныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дефектDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комплектацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЗадачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяТехспецDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияТехспецDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tech_specTableAdapter1 = new tech_spech_2.tech_specDataSet1TableAdapters.tech_specTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tech_specDataSet1
            // 
            this.tech_specDataSet1.DataSetName = "tech_specDataSet1";
            this.tech_specDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.tech_specDataSet1;
            this.dataTable2BindingSource.Filter = "";
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фирмаDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.номерОборудованияDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.серийныйНомерDataGridViewTextBoxColumn,
            this.дефектDataGridViewTextBoxColumn,
            this.комплектацияDataGridViewTextBoxColumn,
            this.номерЗадачиDataGridViewTextBoxColumn,
            this.имяКлиентаDataGridViewTextBoxColumn,
            this.фамилияКлиентаDataGridViewTextBoxColumn,
            this.имяТехспецDataGridViewTextBoxColumn,
            this.фамилияТехспецDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(877, 223);
            this.dataGridView1.TabIndex = 5;
            // 
            // фирмаDataGridViewTextBoxColumn
            // 
            this.фирмаDataGridViewTextBoxColumn.DataPropertyName = "Фирма";
            this.фирмаDataGridViewTextBoxColumn.HeaderText = "Фирма";
            this.фирмаDataGridViewTextBoxColumn.Name = "фирмаDataGridViewTextBoxColumn";
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            // 
            // номерОборудованияDataGridViewTextBoxColumn
            // 
            this.номерОборудованияDataGridViewTextBoxColumn.DataPropertyName = "Номер оборудования";
            this.номерОборудованияDataGridViewTextBoxColumn.HeaderText = "Номер оборудования";
            this.номерОборудованияDataGridViewTextBoxColumn.Name = "номерОборудованияDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // серийныйНомерDataGridViewTextBoxColumn
            // 
            this.серийныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Серийный номер";
            this.серийныйНомерDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.серийныйНомерDataGridViewTextBoxColumn.Name = "серийныйНомерDataGridViewTextBoxColumn";
            // 
            // дефектDataGridViewTextBoxColumn
            // 
            this.дефектDataGridViewTextBoxColumn.DataPropertyName = "Дефект";
            this.дефектDataGridViewTextBoxColumn.HeaderText = "Дефект";
            this.дефектDataGridViewTextBoxColumn.Name = "дефектDataGridViewTextBoxColumn";
            // 
            // комплектацияDataGridViewTextBoxColumn
            // 
            this.комплектацияDataGridViewTextBoxColumn.DataPropertyName = "Комплектация";
            this.комплектацияDataGridViewTextBoxColumn.HeaderText = "Комплектация";
            this.комплектацияDataGridViewTextBoxColumn.Name = "комплектацияDataGridViewTextBoxColumn";
            // 
            // номерЗадачиDataGridViewTextBoxColumn
            // 
            this.номерЗадачиDataGridViewTextBoxColumn.DataPropertyName = "Номер задачи";
            this.номерЗадачиDataGridViewTextBoxColumn.HeaderText = "Номер задачи";
            this.номерЗадачиDataGridViewTextBoxColumn.Name = "номерЗадачиDataGridViewTextBoxColumn";
            // 
            // имяКлиентаDataGridViewTextBoxColumn
            // 
            this.имяКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Имя клиента";
            this.имяКлиентаDataGridViewTextBoxColumn.HeaderText = "Имя клиента";
            this.имяКлиентаDataGridViewTextBoxColumn.Name = "имяКлиентаDataGridViewTextBoxColumn";
            // 
            // фамилияКлиентаDataGridViewTextBoxColumn
            // 
            this.фамилияКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия клиента";
            this.фамилияКлиентаDataGridViewTextBoxColumn.HeaderText = "Фамилия клиента";
            this.фамилияКлиентаDataGridViewTextBoxColumn.Name = "фамилияКлиентаDataGridViewTextBoxColumn";
            // 
            // имяТехспецDataGridViewTextBoxColumn
            // 
            this.имяТехспецDataGridViewTextBoxColumn.DataPropertyName = "Имя тех_спец";
            this.имяТехспецDataGridViewTextBoxColumn.HeaderText = "Имя тех_спец";
            this.имяТехспецDataGridViewTextBoxColumn.Name = "имяТехспецDataGridViewTextBoxColumn";
            // 
            // фамилияТехспецDataGridViewTextBoxColumn
            // 
            this.фамилияТехспецDataGridViewTextBoxColumn.DataPropertyName = "Фамилия тех_спец";
            this.фамилияТехспецDataGridViewTextBoxColumn.HeaderText = "Фамилия тех_спец";
            this.фамилияТехспецDataGridViewTextBoxColumn.Name = "фамилияТехспецDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // tech_specTableAdapter1
            // 
            this.tech_specTableAdapter1.ClearBeforeFill = true;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 270);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "search";
            this.Text = "search equipment";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private tech_specDataSet1 tech_specDataSet1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private tech_specDataSet1TableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фирмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серийныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дефектDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комплектацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗадачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяТехспецDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияТехспецDataGridViewTextBoxColumn;
        private tech_specDataSet1TableAdapters.tech_specTableAdapter tech_specTableAdapter1;
    }
}