﻿namespace tech_spech_2
{
    partial class new_task
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.equipmentmanufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_specDataSet1 = new tech_spech_2.tech_specDataSet1();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.equipmentmodelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techspecDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.techspecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.tech_specTableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.tech_specTableAdapter();
            this.equipment_modelTableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.equipment_modelTableAdapter();
            this.equipment_manufacturerTableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.equipment_manufacturerTableAdapter();
            this.techspecDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new tech_spech_2.tech_specDataSet1TableAdapters.clientTableAdapter();
            this.equipmentmanufacturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentmanufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentmodelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentmanufacturerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientBindingSource;
            this.comboBox1.DisplayMember = "first_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "client_id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.equipmentmanufacturerBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "manufacturer_id";
            // 
            // equipmentmanufacturerBindingSource
            // 
            this.equipmentmanufacturerBindingSource.DataMember = "equipment_manufacturer";
            this.equipmentmanufacturerBindingSource.DataSource = this.tech_specDataSet1;
            // 
            // tech_specDataSet1
            // 
            this.tech_specDataSet1.DataSetName = "tech_specDataSet1";
            this.tech_specDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.equipmentmodelBindingSource;
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 66);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "model_id";
            // 
            // equipmentmodelBindingSource
            // 
            this.equipmentmodelBindingSource.DataMember = "equipment_model";
            this.equipmentmodelBindingSource.DataSource = this.techspecDataSet1BindingSource;
            // 
            // techspecDataSet1BindingSource
            // 
            this.techspecDataSet1BindingSource.DataSource = this.tech_specDataSet1;
            this.techspecDataSet1BindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "New client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add task";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "New data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Serial number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Defect";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Equipment set";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.techspecBindingSource;
            this.comboBox4.DisplayMember = "first_name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 171);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.ValueMember = "tech_spec_id";
            // 
            // techspecBindingSource
            // 
            this.techspecBindingSource.DataMember = "tech_spec";
            this.techspecBindingSource.DataSource = this.tech_specDataSet1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tech spec";
            // 
            // tech_specTableAdapter
            // 
            this.tech_specTableAdapter.ClearBeforeFill = true;
            // 
            // equipment_modelTableAdapter
            // 
            this.equipment_modelTableAdapter.ClearBeforeFill = true;
            // 
            // equipment_manufacturerTableAdapter
            // 
            this.equipment_manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // techspecDataSet1BindingSource1
            // 
            this.techspecDataSet1BindingSource1.DataSource = this.tech_specDataSet1;
            this.techspecDataSet1BindingSource1.Position = 0;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.tech_specDataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentmanufacturerBindingSource1
            // 
            this.equipmentmanufacturerBindingSource1.DataMember = "equipment_manufacturer";
            this.equipmentmanufacturerBindingSource1.DataSource = this.tech_specDataSet1;
            // 
            // new_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(271, 239);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "new_task";
            this.Text = "new_task";
            this.Load += new System.EventHandler(this.New_task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentmanufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentmodelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techspecDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentmanufacturerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private tech_specDataSet1 tech_specDataSet1;
        private System.Windows.Forms.BindingSource techspecBindingSource;
        private tech_specDataSet1TableAdapters.tech_specTableAdapter tech_specTableAdapter;
        private System.Windows.Forms.BindingSource techspecDataSet1BindingSource;
        private System.Windows.Forms.BindingSource equipmentmodelBindingSource;
        private tech_specDataSet1TableAdapters.equipment_modelTableAdapter equipment_modelTableAdapter;
        private System.Windows.Forms.BindingSource equipmentmanufacturerBindingSource;
        private tech_specDataSet1TableAdapters.equipment_manufacturerTableAdapter equipment_manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource techspecDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private tech_specDataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource equipmentmanufacturerBindingSource1;
    }
}