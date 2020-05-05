namespace EjercicioUI
{
    partial class FrmConsultar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCanTodos = new System.Windows.Forms.TextBox();
            this.txtTotalTodos = new System.Windows.Forms.TextBox();
            this.txtCanRC = new System.Windows.Forms.TextBox();
            this.txtTotalRC = new System.Windows.Forms.TextBox();
            this.txtCantRS = new System.Windows.Forms.TextBox();
            this.txtTotalRS = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.DTPFinal = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Total";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Location = new System.Drawing.Point(622, 42);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 75);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Todos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Regimen Contributivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Regimen Subsidiado";
            // 
            // txtCanTodos
            // 
            this.txtCanTodos.Location = new System.Drawing.Point(164, 360);
            this.txtCanTodos.Name = "txtCanTodos";
            this.txtCanTodos.Size = new System.Drawing.Size(150, 20);
            this.txtCanTodos.TabIndex = 11;
            // 
            // txtTotalTodos
            // 
            this.txtTotalTodos.Location = new System.Drawing.Point(164, 388);
            this.txtTotalTodos.Name = "txtTotalTodos";
            this.txtTotalTodos.Size = new System.Drawing.Size(150, 20);
            this.txtTotalTodos.TabIndex = 12;
            // 
            // txtCanRC
            // 
            this.txtCanRC.Location = new System.Drawing.Point(387, 360);
            this.txtCanRC.Name = "txtCanRC";
            this.txtCanRC.Size = new System.Drawing.Size(132, 20);
            this.txtCanRC.TabIndex = 13;
            // 
            // txtTotalRC
            // 
            this.txtTotalRC.Location = new System.Drawing.Point(387, 388);
            this.txtTotalRC.Name = "txtTotalRC";
            this.txtTotalRC.Size = new System.Drawing.Size(132, 20);
            this.txtTotalRC.TabIndex = 14;
            // 
            // txtCantRS
            // 
            this.txtCantRS.Location = new System.Drawing.Point(592, 360);
            this.txtCantRS.Name = "txtCantRS";
            this.txtCantRS.Size = new System.Drawing.Size(138, 20);
            this.txtCantRS.TabIndex = 15;
            // 
            // txtTotalRS
            // 
            this.txtTotalRS.Location = new System.Drawing.Point(592, 388);
            this.txtTotalRS.Name = "txtTotalRS";
            this.txtTotalRS.Size = new System.Drawing.Size(138, 20);
            this.txtTotalRS.TabIndex = 16;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "TODOS",
            "SUBSIDIADO",
            "CONTRIBUTIVO"});
            this.cmbTipo.Location = new System.Drawing.Point(495, 45);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // DTPInicio
            // 
            this.DTPInicio.Location = new System.Drawing.Point(495, 71);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(121, 20);
            this.DTPInicio.TabIndex = 20;
            // 
            // DTPFinal
            // 
            this.DTPFinal.Location = new System.Drawing.Point(495, 96);
            this.DTPFinal.Name = "DTPFinal";
            this.DTPFinal.Size = new System.Drawing.Size(121, 20);
            this.DTPFinal.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha Final:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Digite Nombre A buscar";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(622, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tipo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(693, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fecha";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTPFinal);
            this.Controls.Add(this.DTPInicio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtTotalRS);
            this.Controls.Add(this.txtCantRS);
            this.Controls.Add(this.txtTotalRC);
            this.Controls.Add(this.txtCanRC);
            this.Controls.Add(this.txtTotalTodos);
            this.Controls.Add(this.txtCanTodos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmConsultar";
            this.Text = "FrmConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCanTodos;
        private System.Windows.Forms.TextBox txtTotalTodos;
        private System.Windows.Forms.TextBox txtCanRC;
        private System.Windows.Forms.TextBox txtTotalRC;
        private System.Windows.Forms.TextBox txtCantRS;
        private System.Windows.Forms.TextBox txtTotalRS;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.DateTimePicker DTPFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}