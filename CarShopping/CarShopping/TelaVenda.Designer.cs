namespace CarShopping
{
    partial class TelaVenda
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
            lblArea = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnVender1 = new Button();
            btnVender2 = new Button();
            btnVender3 = new Button();
            SuspendLayout();
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(291, 38);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(76, 15);
            lblArea.TabIndex = 0;
            lblArea.Text = "Numero area";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 36);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Area :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 144);
            label3.Name = "label3";
            label3.Size = new Size(174, 30);
            label3.TabIndex = 4;
            label3.Text = "Modelo: Fiat Toro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(220, 144);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 5;
            label2.Text = "Preço: 57733 R$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(257, 202);
            label4.Name = "label4";
            label4.Size = new Size(155, 30);
            label4.TabIndex = 7;
            label4.Text = "Preço: 53937R$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 202);
            label5.Name = "label5";
            label5.Size = new Size(209, 30);
            label5.TabIndex = 6;
            label5.Text = "Modelo: Toyota Hilux";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(327, 272);
            label6.Name = "label6";
            label6.Size = new Size(161, 30);
            label6.TabIndex = 9;
            label6.Text = "Preço: 48481 R$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 272);
            label7.Name = "label7";
            label7.Size = new Size(276, 30);
            label7.TabIndex = 8;
            label7.Text = "Modelo: Caoa Chery Tiggo 8";
            // 
            // btnVender1
            // 
            btnVender1.Location = new Point(458, 144);
            btnVender1.Name = "btnVender1";
            btnVender1.Size = new Size(144, 31);
            btnVender1.TabIndex = 10;
            btnVender1.Text = "Vender";
            btnVender1.UseVisualStyleBackColor = true;
            btnVender1.Click += btnVender1_Click;
            // 
            // btnVender2
            // 
            btnVender2.Location = new Point(481, 206);
            btnVender2.Name = "btnVender2";
            btnVender2.Size = new Size(144, 31);
            btnVender2.TabIndex = 11;
            btnVender2.Text = "Vender";
            btnVender2.UseVisualStyleBackColor = true;
            // 
            // btnVender3
            // 
            btnVender3.Location = new Point(536, 276);
            btnVender3.Name = "btnVender3";
            btnVender3.Size = new Size(144, 31);
            btnVender3.TabIndex = 12;
            btnVender3.Text = "Vender";
            btnVender3.UseVisualStyleBackColor = true;
            // 
            // TelaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVender3);
            Controls.Add(btnVender2);
            Controls.Add(btnVender1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblArea);
            Name = "TelaVenda";
            Text = "TelaVenda";
            Load += TelaVenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArea;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnVender1;
        private Button btnVender2;
        private Button btnVender3;
    }
}