using System;

namespace IRF_Project_URE5FA
{
    partial class Diagramm
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
            this.energiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet8 = new IRF_Project_URE5FA.Database1DataSet8();
            this.database1DataSet5 = new IRF_Project_URE5FA.Database1DataSet5();
            this.etelekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etelekTableAdapter = new IRF_Project_URE5FA.Database1DataSet5TableAdapters.EtelekTableAdapter();
            this.database1DataSet6 = new IRF_Project_URE5FA.Database1DataSet6();
            this.kategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriaTableAdapter = new IRF_Project_URE5FA.Database1DataSet6TableAdapters.KategoriaTableAdapter();
            this.database1DataSet7 = new IRF_Project_URE5FA.Database1DataSet7();
            this.kategoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriaTableAdapter1 = new IRF_Project_URE5FA.Database1DataSet7TableAdapters.KategoriaTableAdapter();
            this.energiaTableAdapter = new IRF_Project_URE5FA.Database1DataSet8TableAdapters.EnergiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.energiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etelekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(15, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vissza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Location = new System.Drawing.Point(1357, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Program bezárása";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // energiaBindingSource
            // 
            this.energiaBindingSource.DataMember = "Energia";
            this.energiaBindingSource.DataSource = this.database1DataSet8;
            // 
            // database1DataSet8
            // 
            this.database1DataSet8.DataSetName = "Database1DataSet8";
            this.database1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etelekBindingSource
            // 
            this.etelekBindingSource.DataMember = "Etelek";
            this.etelekBindingSource.DataSource = this.database1DataSet5;
            // 
            // etelekTableAdapter
            // 
            this.etelekTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet6
            // 
            this.database1DataSet6.DataSetName = "Database1DataSet6";
            this.database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriaBindingSource
            // 
            this.kategoriaBindingSource.DataMember = "Kategoria";
            this.kategoriaBindingSource.DataSource = this.database1DataSet6;
            // 
            // kategoriaTableAdapter
            // 
            this.kategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet7
            // 
            this.database1DataSet7.DataSetName = "Database1DataSet7";
            this.database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriaBindingSource1
            // 
            this.kategoriaBindingSource1.DataMember = "Kategoria";
            this.kategoriaBindingSource1.DataSource = this.database1DataSet7;
            // 
            // kategoriaTableAdapter1
            // 
            this.kategoriaTableAdapter1.ClearBeforeFill = true;
            // 
            // energiaTableAdapter
            // 
            this.energiaTableAdapter.ClearBeforeFill = true;
            // 
            // Diagramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 512);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Diagramm";
            this.Text = "Diagramm";
            this.Load += new System.EventHandler(this.Diagramm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.energiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etelekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Diagramm_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource etelekBindingSource;
        private Database1DataSet5TableAdapters.EtelekTableAdapter etelekTableAdapter;
        private Database1DataSet6 database1DataSet6;
        private System.Windows.Forms.BindingSource kategoriaBindingSource;
        private Database1DataSet6TableAdapters.KategoriaTableAdapter kategoriaTableAdapter;
        private Database1DataSet7 database1DataSet7;
        private System.Windows.Forms.BindingSource kategoriaBindingSource1;
        private Database1DataSet7TableAdapters.KategoriaTableAdapter kategoriaTableAdapter1;
        private Database1DataSet8 database1DataSet8;
        private System.Windows.Forms.BindingSource energiaBindingSource;
        private Database1DataSet8TableAdapters.EnergiaTableAdapter energiaTableAdapter;
    }
}