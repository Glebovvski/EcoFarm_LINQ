namespace EcoFarm_LINQ
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ecoFarm_DBDataSet = new EcoFarm_LINQ.EcoFarm_DBDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new EcoFarm_LINQ.EcoFarm_DBDataSetTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager = new EcoFarm_LINQ.EcoFarm_DBDataSetTableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierCB = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductsCB = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.MinPriceSupplier = new System.Windows.Forms.Label();
            this.MaxPriceSupplier = new System.Windows.Forms.Label();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AverageTB = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoFarm_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select invoice by date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "End";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(58, 54);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // ecoFarm_DBDataSet
            // 
            this.ecoFarm_DBDataSet.DataSetName = "EcoFarm_DBDataSet";
            this.ecoFarm_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.ecoFarm_DBDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Invoice_productsTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.UpdateOrder = EcoFarm_LINQ.EcoFarm_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier:";
            // 
            // SupplierCB
            // 
            this.SupplierCB.FormattingEnabled = true;
            this.SupplierCB.Location = new System.Drawing.Point(84, 118);
            this.SupplierCB.Name = "SupplierCB";
            this.SupplierCB.Size = new System.Drawing.Size(121, 24);
            this.SupplierCB.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Select supplier\'s products";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product:";
            // 
            // ProductsCB
            // 
            this.ProductsCB.FormattingEnabled = true;
            this.ProductsCB.Location = new System.Drawing.Point(563, 29);
            this.ProductsCB.Name = "ProductsCB";
            this.ProductsCB.Size = new System.Drawing.Size(121, 24);
            this.ProductsCB.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 47);
            this.button3.TabIndex = 12;
            this.button3.Text = "Min, Max and Average price by Suppliers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Min price: ";
            // 
            // MinTB
            // 
            this.MinTB.Location = new System.Drawing.Point(785, 99);
            this.MinTB.Name = "MinTB";
            this.MinTB.Size = new System.Drawing.Size(100, 22);
            this.MinTB.TabIndex = 14;
            // 
            // MinPriceSupplier
            // 
            this.MinPriceSupplier.AutoSize = true;
            this.MinPriceSupplier.Location = new System.Drawing.Point(891, 102);
            this.MinPriceSupplier.Name = "MinPriceSupplier";
            this.MinPriceSupplier.Size = new System.Drawing.Size(0, 17);
            this.MinPriceSupplier.TabIndex = 15;
            // 
            // MaxPriceSupplier
            // 
            this.MaxPriceSupplier.AutoSize = true;
            this.MaxPriceSupplier.Location = new System.Drawing.Point(891, 139);
            this.MaxPriceSupplier.Name = "MaxPriceSupplier";
            this.MaxPriceSupplier.Size = new System.Drawing.Size(0, 17);
            this.MaxPriceSupplier.TabIndex = 18;
            // 
            // MaxTB
            // 
            this.MaxTB.Location = new System.Drawing.Point(785, 136);
            this.MaxTB.Name = "MaxTB";
            this.MaxTB.Size = new System.Drawing.Size(100, 22);
            this.MaxTB.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Max price: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Average: ";
            // 
            // AverageTB
            // 
            this.AverageTB.Location = new System.Drawing.Point(785, 169);
            this.AverageTB.Name = "AverageTB";
            this.AverageTB.Size = new System.Drawing.Size(100, 22);
            this.AverageTB.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(499, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 31);
            this.button4.TabIndex = 21;
            this.button4.Text = "Show all products";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(499, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 26);
            this.button5.TabIndex = 22;
            this.button5.Text = "Check delivery dates";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 560);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AverageTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaxPriceSupplier);
            this.Controls.Add(this.MaxTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinPriceSupplier);
            this.Controls.Add(this.MinTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProductsCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SupplierCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoFarm_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private EcoFarm_DBDataSet ecoFarm_DBDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private EcoFarm_DBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private EcoFarm_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SupplierCB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProductsCB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MinTB;
        private System.Windows.Forms.Label MinPriceSupplier;
        private System.Windows.Forms.Label MaxPriceSupplier;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AverageTB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

