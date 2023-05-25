namespace Vista
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
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.Actualizarbtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.Agregarbtn = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.NombreTb = new System.Windows.Forms.TextBox();
            this.DescripcionTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Location = new System.Drawing.Point(99, 64);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(94, 29);
            this.ConsultarBtn.TabIndex = 0;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // Actualizarbtn
            // 
            this.Actualizarbtn.Location = new System.Drawing.Point(390, 184);
            this.Actualizarbtn.Name = "Actualizarbtn";
            this.Actualizarbtn.Size = new System.Drawing.Size(94, 29);
            this.Actualizarbtn.TabIndex = 1;
            this.Actualizarbtn.Text = "Actualizar";
            this.Actualizarbtn.UseVisualStyleBackColor = true;
            this.Actualizarbtn.Click += new System.EventHandler(this.Actualizarbtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(390, 128);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(94, 29);
            this.EliminarBtn.TabIndex = 2;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Location = new System.Drawing.Point(390, 64);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(94, 29);
            this.Agregarbtn.TabIndex = 3;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(99, 250);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 29;
            this.Grid.Size = new System.Drawing.Size(581, 279);
            this.Grid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion";
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(813, 64);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(125, 27);
            this.IdTb.TabIndex = 8;
            // 
            // NombreTb
            // 
            this.NombreTb.Location = new System.Drawing.Point(813, 107);
            this.NombreTb.Name = "NombreTb";
            this.NombreTb.Size = new System.Drawing.Size(125, 27);
            this.NombreTb.TabIndex = 9;
            // 
            // DescripcionTb
            // 
            this.DescripcionTb.Location = new System.Drawing.Point(813, 156);
            this.DescripcionTb.Name = "DescripcionTb";
            this.DescripcionTb.Size = new System.Drawing.Size(125, 27);
            this.DescripcionTb.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 565);
            this.Controls.Add(this.DescripcionTb);
            this.Controls.Add(this.NombreTb);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Agregarbtn);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.Actualizarbtn);
            this.Controls.Add(this.ConsultarBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ConsultarBtn;
        private Button Actualizarbtn;
        private Button EliminarBtn;
        private Button Agregarbtn;
        private DataGridView Grid;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox IdTb;
        private TextBox NombreTb;
        private TextBox DescripcionTb;
    }
}