namespace SonoraCreativaV2_2
{
    partial class Menu_Principal_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal_Employee));
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Peru;
            this.buttonPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.Location = new System.Drawing.Point(483, 219);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(292, 169);
            this.buttonPayment.TabIndex = 32;
            this.buttonPayment.Text = "Cobros";
            this.buttonPayment.UseVisualStyleBackColor = false;
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.Color.Peru;
            this.buttonInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventory.Location = new System.Drawing.Point(178, 219);
            this.buttonInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(292, 169);
            this.buttonInventory.TabIndex = 31;
            this.buttonInventory.Text = "Inventario";
            this.buttonInventory.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Peru;
            this.buttonLogout.Location = new System.Drawing.Point(854, 10);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 30);
            this.buttonLogout.TabIndex = 30;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // Menu_Principal_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.buttonLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu_Principal_Employee";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonLogout;
    }
}