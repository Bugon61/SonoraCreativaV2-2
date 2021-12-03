namespace SonoraCreativaV2_2.Inventory
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.buttonInfoProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.groupBoxRegisterProduct = new System.Windows.Forms.GroupBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCleanFields = new System.Windows.Forms.Button();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProducttype = new System.Windows.Forms.ComboBox();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioGVDS = new SonoraCreativaV2_2.InventarioGVDS();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGridView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPMenu = new System.Windows.Forms.Button();
            this.inventarioTableAdapter = new SonoraCreativaV2_2.InventarioGVDSTableAdapters.inventarioTableAdapter();
            this.groupBoxRegisterProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioGVDS)).BeginInit();
            this.groupBoxGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Peru;
            this.buttonLogout.Location = new System.Drawing.Point(854, 10);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 30);
            this.buttonLogout.TabIndex = 24;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.BackColor = System.Drawing.Color.Gold;
            this.buttonSearchProduct.Location = new System.Drawing.Point(236, 75);
            this.buttonSearchProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(106, 30);
            this.buttonSearchProduct.TabIndex = 23;
            this.buttonSearchProduct.Text = "Buscar";
            this.buttonSearchProduct.UseVisualStyleBackColor = false;
            // 
            // buttonInfoProduct
            // 
            this.buttonInfoProduct.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonInfoProduct.Location = new System.Drawing.Point(236, 110);
            this.buttonInfoProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInfoProduct.Name = "buttonInfoProduct";
            this.buttonInfoProduct.Size = new System.Drawing.Size(106, 30);
            this.buttonInfoProduct.TabIndex = 22;
            this.buttonInfoProduct.Text = "Ver Informacion";
            this.buttonInfoProduct.UseVisualStyleBackColor = false;
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonEditProduct.Location = new System.Drawing.Point(346, 110);
            this.buttonEditProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(106, 30);
            this.buttonEditProduct.TabIndex = 21;
            this.buttonEditProduct.Text = "Editar producto";
            this.buttonEditProduct.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(457, 110);
            this.buttonDeleteProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(106, 30);
            this.buttonDeleteProduct.TabIndex = 20;
            this.buttonDeleteProduct.Text = "Eliminar producto";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Location = new System.Drawing.Point(9, 80);
            this.textBoxSearchProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(224, 20);
            this.textBoxSearchProduct.TabIndex = 19;
            this.textBoxSearchProduct.Text = "Buscar producto...";
            // 
            // groupBoxRegisterProduct
            // 
            this.groupBoxRegisterProduct.Controls.Add(this.textBoxPrice);
            this.groupBoxRegisterProduct.Controls.Add(this.label2);
            this.groupBoxRegisterProduct.Controls.Add(this.buttonSaveProduct);
            this.groupBoxRegisterProduct.Controls.Add(this.label9);
            this.groupBoxRegisterProduct.Controls.Add(this.buttonCleanFields);
            this.groupBoxRegisterProduct.Controls.Add(this.textBoxProductDescription);
            this.groupBoxRegisterProduct.Controls.Add(this.textBoxQuantity);
            this.groupBoxRegisterProduct.Controls.Add(this.label6);
            this.groupBoxRegisterProduct.Controls.Add(this.comboBoxProducttype);
            this.groupBoxRegisterProduct.Controls.Add(this.label5);
            this.groupBoxRegisterProduct.Controls.Add(this.textBoxProductName);
            this.groupBoxRegisterProduct.Controls.Add(this.label1);
            this.groupBoxRegisterProduct.Location = new System.Drawing.Point(689, 145);
            this.groupBoxRegisterProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRegisterProduct.Name = "groupBoxRegisterProduct";
            this.groupBoxRegisterProduct.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRegisterProduct.Size = new System.Drawing.Size(270, 451);
            this.groupBoxRegisterProduct.TabIndex = 18;
            this.groupBoxRegisterProduct.TabStop = false;
            this.groupBoxRegisterProduct.Text = "Registrar producto";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(110, 266);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(150, 20);
            this.textBoxPrice.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Precio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSaveProduct
            // 
            this.buttonSaveProduct.BackColor = System.Drawing.Color.Gold;
            this.buttonSaveProduct.Location = new System.Drawing.Point(32, 416);
            this.buttonSaveProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveProduct.Name = "buttonSaveProduct";
            this.buttonSaveProduct.Size = new System.Drawing.Size(106, 30);
            this.buttonSaveProduct.TabIndex = 8;
            this.buttonSaveProduct.Text = "Guardar";
            this.buttonSaveProduct.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Descripcion:";
            // 
            // buttonCleanFields
            // 
            this.buttonCleanFields.BackColor = System.Drawing.Color.Gold;
            this.buttonCleanFields.Location = new System.Drawing.Point(142, 416);
            this.buttonCleanFields.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCleanFields.Name = "buttonCleanFields";
            this.buttonCleanFields.Size = new System.Drawing.Size(106, 30);
            this.buttonCleanFields.TabIndex = 7;
            this.buttonCleanFields.Text = "Limpiar";
            this.buttonCleanFields.UseVisualStyleBackColor = false;
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.Location = new System.Drawing.Point(78, 54);
            this.textBoxProductDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProductDescription.Multiline = true;
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(188, 120);
            this.textBoxProductDescription.TabIndex = 16;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(110, 228);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(150, 20);
            this.textBoxQuantity.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad:";
            // 
            // comboBoxProducttype
            // 
            this.comboBoxProducttype.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inventarioBindingSource, "tipo_producto", true));
            this.comboBoxProducttype.FormattingEnabled = true;
            this.comboBoxProducttype.Items.AddRange(new object[] {
            "Alimentos",
            "Licores",
            "Artesanias",
            "Ropa"});
            this.comboBoxProducttype.Location = new System.Drawing.Point(110, 188);
            this.comboBoxProducttype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProducttype.Name = "comboBoxProducttype";
            this.comboBoxProducttype.Size = new System.Drawing.Size(150, 21);
            this.comboBoxProducttype.TabIndex = 9;
            this.comboBoxProducttype.Text = "Selecciona una opcion";
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "inventario";
            this.inventarioBindingSource.DataSource = this.inventarioGVDS;
            // 
            // inventarioGVDS
            // 
            this.inventarioGVDS.DataSetName = "InventarioGVDS";
            this.inventarioGVDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de producto:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(110, 31);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(150, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // groupBoxGridView
            // 
            this.groupBoxGridView.Controls.Add(this.dataGridView1);
            this.groupBoxGridView.Location = new System.Drawing.Point(9, 145);
            this.groupBoxGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxGridView.Name = "groupBoxGridView";
            this.groupBoxGridView.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxGridView.Size = new System.Drawing.Size(676, 451);
            this.groupBoxGridView.TabIndex = 17;
            this.groupBoxGridView.TabStop = false;
            this.groupBoxGridView.Text = "Seleccione el usuario que desee modificar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.tipoproductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoproductoDataGridViewTextBoxColumn
            // 
            this.tipoproductoDataGridViewTextBoxColumn.DataPropertyName = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.HeaderText = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoproductoDataGridViewTextBoxColumn.Name = "tipoproductoDataGridViewTextBoxColumn";
            this.tipoproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // buttonPMenu
            // 
            this.buttonPMenu.BackColor = System.Drawing.Color.Peru;
            this.buttonPMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPMenu.Location = new System.Drawing.Point(9, 10);
            this.buttonPMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPMenu.Name = "buttonPMenu";
            this.buttonPMenu.Size = new System.Drawing.Size(106, 30);
            this.buttonPMenu.TabIndex = 25;
            this.buttonPMenu.Text = "Menu principal";
            this.buttonPMenu.UseVisualStyleBackColor = false;
            this.buttonPMenu.Click += new System.EventHandler(this.buttonPMenu_Click);
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.buttonPMenu);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSearchProduct);
            this.Controls.Add(this.buttonInfoProduct);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.textBoxSearchProduct);
            this.Controls.Add(this.groupBoxRegisterProduct);
            this.Controls.Add(this.groupBoxGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Inventario";
            this.Text = "Control de Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.groupBoxRegisterProduct.ResumeLayout(false);
            this.groupBoxRegisterProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioGVDS)).EndInit();
            this.groupBoxGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.Button buttonInfoProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.GroupBox groupBoxRegisterProduct;
        private System.Windows.Forms.Button buttonSaveProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCleanFields;
        private System.Windows.Forms.TextBox textBoxProductDescription;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProducttype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPMenu;
        private InventarioGVDS inventarioGVDS;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private InventarioGVDSTableAdapters.inventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
    }
}