namespace Connection_Oriented_Model
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_preview = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.CmpName = new System.Windows.Forms.Label();
            this.REVENUE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCmpName = new System.Windows.Forms.TextBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.AccessibleName = "";
            this.bt_add.Location = new System.Drawing.Point(24, 163);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(125, 163);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 1;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(232, 163);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_preview
            // 
            this.bt_preview.Location = new System.Drawing.Point(332, 163);
            this.bt_preview.Name = "bt_preview";
            this.bt_preview.Size = new System.Drawing.Size(75, 23);
            this.bt_preview.TabIndex = 3;
            this.bt_preview.Text = "Preview";
            this.bt_preview.UseVisualStyleBackColor = true;
            this.bt_preview.Click += new System.EventHandler(this.bt_preview_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(399, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CmpName
            // 
            this.CmpName.AutoSize = true;
            this.CmpName.Location = new System.Drawing.Point(21, 49);
            this.CmpName.Name = "CmpName";
            this.CmpName.Size = new System.Drawing.Size(82, 13);
            this.CmpName.TabIndex = 5;
            this.CmpName.Text = "Company Name";
            this.CmpName.Click += new System.EventHandler(this.txtCmpName_Click);
            // 
            // REVENUE
            // 
            this.REVENUE.AutoSize = true;
            this.REVENUE.Location = new System.Drawing.Point(21, 96);
            this.REVENUE.Name = "REVENUE";
            this.REVENUE.Size = new System.Drawing.Size(59, 13);
            this.REVENUE.TabIndex = 6;
            this.REVENUE.Text = "Revenues:";
            this.REVENUE.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Company Revenues - 2017";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(282, 205);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(239, 150);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // txtCmpName
            // 
            this.txtCmpName.Location = new System.Drawing.Point(146, 42);
            this.txtCmpName.Name = "txtCmpName";
            this.txtCmpName.Size = new System.Drawing.Size(219, 20);
            this.txtCmpName.TabIndex = 10;
            this.txtCmpName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(146, 89);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(328, 20);
            this.txtRevenue.TabIndex = 11;
            this.txtRevenue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 380);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.txtCmpName);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.REVENUE);
            this.Controls.Add(this.CmpName);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_preview);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_add);
            this.Name = "Form1";
            this.Text = "ADO.NET - Connection Oriented Object";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_preview;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label CmpName;
        private System.Windows.Forms.Label REVENUE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtCmpName;
        private System.Windows.Forms.TextBox txtRevenue;
    }
}

