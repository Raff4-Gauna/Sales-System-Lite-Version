namespace SistemaVentaLite
{
    partial class frmBackup
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
            this.btnRespaldo = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeleccionarUbi = new System.Windows.Forms.TextBox();
            this.btnSeleccionarUbic = new FontAwesome.Sharp.IconButton();
            this.bntRestaurar = new FontAwesome.Sharp.IconButton();
            this.txtUbicacionActual = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRespaldo
            // 
            this.btnRespaldo.BackColor = System.Drawing.Color.Wheat;
            this.btnRespaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespaldo.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnRespaldo.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnRespaldo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRespaldo.IconSize = 40;
            this.btnRespaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRespaldo.Location = new System.Drawing.Point(48, 60);
            this.btnRespaldo.Name = "btnRespaldo";
            this.btnRespaldo.Size = new System.Drawing.Size(223, 43);
            this.btnRespaldo.TabIndex = 1;
            this.btnRespaldo.Text = "Generar un Respaldo DB";
            this.btnRespaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRespaldo.UseVisualStyleBackColor = false;
            this.btnRespaldo.Click += new System.EventHandler(this.btnRespaldo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacene una copia de seguridad primeramente.";
            // 
            // txtSeleccionarUbi
            // 
            this.txtSeleccionarUbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeleccionarUbi.Location = new System.Drawing.Point(6, 60);
            this.txtSeleccionarUbi.Name = "txtSeleccionarUbi";
            this.txtSeleccionarUbi.Size = new System.Drawing.Size(318, 22);
            this.txtSeleccionarUbi.TabIndex = 6;
            this.txtSeleccionarUbi.TextChanged += new System.EventHandler(this.txtSeleccionarUbi_TextChanged);
            // 
            // btnSeleccionarUbic
            // 
            this.btnSeleccionarUbic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSeleccionarUbic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarUbic.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.btnSeleccionarUbic.IconColor = System.Drawing.Color.Black;
            this.btnSeleccionarUbic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionarUbic.IconSize = 40;
            this.btnSeleccionarUbic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarUbic.Location = new System.Drawing.Point(345, 49);
            this.btnSeleccionarUbic.Name = "btnSeleccionarUbic";
            this.btnSeleccionarUbic.Size = new System.Drawing.Size(173, 43);
            this.btnSeleccionarUbic.TabIndex = 2;
            this.btnSeleccionarUbic.Text = "Buscar Copia DB";
            this.btnSeleccionarUbic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionarUbic.UseVisualStyleBackColor = false;
            this.btnSeleccionarUbic.Click += new System.EventHandler(this.btnSeleccionarUbic_Click);
            // 
            // bntRestaurar
            // 
            this.bntRestaurar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRestaurar.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.bntRestaurar.IconColor = System.Drawing.Color.Black;
            this.bntRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntRestaurar.IconSize = 40;
            this.bntRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntRestaurar.Location = new System.Drawing.Point(534, 49);
            this.bntRestaurar.Name = "bntRestaurar";
            this.bntRestaurar.Size = new System.Drawing.Size(173, 43);
            this.bntRestaurar.TabIndex = 3;
            this.bntRestaurar.Text = "Restaurar Datos";
            this.bntRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntRestaurar.UseVisualStyleBackColor = false;
            this.bntRestaurar.Click += new System.EventHandler(this.bntRestaurar_Click);
            // 
            // txtUbicacionActual
            // 
            this.txtUbicacionActual.Location = new System.Drawing.Point(6, 88);
            this.txtUbicacionActual.Name = "txtUbicacionActual";
            this.txtUbicacionActual.Size = new System.Drawing.Size(318, 22);
            this.txtUbicacionActual.TabIndex = 7;
            this.txtUbicacionActual.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSeleccionarUbi);
            this.groupBox2.Controls.Add(this.btnSeleccionarUbic);
            this.groupBox2.Controls.Add(this.bntRestaurar);
            this.groupBox2.Controls.Add(this.txtUbicacionActual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(528, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 132);
            this.groupBox2.TabIndex = 219;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insertar Copias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Introduzca una copia generada anteriormente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnRespaldo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(121, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 132);
            this.groupBox1.TabIndex = 218;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guardar Datos";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(-227, -2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1773, 21);
            this.label10.TabIndex = 221;
            this.label10.Text = "Backup de la Base de Datos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 671);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Name = "frmBackup";
            this.Text = "frmBackup";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRespaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeleccionarUbi;
        private FontAwesome.Sharp.IconButton btnSeleccionarUbic;
        private FontAwesome.Sharp.IconButton bntRestaurar;
        private System.Windows.Forms.TextBox txtUbicacionActual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
    }
}