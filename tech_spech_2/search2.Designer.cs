namespace tech_spech_2
{
    partial class search2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фирмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЗадачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.организацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяТехспецDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияТехспецDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотовалDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.магнитныйВалDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.роликЗарядаDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ракельDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.дозирующееЛезвиеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_specDataSet1 = new tech_spech_2.tech_specDataSet1();
            this.dataTable1TableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn,
            this.фирмаDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.номерЗадачиDataGridViewTextBoxColumn,
            this.имяКлиентаDataGridViewTextBoxColumn,
            this.фамилияКлиентаDataGridViewTextBoxColumn,
            this.организацияDataGridViewTextBoxColumn,
            this.имяТехспецDataGridViewTextBoxColumn,
            this.фамилияТехспецDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.фотовалDataGridViewCheckBoxColumn,
            this.магнитныйВалDataGridViewCheckBoxColumn,
            this.роликЗарядаDataGridViewCheckBoxColumn,
            this.ракельDataGridViewCheckBoxColumn,
            this.дозирующееЛезвиеDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 233);
            this.dataGridView1.TabIndex = 2;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
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
            // организацияDataGridViewTextBoxColumn
            // 
            this.организацияDataGridViewTextBoxColumn.DataPropertyName = "Организация";
            this.организацияDataGridViewTextBoxColumn.HeaderText = "Организация";
            this.организацияDataGridViewTextBoxColumn.Name = "организацияDataGridViewTextBoxColumn";
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
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // фотовалDataGridViewCheckBoxColumn
            // 
            this.фотовалDataGridViewCheckBoxColumn.DataPropertyName = "Фотовал";
            this.фотовалDataGridViewCheckBoxColumn.HeaderText = "Фотовал";
            this.фотовалDataGridViewCheckBoxColumn.Name = "фотовалDataGridViewCheckBoxColumn";
            // 
            // магнитныйВалDataGridViewCheckBoxColumn
            // 
            this.магнитныйВалDataGridViewCheckBoxColumn.DataPropertyName = "Магнитный вал";
            this.магнитныйВалDataGridViewCheckBoxColumn.HeaderText = "Магнитный вал";
            this.магнитныйВалDataGridViewCheckBoxColumn.Name = "магнитныйВалDataGridViewCheckBoxColumn";
            // 
            // роликЗарядаDataGridViewCheckBoxColumn
            // 
            this.роликЗарядаDataGridViewCheckBoxColumn.DataPropertyName = "Ролик заряда";
            this.роликЗарядаDataGridViewCheckBoxColumn.HeaderText = "Ролик заряда";
            this.роликЗарядаDataGridViewCheckBoxColumn.Name = "роликЗарядаDataGridViewCheckBoxColumn";
            // 
            // ракельDataGridViewCheckBoxColumn
            // 
            this.ракельDataGridViewCheckBoxColumn.DataPropertyName = "Ракель";
            this.ракельDataGridViewCheckBoxColumn.HeaderText = "Ракель";
            this.ракельDataGridViewCheckBoxColumn.Name = "ракельDataGridViewCheckBoxColumn";
            // 
            // дозирующееЛезвиеDataGridViewCheckBoxColumn
            // 
            this.дозирующееЛезвиеDataGridViewCheckBoxColumn.DataPropertyName = "Дозирующее лезвие";
            this.дозирующееЛезвиеDataGridViewCheckBoxColumn.HeaderText = "Дозирующее лезвие";
            this.дозирующееЛезвиеDataGridViewCheckBoxColumn.Name = "дозирующееЛезвиеDataGridViewCheckBoxColumn";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.tech_specDataSet1;
            // 
            // tech_specDataSet1
            // 
            this.tech_specDataSet1.DataSetName = "tech_specDataSet1";
            this.tech_specDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // search2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 286);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "search2";
            this.Text = "search cartridge";
            this.Load += new System.EventHandler(this.Search2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tech_specDataSet1 tech_specDataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private tech_specDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фирмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗадачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn организацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяТехспецDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияТехспецDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn фотовалDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn магнитныйВалDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn роликЗарядаDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ракельDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn дозирующееЛезвиеDataGridViewCheckBoxColumn;
    }
}