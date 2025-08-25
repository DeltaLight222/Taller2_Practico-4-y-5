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
            BGenerar = new Button();
            TDesde = new TextBox();
            THasta = new TextBox();
            Desde = new Label();
            Hasta = new Label();
            TBNumeros = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BGenerar
            // 
            BGenerar.Location = new Point(226, 70);
            BGenerar.Name = "BGenerar";
            BGenerar.Size = new Size(103, 23);
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
            // TBNumeros
            // 
            TBNumeros.FormattingEnabled = true;
            TBNumeros.ItemHeight = 15;
            TBNumeros.Location = new Point(397, 74);
            TBNumeros.Name = "TBNumeros";
            TBNumeros.Size = new Size(321, 304);
            TBNumeros.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 56);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 6;
            label1.Text = "Lista de Numeros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TBNumeros);
            Controls.Add(Hasta);
            Controls.Add(Desde);
            Controls.Add(THasta);
            Controls.Add(TDesde);
            Controls.Add(BGenerar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGenerar;
        private TextBox TDesde;
        private TextBox THasta;
        private Label Desde;
        private Label Hasta;
        private ListBox TBNumeros;
        private Label label1;
    }
}
