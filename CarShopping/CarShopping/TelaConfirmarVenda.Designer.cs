namespace CarShopping
{
    partial class TelaConfirmarVenda
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
            cmbCliente = new ComboBox();
            cmbCocessionaria = new ComboBox();
            SuspendLayout();
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(81, 84);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(239, 23);
            cmbCliente.TabIndex = 0;
            // 
            // cmbCocessionaria
            // 
            cmbCocessionaria.FormattingEnabled = true;
            cmbCocessionaria.Location = new Point(81, 161);
            cmbCocessionaria.Name = "cmbCocessionaria";
            cmbCocessionaria.Size = new Size(239, 23);
            cmbCocessionaria.TabIndex = 1;
            // 
            // TelaConfirmarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCocessionaria);
            Controls.Add(cmbCliente);
            Name = "TelaConfirmarVenda";
            Text = "TelaConfirmarVenda";
            Load += TelaConfirmarVenda_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbCliente;
        private ComboBox cmbCocessionaria;
    }
}