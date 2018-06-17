namespace CalculadoraWindows10
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
            this.txtPainel = new System.Windows.Forms.TextBox();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnSobreX = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMaisOuMenos = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPainel
            // 
            this.txtPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPainel.Location = new System.Drawing.Point(0, 12);
            this.txtPainel.Multiline = true;
            this.txtPainel.Name = "txtPainel";
            this.txtPainel.Size = new System.Drawing.Size(263, 115);
            this.txtPainel.TabIndex = 0;
            this.txtPainel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPainel_KeyPress);
            // 
            // btnPercent
            // 
            this.btnPercent.Location = new System.Drawing.Point(0, 133);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(68, 49);
            this.btnPercent.TabIndex = 1;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(65, 133);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(68, 49);
            this.btnRaiz.TabIndex = 2;
            this.btnRaiz.Text = "Raiz";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.Location = new System.Drawing.Point(130, 133);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(68, 49);
            this.btnQuadrado.TabIndex = 3;
            this.btnQuadrado.Text = "x²";
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
            // 
            // btnSobreX
            // 
            this.btnSobreX.Location = new System.Drawing.Point(195, 133);
            this.btnSobreX.Name = "btnSobreX";
            this.btnSobreX.Size = new System.Drawing.Size(68, 49);
            this.btnSobreX.TabIndex = 4;
            this.btnSobreX.Text = "1/x";
            this.btnSobreX.UseVisualStyleBackColor = true;
            this.btnSobreX.Click += new System.EventHandler(this.btnSobreX_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(195, 179);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(68, 48);
            this.btnDividir.TabIndex = 5;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(194, 224);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(68, 48);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(195, 269);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(67, 48);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(195, 314);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(67, 48);
            this.btnSomar.TabIndex = 8;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(195, 358);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(67, 48);
            this.btnIgual.TabIndex = 9;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(0, 179);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(68, 48);
            this.btnCE.TabIndex = 10;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(65, 179);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(68, 48);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(130, 179);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(68, 48);
            this.btnApagar.TabIndex = 12;
            this.btnApagar.Text = "<-";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(0, 224);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 48);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(65, 224);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 48);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(130, 224);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(68, 48);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(0, 269);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 48);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(65, 269);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 48);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(130, 269);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 48);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(-1, 314);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 48);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(65, 314);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 48);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(130, 314);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 48);
            this.btn3.TabIndex = 21;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnMaisOuMenos
            // 
            this.btnMaisOuMenos.Location = new System.Drawing.Point(-1, 358);
            this.btnMaisOuMenos.Name = "btnMaisOuMenos";
            this.btnMaisOuMenos.Size = new System.Drawing.Size(69, 48);
            this.btnMaisOuMenos.TabIndex = 22;
            this.btnMaisOuMenos.Text = "+ -";
            this.btnMaisOuMenos.UseVisualStyleBackColor = true;
            this.btnMaisOuMenos.Click += new System.EventHandler(this.btnMaisOuMenos_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(65, 358);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(68, 48);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(130, 358);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(68, 48);
            this.btnVirgula.TabIndex = 24;
            this.btnVirgula.Text = ".";
            this.btnVirgula.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 406);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMaisOuMenos);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSobreX);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.txtPainel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPainel;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnSobreX;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMaisOuMenos;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgula;
    }
}

