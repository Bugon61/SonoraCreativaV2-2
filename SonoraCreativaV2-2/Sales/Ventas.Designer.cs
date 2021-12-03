namespace SonoraCreativaV2_2.Sales
{
    partial class Ventas
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupBoxGridView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxDateSearchPH = new System.Windows.Forms.ComboBox();
            this.buttonInfoSale = new System.Windows.Forms.Button();
            this.buttonSearchSale = new System.Windows.Forms.Button();
            this.buttonPMenu = new System.Windows.Forms.Button();
            this.groupBoxGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1138, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(141, 37);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // groupBoxGridView
            // 
            this.groupBoxGridView.Controls.Add(this.dataGridView1);
            this.groupBoxGridView.Location = new System.Drawing.Point(12, 125);
            this.groupBoxGridView.Name = "groupBoxGridView";
            this.groupBoxGridView.Size = new System.Drawing.Size(1267, 608);
            this.groupBoxGridView.TabIndex = 17;
            this.groupBoxGridView.TabStop = false;
            this.groupBoxGridView.Text = "Seleccione la venta que desea revisar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 581);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxDateSearchPH
            // 
            this.comboBoxDateSearchPH.FormattingEnabled = true;
            this.comboBoxDateSearchPH.Location = new System.Drawing.Point(12, 89);
            this.comboBoxDateSearchPH.Name = "comboBoxDateSearchPH";
            this.comboBoxDateSearchPH.Size = new System.Drawing.Size(297, 24);
            this.comboBoxDateSearchPH.TabIndex = 16;
            this.comboBoxDateSearchPH.Text = "Selecciona una fecha";
            // 
            // buttonInfoSale
            // 
            this.buttonInfoSale.Location = new System.Drawing.Point(462, 82);
            this.buttonInfoSale.Name = "buttonInfoSale";
            this.buttonInfoSale.Size = new System.Drawing.Size(141, 37);
            this.buttonInfoSale.TabIndex = 15;
            this.buttonInfoSale.Text = "Ver Informacion";
            this.buttonInfoSale.UseVisualStyleBackColor = true;
            // 
            // buttonSearchSale
            // 
            this.buttonSearchSale.Location = new System.Drawing.Point(315, 82);
            this.buttonSearchSale.Name = "buttonSearchSale";
            this.buttonSearchSale.Size = new System.Drawing.Size(141, 37);
            this.buttonSearchSale.TabIndex = 14;
            this.buttonSearchSale.Text = "Buscar";
            this.buttonSearchSale.UseVisualStyleBackColor = true;
            // 
            // buttonPMenu
            // 
            this.buttonPMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPMenu.Location = new System.Drawing.Point(18, 12);
            this.buttonPMenu.Name = "buttonPMenu";
            this.buttonPMenu.Size = new System.Drawing.Size(141, 37);
            this.buttonPMenu.TabIndex = 19;
            this.buttonPMenu.Text = "Menu principal";
            this.buttonPMenu.UseVisualStyleBackColor = true;
            this.buttonPMenu.Click += new System.EventHandler(this.buttonPMenu_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 745);
            this.Controls.Add(this.buttonPMenu);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.groupBoxGridView);
            this.Controls.Add(this.comboBoxDateSearchPH);
            this.Controls.Add(this.buttonInfoSale);
            this.Controls.Add(this.buttonSearchSale);
            this.Name = "Ventas";
            this.Text = "Registro de Ventas";
            this.groupBoxGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBoxGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxDateSearchPH;
        private System.Windows.Forms.Button buttonInfoSale;
        private System.Windows.Forms.Button buttonSearchSale;
        private System.Windows.Forms.Button buttonPMenu;
    }
}