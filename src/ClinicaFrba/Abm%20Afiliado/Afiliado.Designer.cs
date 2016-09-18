namespace ClinicaFrba.Abm_Afiliado
{
    partial class Afiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Afiliado));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label plan_grupoLabel;
            this.gD2C2016DataSet = new ClinicaFrba.GD2C2016DataSet();
            this.afiliadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afiliadosTableAdapter = new ClinicaFrba.GD2C2016DataSetTableAdapters.AfiliadosTableAdapter();
            this.tableAdapterManager = new ClinicaFrba.GD2C2016DataSetTableAdapters.TableAdapterManager();
            this.afiliadosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.afiliadosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.grupos_FamiliaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupos_FamiliaresTableAdapter = new ClinicaFrba.GD2C2016DataSetTableAdapters.Grupos_FamiliaresTableAdapter();
            this.plan_grupoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.afiliadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxID = new System.Windows.Forms.CheckBox();
            this.checkBoxNom = new System.Windows.Forms.CheckBox();
            this.checkBoxAp = new System.Windows.Forms.CheckBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            plan_grupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosBindingNavigator)).BeginInit();
            this.afiliadosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupos_FamiliaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gD2C2016DataSet
            // 
            this.gD2C2016DataSet.DataSetName = "GD2C2016DataSet";
            this.gD2C2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // afiliadosBindingSource
            // 
            this.afiliadosBindingSource.DataMember = "Afiliados";
            this.afiliadosBindingSource.DataSource = this.gD2C2016DataSet;
            // 
            // afiliadosTableAdapter
            // 
            this.afiliadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AfiliadosTableAdapter = this.afiliadosTableAdapter;
            this.tableAdapterManager.Agenda_LaboralTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Bonos_ConsultasTableAdapter = null;
            this.tableAdapterManager.Bonos_FarmaciaTableAdapter = null;
            this.tableAdapterManager.CancelacionesTableAdapter = null;
            this.tableAdapterManager.DiagnosticosTableAdapter = null;
            this.tableAdapterManager.Especialidad_ProfesionalTableAdapter = null;
            this.tableAdapterManager.EspecialidadesTableAdapter = null;
            this.tableAdapterManager.Funciones_RolesTableAdapter = null;
            this.tableAdapterManager.FuncionesTableAdapter = null;
            this.tableAdapterManager.Grupos_FamiliaresTableAdapter = this.grupos_FamiliaresTableAdapter;
            this.tableAdapterManager.LogsCambioAfiliadosTableAdapter = null;
            this.tableAdapterManager.MaestraTableAdapter = null;
            this.tableAdapterManager.PlanesTableAdapter = null;
            this.tableAdapterManager.ProfesionalesTableAdapter = null;
            this.tableAdapterManager.Roles_UsuarioTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.Tipo_EspecialidadTableAdapter = null;
            this.tableAdapterManager.TransaccionesTableAdapter = null;
            this.tableAdapterManager.TurnosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ClinicaFrba.GD2C2016DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // afiliadosBindingNavigator
            // 
            this.afiliadosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.afiliadosBindingNavigator.BindingSource = this.afiliadosBindingSource;
            this.afiliadosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.afiliadosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.afiliadosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.afiliadosBindingNavigatorSaveItem});
            this.afiliadosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.afiliadosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.afiliadosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.afiliadosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.afiliadosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.afiliadosBindingNavigator.Name = "afiliadosBindingNavigator";
            this.afiliadosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.afiliadosBindingNavigator.Size = new System.Drawing.Size(882, 25);
            this.afiliadosBindingNavigator.TabIndex = 0;
            this.afiliadosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // afiliadosBindingNavigatorSaveItem
            // 
            this.afiliadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.afiliadosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("afiliadosBindingNavigatorSaveItem.Image")));
            this.afiliadosBindingNavigatorSaveItem.Name = "afiliadosBindingNavigatorSaveItem";
            this.afiliadosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.afiliadosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.afiliadosBindingNavigatorSaveItem.Click += new System.EventHandler(this.afiliadosBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(36, 79);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(103, 79);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(36, 115);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(103, 108);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(36, 148);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 5;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(103, 148);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(121, 20);
            this.apellidoTextBox.TabIndex = 6;
            // 
            // grupos_FamiliaresBindingSource
            // 
            this.grupos_FamiliaresBindingSource.DataMember = "Grupos_Familiares";
            this.grupos_FamiliaresBindingSource.DataSource = this.gD2C2016DataSet;
            // 
            // grupos_FamiliaresTableAdapter
            // 
            this.grupos_FamiliaresTableAdapter.ClearBeforeFill = true;
            // 
            // plan_grupoLabel
            // 
            plan_grupoLabel.AutoSize = true;
            plan_grupoLabel.Location = new System.Drawing.Point(272, 78);
            plan_grupoLabel.Name = "plan_grupoLabel";
            plan_grupoLabel.Size = new System.Drawing.Size(61, 13);
            plan_grupoLabel.TabIndex = 7;
            plan_grupoLabel.Text = "Plan grupo:";
            // 
            // plan_grupoComboBox
            // 
            this.plan_grupoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupos_FamiliaresBindingSource, "Plan_grupo", true));
            this.plan_grupoComboBox.FormattingEnabled = true;
            this.plan_grupoComboBox.Location = new System.Drawing.Point(339, 75);
            this.plan_grupoComboBox.Name = "plan_grupoComboBox";
            this.plan_grupoComboBox.Size = new System.Drawing.Size(121, 21);
            this.plan_grupoComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // afiliadosDataGridView
            // 
            this.afiliadosDataGridView.AutoGenerateColumns = false;
            this.afiliadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afiliadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn15,
            this.Modificar});
            this.afiliadosDataGridView.DataSource = this.afiliadosBindingSource;
            this.afiliadosDataGridView.Location = new System.Drawing.Point(29, 271);
            this.afiliadosDataGridView.Name = "afiliadosDataGridView";
            this.afiliadosDataGridView.Size = new System.Drawing.Size(803, 221);
            this.afiliadosDataGridView.TabIndex = 11;
            this.afiliadosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.afiliadosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Numero_de_grupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero_de_grupo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Numero_en_el_grupo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Numero_en_el_grupo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tipo_doc";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tipo_doc";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Numero_doc";
            this.dataGridViewTextBoxColumn7.HeaderText = "Numero_doc";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn9.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Fecha_nacimiento";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fecha_nacimiento";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Estado_civil";
            this.dataGridViewTextBoxColumn13.HeaderText = "Estado_civil";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Familiares_a_cargo";
            this.dataGridViewTextBoxColumn14.HeaderText = "Familiares_a_cargo";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Esta_activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Esta_activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Nombre_usuario";
            this.dataGridViewTextBoxColumn15.HeaderText = "Nombre_usuario";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dato exacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Buscar Afiliado";
            // 
            // checkBoxID
            // 
            this.checkBoxID.AutoSize = true;
            this.checkBoxID.Location = new System.Drawing.Point(230, 82);
            this.checkBoxID.Name = "checkBoxID";
            this.checkBoxID.Size = new System.Drawing.Size(15, 14);
            this.checkBoxID.TabIndex = 13;
            this.checkBoxID.UseVisualStyleBackColor = true;
            // 
            // checkBoxNom
            // 
            this.checkBoxNom.AutoSize = true;
            this.checkBoxNom.Location = new System.Drawing.Point(230, 111);
            this.checkBoxNom.Name = "checkBoxNom";
            this.checkBoxNom.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNom.TabIndex = 14;
            this.checkBoxNom.UseVisualStyleBackColor = true;
            // 
            // checkBoxAp
            // 
            this.checkBoxAp.AutoSize = true;
            this.checkBoxAp.Location = new System.Drawing.Point(230, 150);
            this.checkBoxAp.Name = "checkBoxAp";
            this.checkBoxAp.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAp.TabIndex = 15;
            this.checkBoxAp.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(489, 148);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 16;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(489, 102);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 17;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 499);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.checkBoxAp);
            this.Controls.Add(this.checkBoxNom);
            this.Controls.Add(this.checkBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.afiliadosDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(plan_grupoLabel);
            this.Controls.Add(this.plan_grupoComboBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.afiliadosBindingNavigator);
            this.Name = "Afiliado";
            this.Text = "Afiliado";
            this.Load += new System.EventHandler(this.Afiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosBindingNavigator)).EndInit();
            this.afiliadosBindingNavigator.ResumeLayout(false);
            this.afiliadosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupos_FamiliaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GD2C2016DataSet gD2C2016DataSet;
        private System.Windows.Forms.BindingSource afiliadosBindingSource;
        private GD2C2016DataSetTableAdapters.AfiliadosTableAdapter afiliadosTableAdapter;
        private GD2C2016DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator afiliadosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton afiliadosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private GD2C2016DataSetTableAdapters.Grupos_FamiliaresTableAdapter grupos_FamiliaresTableAdapter;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.BindingSource grupos_FamiliaresBindingSource;
        private System.Windows.Forms.ComboBox plan_grupoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView afiliadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewLinkColumn Modificar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxID;
        private System.Windows.Forms.CheckBox checkBoxNom;
        private System.Windows.Forms.CheckBox checkBoxAp;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Limpiar;
    }
}