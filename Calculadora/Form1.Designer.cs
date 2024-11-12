namespace Calculadora
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
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_7 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_0 = new Button();
            btn_virgula = new Button();
            btn_igual = new Button();
            btn_divide = new Button();
            btn_vezes = new Button();
            btn_menos = new Button();
            btn_mais = new Button();
            btn_limpa = new Button();
            txt_resultado = new TextBox();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // btn_1
            // 
            btn_1.BackColor = SystemColors.ControlLight;
            btn_1.Location = new Point(14, 211);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(39, 45);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = SystemColors.ControlLight;
            btn_2.Location = new Point(59, 211);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(39, 45);
            btn_2.TabIndex = 1;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = SystemColors.ControlLight;
            btn_3.Location = new Point(104, 211);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(39, 45);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += btn_3_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = SystemColors.ControlLight;
            btn_4.Location = new Point(14, 160);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(39, 45);
            btn_4.TabIndex = 3;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btn_4_Click;
            // 
            // btn_7
            // 
            btn_7.BackColor = SystemColors.ControlLight;
            btn_7.Location = new Point(14, 109);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(39, 45);
            btn_7.TabIndex = 4;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += btn_7_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = SystemColors.ControlLight;
            btn_5.Location = new Point(59, 160);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(39, 45);
            btn_5.TabIndex = 5;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btn_5_Click;
            // 
            // btn_6
            // 
            btn_6.BackColor = SystemColors.ControlLight;
            btn_6.Location = new Point(104, 160);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(39, 45);
            btn_6.TabIndex = 6;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += btn_6_Click;
            // 
            // btn_8
            // 
            btn_8.BackColor = SystemColors.ControlLight;
            btn_8.Location = new Point(59, 109);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(39, 45);
            btn_8.TabIndex = 7;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += btn_8_Click;
            // 
            // btn_9
            // 
            btn_9.BackColor = SystemColors.ControlLight;
            btn_9.Location = new Point(104, 109);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(39, 45);
            btn_9.TabIndex = 8;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += btn_9_Click;
            // 
            // btn_0
            // 
            btn_0.BackColor = SystemColors.ControlLight;
            btn_0.Location = new Point(59, 262);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(39, 45);
            btn_0.TabIndex = 9;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += btn_0_Click;
            // 
            // btn_virgula
            // 
            btn_virgula.BackColor = SystemColors.ControlLight;
            btn_virgula.Location = new Point(14, 262);
            btn_virgula.Name = "btn_virgula";
            btn_virgula.Size = new Size(39, 45);
            btn_virgula.TabIndex = 10;
            btn_virgula.Text = ",";
            btn_virgula.UseVisualStyleBackColor = false;
            btn_virgula.Click += btn_virgula_Click;
            // 
            // btn_igual
            // 
            btn_igual.BackColor = SystemColors.ControlLight;
            btn_igual.Location = new Point(104, 262);
            btn_igual.Name = "btn_igual";
            btn_igual.Size = new Size(39, 45);
            btn_igual.TabIndex = 11;
            btn_igual.Text = "=";
            btn_igual.UseVisualStyleBackColor = false;
            btn_igual.Click += btn_igual_Click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = SystemColors.ControlLight;
            btn_divide.Location = new Point(149, 109);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(39, 45);
            btn_divide.TabIndex = 12;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_vezes
            // 
            btn_vezes.BackColor = SystemColors.ControlLight;
            btn_vezes.Location = new Point(149, 160);
            btn_vezes.Name = "btn_vezes";
            btn_vezes.Size = new Size(39, 45);
            btn_vezes.TabIndex = 13;
            btn_vezes.Text = "*";
            btn_vezes.UseVisualStyleBackColor = false;
            btn_vezes.Click += btn_vezes_Click;
            // 
            // btn_menos
            // 
            btn_menos.BackColor = SystemColors.ControlLight;
            btn_menos.Location = new Point(149, 211);
            btn_menos.Name = "btn_menos";
            btn_menos.Size = new Size(39, 45);
            btn_menos.TabIndex = 14;
            btn_menos.Text = "-";
            btn_menos.UseVisualStyleBackColor = false;
            btn_menos.Click += btn_menos_Click;
            // 
            // btn_mais
            // 
            btn_mais.BackColor = SystemColors.ControlLight;
            btn_mais.Location = new Point(149, 262);
            btn_mais.Name = "btn_mais";
            btn_mais.Size = new Size(39, 45);
            btn_mais.TabIndex = 15;
            btn_mais.Text = "+";
            btn_mais.UseVisualStyleBackColor = false;
            btn_mais.Click += btn_mais_Click;
            // 
            // btn_limpa
            // 
            btn_limpa.BackColor = SystemColors.ControlLight;
            btn_limpa.Location = new Point(149, 58);
            btn_limpa.Name = "btn_limpa";
            btn_limpa.Size = new Size(39, 45);
            btn_limpa.TabIndex = 16;
            btn_limpa.Text = "C";
            btn_limpa.UseVisualStyleBackColor = false;
            btn_limpa.Click += btn_limpa_Click;
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(14, 29);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(174, 23);
            txt_resultado.TabIndex = 17;
            txt_resultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(15, 34);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 337);
            Controls.Add(lblOperacao);
            Controls.Add(txt_resultado);
            Controls.Add(btn_limpa);
            Controls.Add(btn_mais);
            Controls.Add(btn_menos);
            Controls.Add(btn_vezes);
            Controls.Add(btn_divide);
            Controls.Add(btn_igual);
            Controls.Add(btn_virgula);
            Controls.Add(btn_0);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_7);
            Controls.Add(btn_4);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_7;
        private Button btn_5;
        private Button btn_6;
        private Button btn_8;
        private Button btn_9;
        private Button btn_0;
        private Button btn_virgula;
        private Button btn_igual;
        private Button btn_divide;
        private Button btn_vezes;
        private Button btn_menos;
        private Button btn_mais;
        private Button btn_limpa;
        private TextBox txt_resultado;
        private Label lblOperacao;
    }
}
