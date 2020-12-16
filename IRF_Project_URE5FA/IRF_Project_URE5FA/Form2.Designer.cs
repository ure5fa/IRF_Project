namespace IRF_Project_URE5FA
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EmberTextBox = new System.Windows.Forms.TextBox();
            this.EmberListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etelekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet11 = new IRF_Project_URE5FA.Database1DataSet11();
            this.emberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet10 = new IRF_Project_URE5FA.Database1DataSet10();
            this.emberTableAdapter = new IRF_Project_URE5FA.Database1DataSet10TableAdapters.EmberTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.etelekTableAdapter = new IRF_Project_URE5FA.Database1DataSet11TableAdapters.EtelekTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etelekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmberTextBox
            // 
            this.EmberTextBox.Location = new System.Drawing.Point(12, 38);
            this.EmberTextBox.Name = "EmberTextBox";
            this.EmberTextBox.Size = new System.Drawing.Size(156, 22);
            this.EmberTextBox.TabIndex = 0;
            this.EmberTextBox.TextChanged += new System.EventHandler(this.EmberTextBox_TextChanged);
            this.EmberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EmberTextBox_Validating);
            // 
            // EmberListBox
            // 
            this.EmberListBox.FormattingEnabled = true;
            this.EmberListBox.ItemHeight = 16;
            this.EmberListBox.Location = new System.Drawing.Point(12, 66);
            this.EmberListBox.Name = "EmberListBox";
            this.EmberListBox.Size = new System.Drawing.Size(156, 308);
            this.EmberListBox.TabIndex = 1;
            this.EmberListBox.SelectedIndexChanged += new System.EventHandler(this.EmberListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Írj be egy nevet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nevDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etelekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(174, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 300);
            this.dataGridView1.TabIndex = 5;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            this.nevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            this.nevDataGridViewTextBoxColumn.Width = 125;
            // 
            // etelekBindingSource
            // 
            this.etelekBindingSource.DataMember = "Etelek";
            this.etelekBindingSource.DataSource = this.database1DataSet11;
            // 
            // database1DataSet11
            // 
            this.database1DataSet11.DataSetName = "Database1DataSet11";
            this.database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emberBindingSource
            // 
            this.emberBindingSource.DataMember = "Ember";
            this.emberBindingSource.DataSource = this.database1DataSet10;
            // 
            // database1DataSet10
            // 
            this.database1DataSet10.DataSetName = "Database1DataSet10";
            this.database1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emberTableAdapter
            // 
            this.emberTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(184, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vissza az előző oldalra";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Location = new System.Drawing.Point(351, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Program bezárása";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // etelekTableAdapter
            // 
            this.etelekTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(716, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ezen az oldalon különböző emberek étkezési szokásait tudjuk megtekinteni";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(519, 66);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(569, 300);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(15, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 49);
            this.button3.TabIndex = 17;
            this.button3.Text = "Fájlba írás";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(986, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 49);
            this.button4.TabIndex = 18;
            this.button4.Text = "Ha unatkozol kattints ide";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmberListBox);
            this.Controls.Add(this.EmberTextBox);
            this.Name = "Form2";
            this.Text = "Evési szokások";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etelekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmberTextBox;
        private System.Windows.Forms.ListBox EmberListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet10 database1DataSet10;
        private System.Windows.Forms.BindingSource emberBindingSource;
        private Database1DataSet10TableAdapters.EmberTableAdapter emberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Database1DataSet11 database1DataSet11;
        private System.Windows.Forms.BindingSource etelekBindingSource;
        private Database1DataSet11TableAdapters.EtelekTableAdapter etelekTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button4;
    }
}