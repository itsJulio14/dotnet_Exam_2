namespace Exam_2
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
            gpbSelc = new GroupBox();
            lblLugarDisp = new Label();
            lblTaller = new Label();
            cboTaller = new ComboBox();
            gpbData = new GroupBox();
            txtResp = new TextBox();
            numCant = new NumericUpDown();
            lblCantLugar = new Label();
            lblResp = new Label();
            gpbPref = new GroupBox();
            ckbReqMat = new CheckBox();
            radbtnVesp = new RadioButton();
            radbtnMat = new RadioButton();
            btnRegR = new Button();
            btnCancelarSele = new Button();
            btnLimp = new Button();
            dtagridDatos = new DataGridView();
            lblRervReg = new Label();
            lblLugOcp = new Label();
            gpbSelc.SuspendLayout();
            gpbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCant).BeginInit();
            gpbPref.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtagridDatos).BeginInit();
            SuspendLayout();
            // 
            // gpbSelc
            // 
            gpbSelc.Controls.Add(lblLugarDisp);
            gpbSelc.Controls.Add(lblTaller);
            gpbSelc.Controls.Add(cboTaller);
            gpbSelc.Location = new Point(13, 13);
            gpbSelc.Name = "gpbSelc";
            gpbSelc.Size = new Size(298, 140);
            gpbSelc.TabIndex = 0;
            gpbSelc.TabStop = false;
            gpbSelc.Text = "1. Seleccion de taller";
            // 
            // lblLugarDisp
            // 
            lblLugarDisp.AutoSize = true;
            lblLugarDisp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLugarDisp.ForeColor = Color.Teal;
            lblLugarDisp.Location = new Point(14, 90);
            lblLugarDisp.Name = "lblLugarDisp";
            lblLugarDisp.Size = new Size(195, 23);
            lblLugarDisp.TabIndex = 2;
            lblLugarDisp.Text = "Lugares Disponibles : 0";
            // 
            // lblTaller
            // 
            lblTaller.AutoSize = true;
            lblTaller.Location = new Point(14, 26);
            lblTaller.Name = "lblTaller";
            lblTaller.Size = new Size(44, 20);
            lblTaller.TabIndex = 1;
            lblTaller.Text = "Taller";
            // 
            // cboTaller
            // 
            cboTaller.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTaller.FormattingEnabled = true;
            cboTaller.Location = new Point(6, 49);
            cboTaller.Name = "cboTaller";
            cboTaller.Size = new Size(214, 28);
            cboTaller.TabIndex = 0;
            // 
            // gpbData
            // 
            gpbData.Controls.Add(txtResp);
            gpbData.Controls.Add(numCant);
            gpbData.Controls.Add(lblCantLugar);
            gpbData.Controls.Add(lblResp);
            gpbData.Location = new Point(336, 12);
            gpbData.Name = "gpbData";
            gpbData.Size = new Size(382, 141);
            gpbData.TabIndex = 0;
            gpbData.TabStop = false;
            gpbData.Text = "2. Datos de reserva";
            // 
            // txtResp
            // 
            txtResp.Location = new Point(6, 51);
            txtResp.Name = "txtResp";
            txtResp.Size = new Size(357, 27);
            txtResp.TabIndex = 7;
            // 
            // numCant
            // 
            numCant.Location = new Point(249, 89);
            numCant.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numCant.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCant.Name = "numCant";
            numCant.Size = new Size(105, 27);
            numCant.TabIndex = 6;
            numCant.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCantLugar
            // 
            lblCantLugar.AutoSize = true;
            lblCantLugar.Location = new Point(14, 91);
            lblCantLugar.Name = "lblCantLugar";
            lblCantLugar.Size = new Size(142, 20);
            lblCantLugar.TabIndex = 5;
            lblCantLugar.Text = "Cantidad de lugares";
            // 
            // lblResp
            // 
            lblResp.AutoSize = true;
            lblResp.Location = new Point(14, 27);
            lblResp.Name = "lblResp";
            lblResp.Size = new Size(93, 20);
            lblResp.TabIndex = 4;
            lblResp.Text = "Responsable";
            // 
            // gpbPref
            // 
            gpbPref.Controls.Add(ckbReqMat);
            gpbPref.Controls.Add(radbtnVesp);
            gpbPref.Controls.Add(radbtnMat);
            gpbPref.Location = new Point(749, 12);
            gpbPref.Name = "gpbPref";
            gpbPref.Size = new Size(284, 141);
            gpbPref.TabIndex = 1;
            gpbPref.TabStop = false;
            gpbPref.Text = "3. Preferencias";
            // 
            // ckbReqMat
            // 
            ckbReqMat.AutoSize = true;
            ckbReqMat.Location = new Point(80, 87);
            ckbReqMat.Name = "ckbReqMat";
            ckbReqMat.Size = new Size(149, 24);
            ckbReqMat.TabIndex = 2;
            ckbReqMat.Text = "Requiere Material";
            ckbReqMat.UseVisualStyleBackColor = true;
            // 
            // radbtnVesp
            // 
            radbtnVesp.AutoSize = true;
            radbtnVesp.Location = new Point(149, 27);
            radbtnVesp.Name = "radbtnVesp";
            radbtnVesp.Size = new Size(100, 24);
            radbtnVesp.TabIndex = 1;
            radbtnVesp.TabStop = true;
            radbtnVesp.Text = "Vespertino";
            radbtnVesp.UseVisualStyleBackColor = true;
            // 
            // radbtnMat
            // 
            radbtnMat.AutoSize = true;
            radbtnMat.Location = new Point(6, 27);
            radbtnMat.Name = "radbtnMat";
            radbtnMat.Size = new Size(90, 24);
            radbtnMat.TabIndex = 0;
            radbtnMat.TabStop = true;
            radbtnMat.Text = "matutino";
            radbtnMat.UseVisualStyleBackColor = true;
            // 
            // btnRegR
            // 
            btnRegR.Location = new Point(19, 173);
            btnRegR.Name = "btnRegR";
            btnRegR.Size = new Size(203, 45);
            btnRegR.TabIndex = 3;
            btnRegR.Text = "Registrar Reserva";
            btnRegR.UseVisualStyleBackColor = true;
            btnRegR.Click += btnRegR_Click;
            // 
            // btnCancelarSele
            // 
            btnCancelarSele.Location = new Point(257, 173);
            btnCancelarSele.Name = "btnCancelarSele";
            btnCancelarSele.Size = new Size(203, 45);
            btnCancelarSele.TabIndex = 4;
            btnCancelarSele.Text = "Cancelar Seleccion";
            btnCancelarSele.UseVisualStyleBackColor = true;
            btnCancelarSele.Click += btnCancelarSele_Click;
            // 
            // btnLimp
            // 
            btnLimp.Location = new Point(496, 173);
            btnLimp.Name = "btnLimp";
            btnLimp.Size = new Size(203, 45);
            btnLimp.TabIndex = 5;
            btnLimp.Text = "Limpiar Reserva";
            btnLimp.UseVisualStyleBackColor = true;
            btnLimp.Click += btnLimp_Click;
            // 
            // dtagridDatos
            // 
            dtagridDatos.AllowUserToAddRows = false;
            dtagridDatos.AllowUserToDeleteRows = false;
            dtagridDatos.AllowUserToResizeColumns = false;
            dtagridDatos.AllowUserToResizeRows = false;
            dtagridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtagridDatos.Location = new Point(27, 250);
            dtagridDatos.Name = "dtagridDatos";
            dtagridDatos.ReadOnly = true;
            dtagridDatos.RowHeadersWidth = 51;
            dtagridDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtagridDatos.Size = new Size(1006, 303);
            dtagridDatos.TabIndex = 6;
            // 
            // lblRervReg
            // 
            lblRervReg.AutoSize = true;
            lblRervReg.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRervReg.ForeColor = Color.Teal;
            lblRervReg.Location = new Point(27, 598);
            lblRervReg.Name = "lblRervReg";
            lblRervReg.Size = new Size(197, 23);
            lblRervReg.TabIndex = 3;
            lblRervReg.Text = "Reservas Registradas: 0";
            // 
            // lblLugOcp
            // 
            lblLugOcp.AutoSize = true;
            lblLugOcp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLugOcp.ForeColor = Color.Teal;
            lblLugOcp.Location = new Point(438, 598);
            lblLugOcp.Name = "lblLugOcp";
            lblLugOcp.Size = new Size(176, 23);
            lblLugOcp.TabIndex = 7;
            lblLugOcp.Text = "Lugares Ocupados: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 655);
            Controls.Add(lblLugOcp);
            Controls.Add(lblRervReg);
            Controls.Add(dtagridDatos);
            Controls.Add(btnLimp);
            Controls.Add(btnCancelarSele);
            Controls.Add(btnRegR);
            Controls.Add(gpbPref);
            Controls.Add(gpbData);
            Controls.Add(gpbSelc);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Examen 2";
            gpbSelc.ResumeLayout(false);
            gpbSelc.PerformLayout();
            gpbData.ResumeLayout(false);
            gpbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCant).EndInit();
            gpbPref.ResumeLayout(false);
            gpbPref.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtagridDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbSelc;
        private GroupBox gpbData;
        private GroupBox gpbPref;
        private Label lblLugarDisp;
        private Label lblTaller;
        private ComboBox cboTaller;
        private Label lblResp;
        private NumericUpDown numCant;
        private Label lblCantLugar;
        private RadioButton radbtnMat;
        private RadioButton radbtnVesp;
        private CheckBox ckbReqMat;
        private Button btnRegR;
        private Button btnCancelarSele;
        private Button btnLimp;
        private DataGridView dtagridDatos;
        private Label lblRervReg;
        private Label lblLugOcp;
        private TextBox txtResp;
    }
}
