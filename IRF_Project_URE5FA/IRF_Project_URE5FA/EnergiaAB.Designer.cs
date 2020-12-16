namespace IRF_Project_URE5FA
{
    partial class EnergiaAB
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.energiaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kCALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telitettzsirsavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szenhidratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cukorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feherjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zsirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet4 = new IRF_Project_URE5FA.Database1DataSet4();
            this.energiaTableAdapter = new IRF_Project_URE5FA.Database1DataSet4TableAdapters.EnergiaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.EtelTextBox = new System.Windows.Forms.TextBox();
            this.EtelListbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.energiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.energiaIDDataGridViewTextBoxColumn,
            this.kCALDataGridViewTextBoxColumn,
            this.telitettzsirsavDataGridViewTextBoxColumn,
            this.szenhidratDataGridViewTextBoxColumn,
            this.cukorDataGridViewTextBoxColumn,
            this.feherjeDataGridViewTextBoxColumn,
            this.soDataGridViewTextBoxColumn,
            this.zsirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.energiaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(148, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 214);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // energiaIDDataGridViewTextBoxColumn
            // 
            this.energiaIDDataGridViewTextBoxColumn.DataPropertyName = "EnergiaID";
            this.energiaIDDataGridViewTextBoxColumn.HeaderText = "EnergiaID";
            this.energiaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.energiaIDDataGridViewTextBoxColumn.Name = "energiaIDDataGridViewTextBoxColumn";
            this.energiaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kCALDataGridViewTextBoxColumn
            // 
            this.kCALDataGridViewTextBoxColumn.DataPropertyName = "KCAL";
            this.kCALDataGridViewTextBoxColumn.HeaderText = "KCAL";
            this.kCALDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kCALDataGridViewTextBoxColumn.Name = "kCALDataGridViewTextBoxColumn";
            this.kCALDataGridViewTextBoxColumn.Width = 125;
            // 
            // telitettzsirsavDataGridViewTextBoxColumn
            // 
            this.telitettzsirsavDataGridViewTextBoxColumn.DataPropertyName = "telitett_zsirsav";
            this.telitettzsirsavDataGridViewTextBoxColumn.HeaderText = "telitett_zsirsav";
            this.telitettzsirsavDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telitettzsirsavDataGridViewTextBoxColumn.Name = "telitettzsirsavDataGridViewTextBoxColumn";
            this.telitettzsirsavDataGridViewTextBoxColumn.Width = 125;
            // 
            // szenhidratDataGridViewTextBoxColumn
            // 
            this.szenhidratDataGridViewTextBoxColumn.DataPropertyName = "szenhidrat";
            this.szenhidratDataGridViewTextBoxColumn.HeaderText = "szenhidrat";
            this.szenhidratDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.szenhidratDataGridViewTextBoxColumn.Name = "szenhidratDataGridViewTextBoxColumn";
            this.szenhidratDataGridViewTextBoxColumn.Width = 125;
            // 
            // cukorDataGridViewTextBoxColumn
            // 
            this.cukorDataGridViewTextBoxColumn.DataPropertyName = "cukor";
            this.cukorDataGridViewTextBoxColumn.HeaderText = "cukor";
            this.cukorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cukorDataGridViewTextBoxColumn.Name = "cukorDataGridViewTextBoxColumn";
            this.cukorDataGridViewTextBoxColumn.Width = 125;
            // 
            // feherjeDataGridViewTextBoxColumn
            // 
            this.feherjeDataGridViewTextBoxColumn.DataPropertyName = "feherje";
            this.feherjeDataGridViewTextBoxColumn.HeaderText = "feherje";
            this.feherjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feherjeDataGridViewTextBoxColumn.Name = "feherjeDataGridViewTextBoxColumn";
            this.feherjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDataGridViewTextBoxColumn
            // 
            this.soDataGridViewTextBoxColumn.DataPropertyName = "so";
            this.soDataGridViewTextBoxColumn.HeaderText = "so";
            this.soDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDataGridViewTextBoxColumn.Name = "soDataGridViewTextBoxColumn";
            this.soDataGridViewTextBoxColumn.Width = 125;
            // 
            // zsirDataGridViewTextBoxColumn
            // 
            this.zsirDataGridViewTextBoxColumn.DataPropertyName = "zsir";
            this.zsirDataGridViewTextBoxColumn.HeaderText = "zsir";
            this.zsirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zsirDataGridViewTextBoxColumn.Name = "zsirDataGridViewTextBoxColumn";
            this.zsirDataGridViewTextBoxColumn.Width = 125;
            // 
            // energiaBindingSource
            // 
            this.energiaBindingSource.DataMember = "Energia";
            this.energiaBindingSource.DataSource = this.database1DataSet4;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // energiaTableAdapter
            // 
            this.energiaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ide írd az étel nevét";
            // 
            // EtelTextBox
            // 
            this.EtelTextBox.Location = new System.Drawing.Point(12, 90);
            this.EtelTextBox.Name = "EtelTextBox";
            this.EtelTextBox.Size = new System.Drawing.Size(124, 22);
            this.EtelTextBox.TabIndex = 3;
            this.EtelTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.EtelTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EtelTextBox_Validating);
            // 
            // EtelListbox
            // 
            this.EtelListbox.FormattingEnabled = true;
            this.EtelListbox.ItemHeight = 16;
            this.EtelListbox.Location = new System.Drawing.Point(12, 118);
            this.EtelListbox.Name = "EtelListbox";
            this.EtelListbox.Size = new System.Drawing.Size(124, 260);
            this.EtelListbox.TabIndex = 4;
            this.EtelListbox.SelectedIndexChanged += new System.EventHandler(this.EtelListbox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(-1, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fájlba írás";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(2, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Következő oldal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SandyBrown;
            this.button3.Location = new System.Drawing.Point(2, 558);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "Program bezárása";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(160, 330);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1054, 117);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(160, 489);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(1054, 122);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "A választott étel szénhidrát mennyisége";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "A választott étel zsírtartalma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(698, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ezen az oldalon különböző ételek tartalmát, összetevőit tekinthetjük meg.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(561, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kérlek a baloldali TextBoxba írd be a kiválasztott étel nevét";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EnergiaAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EtelListbox);
            this.Controls.Add(this.EtelTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EnergiaAB";
            this.Text = "EnergiaAB";
            this.Load += new System.EventHandler(this.EnergiaAB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.energiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource energiaBindingSource;
        private Database1DataSet4TableAdapters.EnergiaTableAdapter energiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kCALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telitettzsirsavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szenhidratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cukorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feherjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zsirDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EtelTextBox;
        private System.Windows.Forms.ListBox EtelListbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

