namespace Practico_4
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
            components = new System.ComponentModel.Container();
            BGenerar = new Button();
            TDesde = new TextBox();
            THasta = new TextBox();
            Desde = new Label();
            Hasta = new Label();
            LBNumeros = new ListBox();
            label1 = new Label();
            BPares = new Button();
            BImpares = new Button();
            BPrimos = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // BGenerar
            // 
            BGenerar.Location = new Point(99, 182);
            BGenerar.Name = "BGenerar";
            BGenerar.Size = new Size(118, 23);
            BGenerar.TabIndex = 0;
            BGenerar.Text = "Generar función";
            BGenerar.UseVisualStyleBackColor = true;
            BGenerar.Click += button1_Click;
            // 
            // TDesde
            // 
            TDesde.Location = new Point(102, 70);
            TDesde.Name = "TDesde";
            TDesde.Size = new Size(100, 23);
            TDesde.TabIndex = 1;
            // 
            // THasta
            // 
            THasta.Location = new Point(102, 130);
            THasta.Name = "THasta";
            THasta.Size = new Size(100, 23);
            THasta.TabIndex = 2;
            // 
            // Desde
            // 
            Desde.AutoSize = true;
            Desde.Location = new Point(31, 74);
            Desde.Name = "Desde";
            Desde.Size = new Size(39, 15);
            Desde.TabIndex = 3;
            Desde.Text = "Desde";
            // 
            // Hasta
            // 
            Hasta.AutoSize = true;
            Hasta.Location = new Point(28, 133);
            Hasta.Name = "Hasta";
            Hasta.Size = new Size(37, 15);
            Hasta.TabIndex = 4;
            Hasta.Text = "Hasta";
            // 
            // LBNumeros
            // 
            LBNumeros.FormattingEnabled = true;
            LBNumeros.ItemHeight = 15;
            LBNumeros.Location = new Point(259, 74);
            LBNumeros.Name = "LBNumeros";
            LBNumeros.Size = new Size(321, 304);
            LBNumeros.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 56);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 6;
            label1.Text = "Lista de Numeros";
            // 
            // BPares
            // 
            BPares.Location = new Point(102, 222);
            BPares.Name = "BPares";
            BPares.Size = new Size(115, 23);
            BPares.TabIndex = 7;
            BPares.Text = "Números Pares";
            BPares.UseVisualStyleBackColor = true;
            BPares.Click += BPares_Click;
            // 
            // BImpares
            // 
            BImpares.Location = new Point(99, 251);
            BImpares.Name = "BImpares";
            BImpares.Size = new Size(118, 23);
            BImpares.TabIndex = 8;
            BImpares.Text = "Números Impares";
            BImpares.UseVisualStyleBackColor = true;
            BImpares.Click += BImpares_Click;
            // 
            // BPrimos
            // 
            BPrimos.Location = new Point(99, 280);
            BPrimos.Name = "BPrimos";
            BPrimos.Size = new Size(118, 23);
            BPrimos.TabIndex = 9;
            BPrimos.Text = "Números Primos";
            BPrimos.UseVisualStyleBackColor = true;
            BPrimos.Click += BPrimos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 570);
            Controls.Add(BPrimos);
            Controls.Add(BImpares);
            Controls.Add(BPares);
            Controls.Add(label1);
            Controls.Add(LBNumeros);
            Controls.Add(Hasta);
            Controls.Add(Desde);
            Controls.Add(THasta);
            Controls.Add(TDesde);
            Controls.Add(BGenerar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGenerar;
        private TextBox TDesde;
        private TextBox THasta;
        private Label Desde;
        private Label Hasta;
        private ListBox LBNumeros;
        private Label label1;
        private Button BPares;
        private Button BImpares;
        private Button BPrimos;
        private BindingSource bindingSource1;
    }
}
