namespace Examen_1__23130579
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialogExamen = new OpenFileDialog();
            dgvDatos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAbrir = new Button();
            dgvCalculo = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalculo).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogExamen
            // 
            openFileDialogExamen.FileName = "openFileDialogExamen";
            openFileDialogExamen.Filter = "ArchivoCSV|*.csv";
            openFileDialogExamen.FileOk += openFileDialogExamen_FileOk;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(3, 3);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(464, 360);
            dgvDatos.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "CURP";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 270;
            // 
            // Column2
            // 
            Column2.HeaderText = "Promedio";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvDatos, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAbrir, 0, 1);
            tableLayoutPanel1.Location = new Point(22, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.87154F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1284637F));
            tableLayoutPanel1.Size = new Size(470, 442);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAbrir
            // 
            btnAbrir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAbrir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbrir.Location = new Point(3, 381);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(464, 45);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "Abrir Archivo de Texto";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnCalcular_Click;
            // 
            // dgvCalculo
            // 
            dgvCalculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalculo.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4 });
            dgvCalculo.Location = new Point(3, 3);
            dgvCalculo.Name = "dgvCalculo";
            dgvCalculo.RowHeadersWidth = 51;
            dgvCalculo.Size = new Size(338, 357);
            dgvCalculo.TabIndex = 2;
            // 
            // Column3
            // 
            Column3.HeaderText = "Edad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Sexo";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgvCalculo, 0, 0);
            tableLayoutPanel2.Location = new Point(495, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(344, 363);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 564);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCalculo).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogExamen;
        private DataGridView dgvDatos;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAbrir;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView dgvCalculo;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
