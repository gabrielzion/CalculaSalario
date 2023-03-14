namespace WinFormsApp1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtBoxSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtBoxValorIR = new System.Windows.Forms.TextBox();
            this.txtBoxSalarioBase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.txtBoxDias = new System.Windows.Forms.TextBox();
            this.txtBoxCpf = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(277, 297);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(286, 86);
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // txtBoxSalarioLiquido
            // 
            this.txtBoxSalarioLiquido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxSalarioLiquido.Location = new System.Drawing.Point(626, 158);
            this.txtBoxSalarioLiquido.Name = "txtBoxSalarioLiquido";
            this.txtBoxSalarioLiquido.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSalarioLiquido.TabIndex = 27;
            // 
            // txtBoxValorIR
            // 
            this.txtBoxValorIR.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtBoxValorIR.Location = new System.Drawing.Point(626, 114);
            this.txtBoxValorIR.Name = "txtBoxValorIR";
            this.txtBoxValorIR.Size = new System.Drawing.Size(100, 23);
            this.txtBoxValorIR.TabIndex = 26;
            // 
            // txtBoxSalarioBase
            // 
            this.txtBoxSalarioBase.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtBoxSalarioBase.Location = new System.Drawing.Point(626, 70);
            this.txtBoxSalarioBase.Name = "txtBoxSalarioBase";
            this.txtBoxSalarioBase.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSalarioBase.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Salário Líquido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Valor do IR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Salário Base";
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.Location = new System.Drawing.Point(183, 197);
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.Size = new System.Drawing.Size(100, 23);
            this.txtBoxValor.TabIndex = 21;
            // 
            // txtBoxDias
            // 
            this.txtBoxDias.Location = new System.Drawing.Point(183, 153);
            this.txtBoxDias.Name = "txtBoxDias";
            this.txtBoxDias.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDias.TabIndex = 20;
            // 
            // txtBoxCpf
            // 
            this.txtBoxCpf.Location = new System.Drawing.Point(183, 109);
            this.txtBoxCpf.Name = "txtBoxCpf";
            this.txtBoxCpf.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCpf.TabIndex = 19;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(183, 67);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNome.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor diária";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Horas trabalhadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "CPF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBoxSalarioLiquido);
            this.Controls.Add(this.txtBoxValorIR);
            this.Controls.Add(this.txtBoxSalarioBase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxValor);
            this.Controls.Add(this.txtBoxDias);
            this.Controls.Add(this.txtBoxCpf);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private TextBox txtBoxSalarioLiquido;
        private TextBox txtBoxValorIR;
        private TextBox txtBoxSalarioBase;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtBoxValor;
        private TextBox txtBoxDias;
        private TextBox txtBoxCpf;
        private TextBox txtBoxNome;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}