namespace SonoraCreativaV2_2.Users
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.buttonInfoUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.textBoxSUser = new System.Windows.Forms.TextBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.groupBoxRegisterUser = new System.Windows.Forms.GroupBox();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCleanFields = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.comboBoxSchedule = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxUsertype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGridView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioGVDS = new SonoraCreativaV2_2.UsuarioGVDS();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.usuariosTableAdapter = new SonoraCreativaV2_2.UsuarioGVDSTableAdapters.usuariosTableAdapter();
            this.buttonPMenu = new System.Windows.Forms.Button();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxRegisterUser.SuspendLayout();
            this.groupBoxGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioGVDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfoUser
            // 
            this.buttonInfoUser.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonInfoUser.Location = new System.Drawing.Point(236, 110);
            this.buttonInfoUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfoUser.Name = "buttonInfoUser";
            this.buttonInfoUser.Size = new System.Drawing.Size(106, 30);
            this.buttonInfoUser.TabIndex = 14;
            this.buttonInfoUser.Text = "Ver Informacion";
            this.buttonInfoUser.UseVisualStyleBackColor = false;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonEditUser.Location = new System.Drawing.Point(346, 110);
            this.buttonEditUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(106, 30);
            this.buttonEditUser.TabIndex = 13;
            this.buttonEditUser.Text = "Editar usuario";
            this.buttonEditUser.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonDeleteUser.Location = new System.Drawing.Point(457, 110);
            this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(106, 30);
            this.buttonDeleteUser.TabIndex = 12;
            this.buttonDeleteUser.Text = "Eliminar usuario";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            // 
            // textBoxSUser
            // 
            this.textBoxSUser.Location = new System.Drawing.Point(9, 80);
            this.textBoxSUser.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSUser.Name = "textBoxSUser";
            this.textBoxSUser.Size = new System.Drawing.Size(224, 20);
            this.textBoxSUser.TabIndex = 11;
            this.textBoxSUser.Text = "Buscar usuario...";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonChangePassword.Location = new System.Drawing.Point(567, 110);
            this.buttonChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(118, 30);
            this.buttonChangePassword.TabIndex = 10;
            this.buttonChangePassword.Text = "Cambiar contraseña";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            // 
            // groupBoxRegisterUser
            // 
            this.groupBoxRegisterUser.Controls.Add(this.buttonSaveUser);
            this.groupBoxRegisterUser.Controls.Add(this.label9);
            this.groupBoxRegisterUser.Controls.Add(this.buttonCleanFields);
            this.groupBoxRegisterUser.Controls.Add(this.textBoxNotes);
            this.groupBoxRegisterUser.Controls.Add(this.comboBoxSchedule);
            this.groupBoxRegisterUser.Controls.Add(this.label8);
            this.groupBoxRegisterUser.Controls.Add(this.textBoxCPassword);
            this.groupBoxRegisterUser.Controls.Add(this.label7);
            this.groupBoxRegisterUser.Controls.Add(this.textBoxPassword);
            this.groupBoxRegisterUser.Controls.Add(this.label6);
            this.groupBoxRegisterUser.Controls.Add(this.comboBoxUsertype);
            this.groupBoxRegisterUser.Controls.Add(this.label5);
            this.groupBoxRegisterUser.Controls.Add(this.textBoxUsername);
            this.groupBoxRegisterUser.Controls.Add(this.label4);
            this.groupBoxRegisterUser.Controls.Add(this.textBoxMLastname);
            this.groupBoxRegisterUser.Controls.Add(this.label3);
            this.groupBoxRegisterUser.Controls.Add(this.textBoxPLastname);
            this.groupBoxRegisterUser.Controls.Add(this.label2);
            this.groupBoxRegisterUser.Controls.Add(this.textBoxName);
            this.groupBoxRegisterUser.Controls.Add(this.label1);
            this.groupBoxRegisterUser.Location = new System.Drawing.Point(689, 145);
            this.groupBoxRegisterUser.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRegisterUser.Name = "groupBoxRegisterUser";
            this.groupBoxRegisterUser.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRegisterUser.Size = new System.Drawing.Size(270, 451);
            this.groupBoxRegisterUser.TabIndex = 9;
            this.groupBoxRegisterUser.TabStop = false;
            this.groupBoxRegisterUser.Text = "Registrar usuario";
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.BackColor = System.Drawing.Color.Gold;
            this.buttonSaveUser.Location = new System.Drawing.Point(32, 416);
            this.buttonSaveUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(106, 30);
            this.buttonSaveUser.TabIndex = 8;
            this.buttonSaveUser.Text = "Guardar";
            this.buttonSaveUser.UseVisualStyleBackColor = false;
            this.buttonSaveUser.Click += new System.EventHandler(this.buttonSaveUser_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Notas:";
            // 
            // buttonCleanFields
            // 
            this.buttonCleanFields.BackColor = System.Drawing.Color.Gold;
            this.buttonCleanFields.Location = new System.Drawing.Point(142, 416);
            this.buttonCleanFields.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCleanFields.Name = "buttonCleanFields";
            this.buttonCleanFields.Size = new System.Drawing.Size(106, 30);
            this.buttonCleanFields.TabIndex = 7;
            this.buttonCleanFields.Text = "Limpiar";
            this.buttonCleanFields.UseVisualStyleBackColor = false;
            this.buttonCleanFields.Click += new System.EventHandler(this.buttonCleanFields_Click);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(41, 332);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(218, 70);
            this.textBoxNotes.TabIndex = 16;
            // 
            // comboBoxSchedule
            // 
            this.comboBoxSchedule.FormattingEnabled = true;
            this.comboBoxSchedule.Items.AddRange(new object[] {
            "Matutino (8:00-14:00)",
            "Matutino Parcial",
            "Vespertino (14:00-22:00)",
            "Vespertino Parcial"});
            this.comboBoxSchedule.Location = new System.Drawing.Point(110, 294);
            this.comboBoxSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSchedule.Name = "comboBoxSchedule";
            this.comboBoxSchedule.Size = new System.Drawing.Size(150, 21);
            this.comboBoxSchedule.TabIndex = 15;
            this.comboBoxSchedule.Text = "Seleccione una opcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "*Turno:";
            // 
            // textBoxCPassword
            // 
            this.textBoxCPassword.Location = new System.Drawing.Point(110, 258);
            this.textBoxCPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCPassword.Name = "textBoxCPassword";
            this.textBoxCPassword.PasswordChar = '●';
            this.textBoxCPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxCPassword.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "*Confirmar contraseña:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(110, 218);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "*Contraseña:";
            // 
            // comboBoxUsertype
            // 
            this.comboBoxUsertype.FormattingEnabled = true;
            this.comboBoxUsertype.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.comboBoxUsertype.Location = new System.Drawing.Point(110, 178);
            this.comboBoxUsertype.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUsertype.Name = "comboBoxUsertype";
            this.comboBoxUsertype.Size = new System.Drawing.Size(150, 21);
            this.comboBoxUsertype.TabIndex = 9;
            this.comboBoxUsertype.Text = "Seleccione una opcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Tipo de usuario:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(110, 145);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(150, 20);
            this.textBoxUsername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Nombre de usuario:";
            // 
            // textBoxMLastname
            // 
            this.textBoxMLastname.Location = new System.Drawing.Point(110, 105);
            this.textBoxMLastname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMLastname.Name = "textBoxMLastname";
            this.textBoxMLastname.Size = new System.Drawing.Size(150, 20);
            this.textBoxMLastname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "*Apellido materno:";
            // 
            // textBoxPLastname
            // 
            this.textBoxPLastname.Location = new System.Drawing.Point(110, 68);
            this.textBoxPLastname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPLastname.Name = "textBoxPLastname";
            this.textBoxPLastname.Size = new System.Drawing.Size(150, 20);
            this.textBoxPLastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Apellido paterno:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(110, 31);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nombre:";
            // 
            // groupBoxGridView
            // 
            this.groupBoxGridView.Controls.Add(this.dataGridView1);
            this.groupBoxGridView.Location = new System.Drawing.Point(9, 145);
            this.groupBoxGridView.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGridView.Name = "groupBoxGridView";
            this.groupBoxGridView.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGridView.Size = new System.Drawing.Size(676, 451);
            this.groupBoxGridView.TabIndex = 8;
            this.groupBoxGridView.TabStop = false;
            this.groupBoxGridView.Text = "Seleccione el usuario que desee modificar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.apodoDataGridViewTextBoxColumn,
            this.tipousuarioDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idusuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.Width = 125;
            // 
            // apodoDataGridViewTextBoxColumn
            // 
            this.apodoDataGridViewTextBoxColumn.DataPropertyName = "apodo";
            this.apodoDataGridViewTextBoxColumn.HeaderText = "apodo";
            this.apodoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apodoDataGridViewTextBoxColumn.Name = "apodoDataGridViewTextBoxColumn";
            this.apodoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipousuarioDataGridViewTextBoxColumn
            // 
            this.tipousuarioDataGridViewTextBoxColumn.DataPropertyName = "tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.HeaderText = "tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipousuarioDataGridViewTextBoxColumn.Name = "tipousuarioDataGridViewTextBoxColumn";
            this.tipousuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "turno";
            this.turnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.usuarioGVDS;
            // 
            // usuarioGVDS
            // 
            this.usuarioGVDS.DataSetName = "UsuarioGVDS";
            this.usuarioGVDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Peru;
            this.buttonLogout.Location = new System.Drawing.Point(854, 10);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 30);
            this.buttonLogout.TabIndex = 16;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // buttonPMenu
            // 
            this.buttonPMenu.BackColor = System.Drawing.Color.Peru;
            this.buttonPMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPMenu.Location = new System.Drawing.Point(9, 10);
            this.buttonPMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPMenu.Name = "buttonPMenu";
            this.buttonPMenu.Size = new System.Drawing.Size(106, 30);
            this.buttonPMenu.TabIndex = 20;
            this.buttonPMenu.Text = "Menu principal";
            this.buttonPMenu.UseVisualStyleBackColor = false;
            this.buttonPMenu.Click += new System.EventHandler(this.buttonPMenu_Click);
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.BackColor = System.Drawing.Color.Gold;
            this.buttonSearchUser.Location = new System.Drawing.Point(236, 75);
            this.buttonSearchUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(106, 30);
            this.buttonSearchUser.TabIndex = 15;
            this.buttonSearchUser.Text = "Buscar";
            this.buttonSearchUser.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SonoraCreativaV2_2.Properties.Resources.Logo_Sonora_Creativa___copia;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(457, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPMenu);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSearchUser);
            this.Controls.Add(this.buttonInfoUser);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.textBoxSUser);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.groupBoxRegisterUser);
            this.Controls.Add(this.groupBoxGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Usuarios";
            this.Text = "Administracion de Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.groupBoxRegisterUser.ResumeLayout(false);
            this.groupBoxRegisterUser.PerformLayout();
            this.groupBoxGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioGVDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.Button buttonInfoUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.TextBox textBoxSUser;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.GroupBox groupBoxRegisterUser;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCleanFields;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.ComboBox comboBoxSchedule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxUsertype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLogout;
        private UsuarioGVDS usuarioGVDS;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private UsuarioGVDSTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonPMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}