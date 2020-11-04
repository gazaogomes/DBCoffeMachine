namespace DBCoffeMachine.Modal
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblDBCoffe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCardapio = new System.Windows.Forms.Label();
            this.btnInsertCoins = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDBCoffe
            // 
            this.lblDBCoffe.AutoSize = true;
            this.lblDBCoffe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBCoffe.Location = new System.Drawing.Point(307, 27);
            this.lblDBCoffe.Name = "lblDBCoffe";
            this.lblDBCoffe.Size = new System.Drawing.Size(144, 37);
            this.lblDBCoffe.TabIndex = 0;
            this.lblDBCoffe.Text = "DBCoffe";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCardapio);
            this.panel1.Location = new System.Drawing.Point(31, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 233);
            this.panel1.TabIndex = 1;
            // 
            // lblCardapio
            // 
            this.lblCardapio.AutoSize = true;
            this.lblCardapio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardapio.Location = new System.Drawing.Point(18, 14);
            this.lblCardapio.Name = "lblCardapio";
            this.lblCardapio.Size = new System.Drawing.Size(156, 37);
            this.lblCardapio.TabIndex = 2;
            this.lblCardapio.Text = "Cardápio";
            // 
            // btnInsertCoins
            // 
            this.btnInsertCoins.Location = new System.Drawing.Point(493, 260);
            this.btnInsertCoins.Name = "btnInsertCoins";
            this.btnInsertCoins.Size = new System.Drawing.Size(187, 68);
            this.btnInsertCoins.TabIndex = 2;
            this.btnInsertCoins.Text = "Inserir Moedas";
            this.btnInsertCoins.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertCoins);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDBCoffe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBCoffe";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDBCoffe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCardapio;
        private System.Windows.Forms.Button btnInsertCoins;
    }
}