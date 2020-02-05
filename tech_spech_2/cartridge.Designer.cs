namespace tech_spech_2
{
    partial class cartridge
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
            this.button2 = new System.Windows.Forms.Button();
            this.tech_specDataSet = new tech_spech_2.tech_specDataSet();
            this.cartridgeTableAdapter = new tech_spech_2.tech_specDataSetTableAdapters.cartridgeTableAdapter();
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
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tech_specDataSet1 = new tech_spech_2.tech_specDataSet1();
            this.cartridgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_specDataSet12 = new tech_spech_2.tech_specDataSet1();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_specDataSet11 = new tech_spech_2.tech_specDataSet1();
            this.cartridgeTableAdapter1 = new tech_spech_2.tech_specDataSet1TableAdapters.cartridgeTableAdapter();
            this.dataTable1TableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.DataTable1TableAdapter();
            this.tech_specDataSet13 = new tech_spech_2.tech_specDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet13)).BeginInit();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "New cartridge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tech_specDataSet
            // 
            this.tech_specDataSet.DataSetName = "tech_specDataSet";
            this.tech_specDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartridgeTableAdapter
            // 
            this.cartridgeTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.tech_specDataSet1;
            // 
            // tech_specDataSet1
            // 
            this.tech_specDataSet1.DataSetName = "tech_specDataSet1";
            this.tech_specDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartridgeBindingSource
            // 
            this.cartridgeBindingSource.DataMember = "cartridge";
            this.cartridgeBindingSource.DataSource = this.tech_specDataSet1;
            // 
            // tech_specDataSet12
            // 
            this.tech_specDataSet12.DataSetName = "tech_specDataSet1";
            this.tech_specDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.tech_specDataSet11;
            // 
            // tech_specDataSet11
            // 
            this.tech_specDataSet11.DataSetName = "tech_specDataSet1";
            this.tech_specDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartridgeTableAdapter1
            // 
            this.cartridgeTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tech_specDataSet13
            // 
            this.tech_specDataSet13.DataSetName = "tech_specDataSet1";
            this.tech_specDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 200);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "cartridge";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cartridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private tech_specDataSet tech_specDataSet;
        private System.Windows.Forms.BindingSource cartridgeBindingSource;
        private tech_specDataSetTableAdapters.cartridgeTableAdapter cartridgeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tech_specDataSet1 tech_specDataSet1;
        private tech_specDataSet1TableAdapters.cartridgeTableAdapter cartridgeTableAdapter1;
        private tech_specDataSet1 tech_specDataSet11;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private tech_specDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private tech_specDataSet1 tech_specDataSet12;
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
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private tech_specDataSet1 tech_specDataSet13;
    }
}