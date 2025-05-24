namespace Vista
{
    partial class FrmRegister
    {
        /// <summary>
        /// Variable del diseñador necesario.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.richTextdescrip = new System.Windows.Forms.RichTextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdProduct = new System.Windows.Forms.TextBox();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnActualizarP = new System.Windows.Forms.Button();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.txtIdMarcaP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtExis = new System.Windows.Forms.TextBox();
            this.richtxtDescrip = new System.Windows.Forms.RichTextBox();
            this.txtNmProduc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlHeader.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnAñadir);
            this.panel2.Controls.Add(this.richTextdescrip);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(879, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 631);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(158, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 30);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(274, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(380, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "ID ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(119, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marca";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.HotPink;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.btnEliminar.Location = new System.Drawing.Point(168, 520);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 40);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.HotPink;
            this.btnAñadir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.btnAñadir.Location = new System.Drawing.Point(168, 423);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(183, 41);
            this.btnAñadir.TabIndex = 6;
            this.btnAñadir.Text = "Añadir marca";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // richTextdescrip
            // 
            this.richTextdescrip.Location = new System.Drawing.Point(109, 264);
            this.richTextdescrip.Name = "richTextdescrip";
            this.richTextdescrip.Size = new System.Drawing.Size(265, 96);
            this.richTextdescrip.TabIndex = 5;
            this.richTextdescrip.Text = "";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.HotPink;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.btnActualizar.Location = new System.Drawing.Point(168, 470);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(183, 38);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar marca";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(122, 175);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(265, 22);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(66, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar una descripción de la nueva marca";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 631);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 631);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.txtIdProduct);
            this.panel1.Controls.Add(this.btnBuscarP);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnEliminarP);
            this.panel1.Controls.Add(this.btnActualizarP);
            this.panel1.Controls.Add(this.btnGuardarP);
            this.panel1.Controls.Add(this.txtCodigoP);
            this.panel1.Controls.Add(this.txtIdMarcaP);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbMarca);
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtExis);
            this.panel1.Controls.Add(this.richtxtDescrip);
            this.panel1.Controls.Add(this.txtNmProduc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 631);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtIdProduct
            // 
            this.txtIdProduct.Location = new System.Drawing.Point(311, 17);
            this.txtIdProduct.Name = "txtIdProduct";
            this.txtIdProduct.Size = new System.Drawing.Size(100, 22);
            this.txtIdProduct.TabIndex = 22;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.btnBuscarP.Location = new System.Drawing.Point(417, 12);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(83, 31);
            this.btnBuscarP.TabIndex = 21;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(278, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "ID";
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackColor = System.Drawing.Color.HotPink;
            this.btnEliminarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.btnEliminarP.Location = new System.Drawing.Point(299, 488);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(140, 31);
            this.btnEliminarP.TabIndex = 19;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = false;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnActualizarP
            // 
            this.btnActualizarP.BackColor = System.Drawing.Color.HotPink;
            this.btnActualizarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.btnActualizarP.Location = new System.Drawing.Point(299, 442);
            this.btnActualizarP.Name = "btnActualizarP";
            this.btnActualizarP.Size = new System.Drawing.Size(140, 37);
            this.btnActualizarP.TabIndex = 18;
            this.btnActualizarP.Text = "Actualizar producto";
            this.btnActualizarP.UseVisualStyleBackColor = false;
            this.btnActualizarP.Click += new System.EventHandler(this.btnActualizarP_Click);
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.BackColor = System.Drawing.Color.Orchid;
            this.btnGuardarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.btnGuardarP.Location = new System.Drawing.Point(299, 401);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(140, 35);
            this.btnGuardarP.TabIndex = 17;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = false;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(46, 520);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(137, 22);
            this.txtCodigoP.TabIndex = 16;
            this.txtCodigoP.TextChanged += new System.EventHandler(this.txtCodigoP_TextChanged);
            // 
            // txtIdMarcaP
            // 
            this.txtIdMarcaP.Location = new System.Drawing.Point(46, 443);
            this.txtIdMarcaP.Name = "txtIdMarcaP";
            this.txtIdMarcaP.Size = new System.Drawing.Size(100, 22);
            this.txtIdMarcaP.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(688, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Marca Selecionada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(43, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Código producto";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(668, 71);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(195, 24);
            this.cmbMarca.TabIndex = 12;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(42, 253);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(206, 22);
            this.dateTime.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(42, 384);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(169, 22);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtExis
            // 
            this.txtExis.Location = new System.Drawing.Point(42, 320);
            this.txtExis.Name = "txtExis";
            this.txtExis.Size = new System.Drawing.Size(98, 22);
            this.txtExis.TabIndex = 8;
            // 
            // richtxtDescrip
            // 
            this.richtxtDescrip.Location = new System.Drawing.Point(42, 139);
            this.richtxtDescrip.Name = "richtxtDescrip";
            this.richtxtDescrip.Size = new System.Drawing.Size(229, 96);
            this.richtxtDescrip.TabIndex = 7;
            this.richtxtDescrip.Text = "";
            this.richtxtDescrip.TextChanged += new System.EventHandler(this.richtxtDescrip_TextChanged);
            // 
            // txtNmProduc
            // 
            this.txtNmProduc.Location = new System.Drawing.Point(46, 64);
            this.txtNmProduc.Name = "txtNmProduc";
            this.txtNmProduc.Size = new System.Drawing.Size(225, 22);
            this.txtNmProduc.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(39, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Precio del producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(39, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Número de existencias del producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(43, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Agrega una descripción del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "¿Cómo se llamará el producto?";
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlHeader.Controls.Add(this.panel6);
            this.PnlHeader.Controls.Add(this.panel5);
            this.PnlHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PnlHeader.Size = new System.Drawing.Size(1370, 57);
            this.PnlHeader.TabIndex = 0;
            this.PnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHeader_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.btnMaximizar);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1158, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 57);
            this.panel5.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.BackgroundImage = global::Vista.Properties.Resources.less_3158;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Location = new System.Drawing.Point(27, 6);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(45, 48);
            this.button7.TabIndex = 2;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.BackgroundImage = global::Vista.Properties.Resources.x_close_icon_2591011;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(153, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(47, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximizar.BackgroundImage = global::Vista.Properties.Resources.window_icon_246149;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(88, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMaximizar.Size = new System.Drawing.Size(50, 48);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Location = new System.Drawing.Point(627, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 631);
            this.panel6.TabIndex = 23;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 688);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegister";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlHeader.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.RichTextBox richTextdescrip;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtExis;
        private System.Windows.Forms.RichTextBox richtxtDescrip;
        private System.Windows.Forms.TextBox txtNmProduc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdMarcaP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnActualizarP;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdProduct;
        private System.Windows.Forms.Panel panel6;
    }
}

