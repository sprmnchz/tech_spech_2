namespace tech_spech_2
{
    partial class new_cartridge
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tech_specDataSet1 = new tech_spech_2.tech_specDataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cartridgemanufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cartridgemodelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techspecDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.clientTableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.clientTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.techspecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tech_specTableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.tech_specTableAdapter();
            this.cartridge_modelTableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.cartridge_modelTableAdapter();
            this.techspecDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cartridge_manufacturerTableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.cartridge_manufacturerTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgemanufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgemodelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientBindingSource1;
            this.comboBox1.DisplayMember = "first_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "first_name";
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "client";
            this.clientBindingSource1.DataSource = this.tech_specDataSet1;
            // 
            // tech_specDataSet1
            // 
            this.tech_specDataSet1.DataSetName = "tech_specDataSet1";
            this.tech_specDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.tech_specDataSet1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.cartridgemanufacturerBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "name";
            // 
            // cartridgemanufacturerBindingSource
            // 
            this.cartridgemanufacturerBindingSource.DataMember = "cartridge_manufacturer";
            this.cartridgemanufacturerBindingSource.DataSource = this.tech_specDataSet1;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.cartridgemodelBindingSource;
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 94);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "name";
            // 
            // cartridgemodelBindingSource
            // 
            this.cartridgemodelBindingSource.DataMember = "cartridge_model";
            this.cartridgemodelBindingSource.DataSource = this.techspecDataSet1BindingSource;
            // 
            // techspecDataSet1BindingSource
            // 
            this.techspecDataSet1BindingSource.DataSource = this.tech_specDataSet1;
            this.techspecDataSet1BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cartridge ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Manufacturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Model";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add work";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.techspecBindingSource;
            this.comboBox4.DisplayMember = "first_name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 121);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 13;
            this.comboBox4.ValueMember = "tech_spec_id";
            // 
            // techspecBindingSource
            // 
            this.techspecBindingSource.DataMember = "tech_spec";
            this.techspecBindingSource.DataSource = this.tech_specDataSet1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tech spec";
            // 
            // tech_specTableAdapter
            // 
            this.tech_specTableAdapter.ClearBeforeFill = true;
            // 
            // cartridge_modelTableAdapter
            // 
            this.cartridge_modelTableAdapter.ClearBeforeFill = true;
            // 
            // techspecDataSet1BindingSource1
            // 
            this.techspecDataSet1BindingSource1.DataSource = this.tech_specDataSet1;
            this.techspecDataSet1BindingSource1.Position = 0;
            // 
            // cartridge_manufacturerTableAdapter
            // 
            this.cartridge_manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Foto roll";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 171);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Magnetic roll";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 194);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(69, 17);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Chardger";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 217);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 17);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "Racel";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(12, 240);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(88, 17);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.Text = "Dosing blade";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // new_cartridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(269, 264);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "new_cartridge";
            this.Text = "new_cartridge";
            this.Load += new System.EventHandler(this.new_cartridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgemanufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgemodelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private tech_specDataSet1 tech_specDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private tech_specDataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource techspecBindingSource;
        private tech_specDataSet1TableAdapters.tech_specTableAdapter tech_specTableAdapter;
        private System.Windows.Forms.BindingSource techspecDataSet1BindingSource;
        private System.Windows.Forms.BindingSource cartridgemodelBindingSource;
        private tech_specDataSet1TableAdapters.cartridge_modelTableAdapter cartridge_modelTableAdapter;
        private System.Windows.Forms.BindingSource techspecDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource cartridgemanufacturerBindingSource;
        private tech_specDataSet1TableAdapters.cartridge_manufacturerTableAdapter cartridge_manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}