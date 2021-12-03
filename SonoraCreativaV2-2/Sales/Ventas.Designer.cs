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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupBoxGridView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxDateSearchPH = new System.Windows.Forms.ComboBox();
            this.buttonInfoSale = new System.Windows.Forms.Button();
            this.buttonSearchSale = new System.Windows.Forms.Button();
            this.buttonPMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Peru;
            this.buttonLogout.Location = new System.Drawing.Point(854, 10);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 30);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // groupBoxGridView
            // 
            this.groupBoxGridView.Controls.Add(this.dataGridView1);
            this.groupBoxGridView.Location = new System.Drawing.Point(9, 102);
            this.groupBoxGridView.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGridView.Name = "groupBoxGridView";
            this.groupBoxGridView.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGridView.Size = new System.Drawing.Size(950, 494);
            this.groupBoxGridView.TabIndex = 17;
            this.groupBoxGridView.TabStop = false;
            this.groupBoxGridView.Text = "Seleccione la venta que desea revisar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(941, 472);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxDateSearchPH
            // 
            this.comboBoxDateSearchPH.FormattingEnabled = true;
            this.comboBoxDateSearchPH.Location = new System.Drawing.Point(9, 72);
            this.comboBoxDateSearchPH.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDateSearchPH.Name = "comboBoxDateSearchPH";
            this.comboBoxDateSearchPH.Size = new System.Drawing.Size(224, 21);
            this.comboBoxDateSearchPH.TabIndex = 16;
            this.comboBoxDateSearchPH.Text = "Selecciona una fecha";
            // 
            // buttonInfoSale
            // 
            this.buttonInfoSale.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonInfoSale.Location = new System.Drawing.Point(346, 67);
            this.buttonInfoSale.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfoSale.Name = "buttonInfoSale";
            this.buttonInfoSale.Size = new System.Drawing.Size(106, 30);
            this.buttonInfoSale.TabIndex = 15;
            this.buttonInfoSale.Text = "Ver Informacion";
            this.buttonInfoSale.UseVisualStyleBackColor = false;
            // 
            // buttonSearchSale
            // 
            this.buttonSearchSale.BackColor = System.Drawing.Color.Gold;
            this.buttonSearchSale.Location = new System.Drawing.Point(236, 67);
            this.buttonSearchSale.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchSale.Name = "buttonSearchSale";
            this.buttonSearchSale.Size = new System.Drawing.Size(106, 30);
            this.buttonSearchSale.TabIndex = 14;
            this.buttonSearchSale.Text = "Buscar";
            this.buttonSearchSale.UseVisualStyleBackColor = false;
            // 
            // buttonPMenu
            // 
            this.buttonPMenu.BackColor = System.Drawing.Color.Peru;
            this.buttonPMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPMenu.Location = new System.Drawing.Point(14, 10);
            this.buttonPMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPMenu.Name = "buttonPMenu";
            this.buttonPMenu.Size = new System.Drawing.Size(106, 30);
            this.buttonPMenu.TabIndex = 19;
            this.buttonPMenu.Text = "Menu principal";
            this.buttonPMenu.UseVisualStyleBackColor = false;
            this.buttonPMenu.Click += new System.EventHandler(this.buttonPMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SonoraCreativaV2_2.Properties.Resources.Logo_Sonora_Creativa___copia;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(513, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPMenu);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.groupBoxGridView);
            this.Controls.Add(this.comboBoxDateSearchPH);
            this.Controls.Add(this.buttonInfoSale);
            this.Controls.Add(this.buttonSearchSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ventas";
            this.Text = "Registro de Ventas";
            this.groupBoxGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}