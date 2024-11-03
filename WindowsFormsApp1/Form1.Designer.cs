namespace WindowsFormsApp1
{
    partial class BinaryConverter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinaryConverter));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Klick mich";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNumberInput
            // 
            this.textBoxNumberInput.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberInput.Location = new System.Drawing.Point(12, 15);
            this.textBoxNumberInput.Name = "textBoxNumberInput";
            this.textBoxNumberInput.Size = new System.Drawing.Size(776, 31);
            this.textBoxNumberInput.TabIndex = 2;
            this.textBoxNumberInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxNumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberInput_KeyPress);
            // 
            // BinaryConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(797, 973);
            this.Controls.Add(this.textBoxNumberInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BinaryConverter";
            this.Text = "BinaryConverter";
            this.Load += new System.EventHandler(this.BinaryConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberInput;
    }
}

