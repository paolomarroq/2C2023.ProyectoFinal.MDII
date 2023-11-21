namespace ArbolBinario2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPadre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnPostorden = new System.Windows.Forms.Button();
            this.btnPreorden = new System.Windows.Forms.Button();
            this.btnInorden = new System.Windows.Forms.Button();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.btnCalcularNivel = new System.Windows.Forms.Button();
            this.heigthbttn = new System.Windows.Forms.Button();
            this.leafbttn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor: ";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(119, 116);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hijo de:";
            // 
            // txtPadre
            // 
            this.txtPadre.Location = new System.Drawing.Point(119, 165);
            this.txtPadre.Name = "txtPadre";
            this.txtPadre.Size = new System.Drawing.Size(100, 22);
            this.txtPadre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(76, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 27);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnPostorden
            // 
            this.btnPostorden.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostorden.Location = new System.Drawing.Point(52, 291);
            this.btnPostorden.Name = "btnPostorden";
            this.btnPostorden.Size = new System.Drawing.Size(116, 30);
            this.btnPostorden.TabIndex = 5;
            this.btnPostorden.Text = "Post-Order";
            this.btnPostorden.UseVisualStyleBackColor = true;
            this.btnPostorden.Click += new System.EventHandler(this.btnPostorden_Click);
            // 
            // btnPreorden
            // 
            this.btnPreorden.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreorden.Location = new System.Drawing.Point(295, 291);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(115, 30);
            this.btnPreorden.TabIndex = 6;
            this.btnPreorden.Text = "Pre-Order";
            this.btnPreorden.UseVisualStyleBackColor = true;
            this.btnPreorden.Click += new System.EventHandler(this.btnPreorden_Click);
            // 
            // btnInorden
            // 
            this.btnInorden.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInorden.Location = new System.Drawing.Point(174, 291);
            this.btnInorden.Name = "btnInorden";
            this.btnInorden.Size = new System.Drawing.Size(115, 30);
            this.btnInorden.TabIndex = 7;
            this.btnInorden.Text = "In-Order";
            this.btnInorden.UseVisualStyleBackColor = true;
            this.btnInorden.Click += new System.EventHandler(this.btnInorden_Click);
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(53, 352);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(270, 22);
            this.txtOrden.TabIndex = 8;
            // 
            // btnCalcularNivel
            // 
            this.btnCalcularNivel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularNivel.Location = new System.Drawing.Point(53, 401);
            this.btnCalcularNivel.Name = "btnCalcularNivel";
            this.btnCalcularNivel.Size = new System.Drawing.Size(115, 26);
            this.btnCalcularNivel.TabIndex = 9;
            this.btnCalcularNivel.Text = "Nivel";
            this.btnCalcularNivel.UseVisualStyleBackColor = true;
            this.btnCalcularNivel.Click += new System.EventHandler(this.btnCalcularNivel_Click);
            // 
            // heigthbttn
            // 
            this.heigthbttn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heigthbttn.Location = new System.Drawing.Point(174, 401);
            this.heigthbttn.Name = "heigthbttn";
            this.heigthbttn.Size = new System.Drawing.Size(115, 26);
            this.heigthbttn.TabIndex = 10;
            this.heigthbttn.Text = "Altura";
            this.heigthbttn.UseVisualStyleBackColor = true;
            this.heigthbttn.Click += new System.EventHandler(this.heightbutton_click);
            // 
            // leafbttn
            // 
            this.leafbttn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leafbttn.Location = new System.Drawing.Point(295, 401);
            this.leafbttn.Name = "leafbttn";
            this.leafbttn.Size = new System.Drawing.Size(115, 26);
            this.leafbttn.TabIndex = 11;
            this.leafbttn.Text = "Nodos Hojas";
            this.leafbttn.UseVisualStyleBackColor = true;
            this.leafbttn.Click += new System.EventHandler(this.leafbttn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(481, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "PROYECTO FINAL DISCRETA II";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.leafbttn);
            this.Controls.Add(this.heigthbttn);
            this.Controls.Add(this.btnCalcularNivel);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.btnInorden);
            this.Controls.Add(this.btnPreorden);
            this.Controls.Add(this.btnPostorden);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPadre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arbol Binario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPadre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnPostorden;
        private System.Windows.Forms.Button btnPreorden;
        private System.Windows.Forms.Button btnInorden;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Button btnCalcularNivel;
        private System.Windows.Forms.Button heigthbttn;
        private System.Windows.Forms.Button leafbttn;
        private System.Windows.Forms.Label label3;
    }
}

