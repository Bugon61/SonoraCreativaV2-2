namespace SonoraCreativaV2_2.Payment
{
    partial class Cobros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobros));
            this.buttonPMenu = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.comboBoxIdItemList = new System.Windows.Forms.ComboBox();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobrosIdItemListDS = new SonoraCreativaV2_2.CobrosIdItemListDS();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMakeSale = new System.Windows.Forms.Button();
            this.buttonCancelSale = new System.Windows.Forms.Button();
            this.inventarioTableAdapter = new SonoraCreativaV2_2.CobrosIdItemListDSTableAdapters.inventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosIdItemListDS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPMenu
            // 
            this.buttonPMenu.BackColor = System.Drawing.Color.Peru;
            this.buttonPMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPMenu.Location = new System.Drawing.Point(9, 10);
            this.buttonPMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPMenu.Name = "buttonPMenu";
            this.buttonPMenu.Size = new System.Drawing.Size(106, 30);
            this.buttonPMenu.TabIndex = 26;
            this.buttonPMenu.Text = "Menu principal";
            this.buttonPMenu.UseVisualStyleBackColor = false;
            this.buttonPMenu.Click += new System.EventHandler(this.buttonPMenu_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Peru;
            this.buttonLogout.Location = new System.Drawing.Point(854, 10);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 30);
            this.buttonLogout.TabIndex = 27;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // listViewItems
            // 
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(9, 101);
            this.listViewItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(677, 393);
            this.listViewItems.TabIndex = 28;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxIdItemList
            // 
            this.comboBoxIdItemList.DataSource = this.inventarioBindingSource;
            this.comboBoxIdItemList.DisplayMember = "id_producto";
            this.comboBoxIdItemList.FormattingEnabled = true;
            this.comboBoxIdItemList.Location = new System.Drawing.Point(689, 111);
            this.comboBoxIdItemList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxIdItemList.Name = "comboBoxIdItemList";
            this.comboBoxIdItemList.Size = new System.Drawing.Size(106, 21);
            this.comboBoxIdItemList.TabIndex = 29;
            this.comboBoxIdItemList.ValueMember = "id_producto";
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "inventario";
            this.inventarioBindingSource.DataSource = this.cobrosIdItemListDS;
            // 
            // cobrosIdItemListDS
            // 
            this.cobrosIdItemListDS.DataSetName = "CobrosIdItemListDS";
            this.cobrosIdItemListDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Gold;
            this.buttonAdd.Location = new System.Drawing.Point(799, 105);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 30);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Añadir Producto";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonMakeSale
            // 
            this.buttonMakeSale.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonMakeSale.Location = new System.Drawing.Point(689, 463);
            this.buttonMakeSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMakeSale.Name = "buttonMakeSale";
            this.buttonMakeSale.Size = new System.Drawing.Size(106, 30);
            this.buttonMakeSale.TabIndex = 31;
            this.buttonMakeSale.Text = "Realizar Venta";
            this.buttonMakeSale.UseVisualStyleBackColor = false;
            // 
            // buttonCancelSale
            // 
            this.buttonCancelSale.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonCancelSale.Location = new System.Drawing.Point(800, 463);
            this.buttonCancelSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelSale.Name = "buttonCancelSale";
            this.buttonCancelSale.Size = new System.Drawing.Size(106, 30);
            this.buttonCancelSale.TabIndex = 32;
            this.buttonCancelSale.Text = "Cancelar Venta";
            this.buttonCancelSale.UseVisualStyleBackColor = false;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // Cobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.buttonCancelSale);
            this.Controls.Add(this.buttonMakeSale);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxIdItemList);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonPMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cobros";
            this.Text = "Realizar Cobros";
            this.Load += new System.EventHandler(this.Cobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosIdItemListDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPMenu;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ComboBox comboBoxIdItemList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMakeSale;
        private System.Windows.Forms.Button buttonCancelSale;
        private CobrosIdItemListDS cobrosIdItemListDS;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private CobrosIdItemListDSTableAdapters.inventarioTableAdapter inventarioTableAdapter;
    }
}