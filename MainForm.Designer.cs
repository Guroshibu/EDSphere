namespace EDSphere
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblCenterX = new System.Windows.Forms.Label();
            this.tbxCenterX = new System.Windows.Forms.TextBox();
            this.lblCenterY = new System.Windows.Forms.Label();
            this.tbxCenterY = new System.Windows.Forms.TextBox();
            this.lblCenterZ = new System.Windows.Forms.Label();
            this.tbxCenterZ = new System.Windows.Forms.TextBox();
            this.lblCenterRadius = new System.Windows.Forms.Label();
            this.tbxCenterRadius = new System.Windows.Forms.TextBox();
            this.lblCurentSystem = new System.Windows.Forms.Label();
            this.lblCurrentX = new System.Windows.Forms.Label();
            this.tbxCurrentX = new System.Windows.Forms.TextBox();
            this.lblCurrentY = new System.Windows.Forms.Label();
            this.tbxCurrentY = new System.Windows.Forms.TextBox();
            this.lblCurrentZ = new System.Windows.Forms.Label();
            this.tbxCurrentZ = new System.Windows.Forms.TextBox();
            this.lblCurrentRadius = new System.Windows.Forms.Label();
            this.tbxCurrentRadius = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.contextMenuStripSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SearchAddToRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSpan = new System.Windows.Forms.Label();
            this.tbxSpan = new System.Windows.Forms.TextBox();
            this.gbxCenter = new System.Windows.Forms.GroupBox();
            this.btnCenterCoordinates = new System.Windows.Forms.Button();
            this.tbxCenterSystem = new System.Windows.Forms.TextBox();
            this.lblCerterSystem = new System.Windows.Forms.Label();
            this.gpbCurrent = new System.Windows.Forms.GroupBox();
            this.btnCurrentCoordinates = new System.Windows.Forms.Button();
            this.tbxCurrentSystem = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.tabPageRoute = new System.Windows.Forms.TabPage();
            this.dgvRoute = new System.Windows.Forms.DataGridView();
            this.dgvRouteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRoutePassed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvRoutePoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRouteSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRouteX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRouteY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRouteZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRouteComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripRoute = new System.Windows.Forms.MenuStrip();
            this.RouteDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RouteDeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageSearch3D = new System.Windows.Forms.TabPage();
            this.panelSearchChartButtons = new System.Windows.Forms.Panel();
            this.btnSeriseChartAddToRoute = new System.Windows.Forms.Button();
            this.tbxSearchChartSelecned = new System.Windows.Forms.TextBox();
            this.lblSearchChartSelected = new System.Windows.Forms.Label();
            this.lblChartSearchAngleY = new System.Windows.Forms.Label();
            this.lblChartSearchAngleX = new System.Windows.Forms.Label();
            this.nudChartSearchAngleY = new System.Windows.Forms.NumericUpDown();
            this.nudChartSearchAngleX = new System.Windows.Forms.NumericUpDown();
            this.chartSearch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStripSearch3D = new System.Windows.Forms.MenuStrip();
            this.Search3DShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartSearch3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageRoute3D = new System.Windows.Forms.TabPage();
            this.panelRouteChartButtons = new System.Windows.Forms.Panel();
            this.tbxChartRouteJump = new System.Windows.Forms.TextBox();
            this.lblChartRouteJump = new System.Windows.Forms.Label();
            this.tbxChartRouteSelected = new System.Windows.Forms.TextBox();
            this.lblSearchRouteSelected = new System.Windows.Forms.Label();
            this.lblChartRouteAngleY = new System.Windows.Forms.Label();
            this.lblChartRouteAngleX = new System.Windows.Forms.Label();
            this.nudChartRouteAngleY = new System.Windows.Forms.NumericUpDown();
            this.nudChartRouteAngleX = new System.Windows.Forms.NumericUpDown();
            this.chartRoute = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStripRoute3D = new System.Windows.Forms.MenuStrip();
            this.Route3DShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCoordsOnSphere = new System.Windows.Forms.TabPage();
            this.dgvCoords = new System.Windows.Forms.DataGridView();
            this.dgvcCooordsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCooordsX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCooordsY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCooordsZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCopied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcCooordsSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCooordsSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCooordsSY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCooordsSZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripCoords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CoordsCopyToSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CoordsAddSystemToRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCoordsOnSphere = new System.Windows.Forms.Panel();
            this.btnCoordsToRoute = new System.Windows.Forms.Button();
            this.lblCoordsStatus = new System.Windows.Forms.Label();
            this.btnCoordsCalculate = new System.Windows.Forms.Button();
            this.lblCoordsStep = new System.Windows.Forms.Label();
            this.nudCoordsStep = new System.Windows.Forms.NumericUpDown();
            this.tabPageBacup = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnFrom = new System.Windows.Forms.Button();
            this.dgvcSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCenterDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCurrentDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAngleH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAngleV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.contextMenuStripSearch.SuspendLayout();
            this.gbxCenter.SuspendLayout();
            this.gpbCurrent.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).BeginInit();
            this.menuStripRoute.SuspendLayout();
            this.tabPageSearch3D.SuspendLayout();
            this.panelSearchChartButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartSearchAngleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartSearchAngleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSearch)).BeginInit();
            this.menuStripSearch3D.SuspendLayout();
            this.tabPageRoute3D.SuspendLayout();
            this.panelRouteChartButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartRouteAngleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartRouteAngleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoute)).BeginInit();
            this.menuStripRoute3D.SuspendLayout();
            this.tabCoordsOnSphere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoords)).BeginInit();
            this.contextMenuStripCoords.SuspendLayout();
            this.panelCoordsOnSphere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoordsStep)).BeginInit();
            this.tabPageBacup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCenterX
            // 
            this.lblCenterX.AutoSize = true;
            this.lblCenterX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCenterX.Location = new System.Drawing.Point(6, 47);
            this.lblCenterX.Name = "lblCenterX";
            this.lblCenterX.Size = new System.Drawing.Size(19, 16);
            this.lblCenterX.TabIndex = 1;
            this.lblCenterX.Text = "X:";
            // 
            // tbxCenterX
            // 
            this.tbxCenterX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCenterX.Location = new System.Drawing.Point(31, 43);
            this.tbxCenterX.Name = "tbxCenterX";
            this.tbxCenterX.Size = new System.Drawing.Size(130, 22);
            this.tbxCenterX.TabIndex = 2;
            this.tbxCenterX.Text = "0";
            this.tbxCenterX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCenterX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCenterX_KeyPress);
            // 
            // lblCenterY
            // 
            this.lblCenterY.AutoSize = true;
            this.lblCenterY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCenterY.Location = new System.Drawing.Point(167, 47);
            this.lblCenterY.Name = "lblCenterY";
            this.lblCenterY.Size = new System.Drawing.Size(20, 16);
            this.lblCenterY.TabIndex = 3;
            this.lblCenterY.Text = "Y:";
            // 
            // tbxCenterY
            // 
            this.tbxCenterY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCenterY.Location = new System.Drawing.Point(193, 44);
            this.tbxCenterY.Name = "tbxCenterY";
            this.tbxCenterY.Size = new System.Drawing.Size(130, 22);
            this.tbxCenterY.TabIndex = 4;
            this.tbxCenterY.Text = "0";
            this.tbxCenterY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCenterZ
            // 
            this.lblCenterZ.AutoSize = true;
            this.lblCenterZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCenterZ.Location = new System.Drawing.Point(329, 47);
            this.lblCenterZ.Name = "lblCenterZ";
            this.lblCenterZ.Size = new System.Drawing.Size(19, 16);
            this.lblCenterZ.TabIndex = 5;
            this.lblCenterZ.Text = "Z:";
            // 
            // tbxCenterZ
            // 
            this.tbxCenterZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCenterZ.Location = new System.Drawing.Point(354, 44);
            this.tbxCenterZ.Name = "tbxCenterZ";
            this.tbxCenterZ.Size = new System.Drawing.Size(130, 22);
            this.tbxCenterZ.TabIndex = 6;
            this.tbxCenterZ.Text = "0";
            this.tbxCenterZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCenterRadius
            // 
            this.lblCenterRadius.AutoSize = true;
            this.lblCenterRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCenterRadius.Location = new System.Drawing.Point(490, 46);
            this.lblCenterRadius.Name = "lblCenterRadius";
            this.lblCenterRadius.Size = new System.Drawing.Size(156, 16);
            this.lblCenterRadius.TabIndex = 7;
            this.lblCenterRadius.Text = "Расстояние от центра:";
            // 
            // tbxCenterRadius
            // 
            this.tbxCenterRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCenterRadius.Location = new System.Drawing.Point(653, 43);
            this.tbxCenterRadius.Name = "tbxCenterRadius";
            this.tbxCenterRadius.Size = new System.Drawing.Size(61, 22);
            this.tbxCenterRadius.TabIndex = 8;
            this.tbxCenterRadius.Text = "500";
            this.tbxCenterRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurentSystem
            // 
            this.lblCurentSystem.AutoSize = true;
            this.lblCurentSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurentSystem.Location = new System.Drawing.Point(6, 18);
            this.lblCurentSystem.Name = "lblCurentSystem";
            this.lblCurentSystem.Size = new System.Drawing.Size(67, 16);
            this.lblCurentSystem.TabIndex = 9;
            this.lblCurentSystem.Text = "Система:";
            // 
            // lblCurrentX
            // 
            this.lblCurrentX.AutoSize = true;
            this.lblCurrentX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentX.Location = new System.Drawing.Point(6, 46);
            this.lblCurrentX.Name = "lblCurrentX";
            this.lblCurrentX.Size = new System.Drawing.Size(19, 16);
            this.lblCurrentX.TabIndex = 10;
            this.lblCurrentX.Text = "X:";
            // 
            // tbxCurrentX
            // 
            this.tbxCurrentX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCurrentX.Location = new System.Drawing.Point(31, 43);
            this.tbxCurrentX.Name = "tbxCurrentX";
            this.tbxCurrentX.Size = new System.Drawing.Size(130, 22);
            this.tbxCurrentX.TabIndex = 11;
            this.tbxCurrentX.Text = "0";
            this.tbxCurrentX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrentY
            // 
            this.lblCurrentY.AutoSize = true;
            this.lblCurrentY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentY.Location = new System.Drawing.Point(167, 46);
            this.lblCurrentY.Name = "lblCurrentY";
            this.lblCurrentY.Size = new System.Drawing.Size(20, 16);
            this.lblCurrentY.TabIndex = 12;
            this.lblCurrentY.Text = "Y:";
            // 
            // tbxCurrentY
            // 
            this.tbxCurrentY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCurrentY.Location = new System.Drawing.Point(193, 43);
            this.tbxCurrentY.Name = "tbxCurrentY";
            this.tbxCurrentY.Size = new System.Drawing.Size(130, 22);
            this.tbxCurrentY.TabIndex = 13;
            this.tbxCurrentY.Text = "0";
            this.tbxCurrentY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrentZ
            // 
            this.lblCurrentZ.AutoSize = true;
            this.lblCurrentZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentZ.Location = new System.Drawing.Point(329, 46);
            this.lblCurrentZ.Name = "lblCurrentZ";
            this.lblCurrentZ.Size = new System.Drawing.Size(19, 16);
            this.lblCurrentZ.TabIndex = 14;
            this.lblCurrentZ.Text = "Z:";
            // 
            // tbxCurrentZ
            // 
            this.tbxCurrentZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCurrentZ.Location = new System.Drawing.Point(354, 43);
            this.tbxCurrentZ.Name = "tbxCurrentZ";
            this.tbxCurrentZ.Size = new System.Drawing.Size(130, 22);
            this.tbxCurrentZ.TabIndex = 15;
            this.tbxCurrentZ.Text = "0";
            this.tbxCurrentZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrentRadius
            // 
            this.lblCurrentRadius.AutoSize = true;
            this.lblCurrentRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentRadius.Location = new System.Drawing.Point(490, 46);
            this.lblCurrentRadius.Name = "lblCurrentRadius";
            this.lblCurrentRadius.Size = new System.Drawing.Size(108, 16);
            this.lblCurrentRadius.TabIndex = 16;
            this.lblCurrentRadius.Text = "Радиус поиска:";
            // 
            // tbxCurrentRadius
            // 
            this.tbxCurrentRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCurrentRadius.Location = new System.Drawing.Point(604, 43);
            this.tbxCurrentRadius.Name = "tbxCurrentRadius";
            this.tbxCurrentRadius.Size = new System.Drawing.Size(82, 22);
            this.tbxCurrentRadius.TabIndex = 17;
            this.tbxCurrentRadius.Text = "100";
            this.tbxCurrentRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(6, 183);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxResult
            // 
            this.tbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResult.BackColor = System.Drawing.Color.Silver;
            this.tbxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxResult.Location = new System.Drawing.Point(105, 184);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(668, 22);
            this.tbxResult.TabIndex = 19;
            // 
            // pnlResult
            // 
            this.pnlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResult.Controls.Add(this.dgvResult);
            this.pnlResult.Location = new System.Drawing.Point(3, 212);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(770, 321);
            this.pnlResult.TabIndex = 20;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcSystem,
            this.dgvcCenterDistance,
            this.dgvcCurrentDistance,
            this.dgvcX,
            this.dgvcY,
            this.dgvcZ,
            this.dgvcAngleH,
            this.dgvcAngleV});
            this.dgvResult.ContextMenuStrip = this.contextMenuStripSearch;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(0, 0);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(770, 321);
            this.dgvResult.TabIndex = 0;
            // 
            // contextMenuStripSearch
            // 
            this.contextMenuStripSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchAddToRouteToolStripMenuItem});
            this.contextMenuStripSearch.Name = "contextMenuStripSearch";
            this.contextMenuStripSearch.Size = new System.Drawing.Size(190, 26);
            // 
            // SearchAddToRouteToolStripMenuItem
            // 
            this.SearchAddToRouteToolStripMenuItem.Name = "SearchAddToRouteToolStripMenuItem";
            this.SearchAddToRouteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.SearchAddToRouteToolStripMenuItem.Text = "Добавить в маршрут";
            this.SearchAddToRouteToolStripMenuItem.Click += new System.EventHandler(this.SearchAddToRouteToolStripMenuItem_Click);
            // 
            // lblSpan
            // 
            this.lblSpan.AutoSize = true;
            this.lblSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpan.Location = new System.Drawing.Point(3, 164);
            this.lblSpan.Name = "lblSpan";
            this.lblSpan.Size = new System.Drawing.Size(238, 16);
            this.lblSpan.TabIndex = 21;
            this.lblSpan.Text = "Отклонение расстояния до центра:";
            // 
            // tbxSpan
            // 
            this.tbxSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSpan.Location = new System.Drawing.Point(247, 161);
            this.tbxSpan.Name = "tbxSpan";
            this.tbxSpan.Size = new System.Drawing.Size(85, 22);
            this.tbxSpan.TabIndex = 22;
            this.tbxSpan.Text = "5";
            this.tbxSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxCenter
            // 
            this.gbxCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCenter.Controls.Add(this.btnCenterCoordinates);
            this.gbxCenter.Controls.Add(this.tbxCenterSystem);
            this.gbxCenter.Controls.Add(this.lblCerterSystem);
            this.gbxCenter.Controls.Add(this.lblCenterX);
            this.gbxCenter.Controls.Add(this.tbxCenterX);
            this.gbxCenter.Controls.Add(this.lblCenterZ);
            this.gbxCenter.Controls.Add(this.lblCenterY);
            this.gbxCenter.Controls.Add(this.tbxCenterY);
            this.gbxCenter.Controls.Add(this.tbxCenterZ);
            this.gbxCenter.Controls.Add(this.lblCenterRadius);
            this.gbxCenter.Controls.Add(this.tbxCenterRadius);
            this.gbxCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxCenter.Location = new System.Drawing.Point(3, 6);
            this.gbxCenter.Name = "gbxCenter";
            this.gbxCenter.Size = new System.Drawing.Size(770, 75);
            this.gbxCenter.TabIndex = 23;
            this.gbxCenter.TabStop = false;
            this.gbxCenter.Text = "Центр";
            // 
            // btnCenterCoordinates
            // 
            this.btnCenterCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCenterCoordinates.Location = new System.Drawing.Point(427, 15);
            this.btnCenterCoordinates.Name = "btnCenterCoordinates";
            this.btnCenterCoordinates.Size = new System.Drawing.Size(219, 23);
            this.btnCenterCoordinates.TabIndex = 26;
            this.btnCenterCoordinates.Text = "Получить координаты";
            this.btnCenterCoordinates.UseVisualStyleBackColor = true;
            this.btnCenterCoordinates.Click += new System.EventHandler(this.btnCenterCoordinates_Click);
            // 
            // tbxCenterSystem
            // 
            this.tbxCenterSystem.Location = new System.Drawing.Point(79, 15);
            this.tbxCenterSystem.Name = "tbxCenterSystem";
            this.tbxCenterSystem.Size = new System.Drawing.Size(342, 22);
            this.tbxCenterSystem.TabIndex = 25;
            this.tbxCenterSystem.Text = "Sol";
            // 
            // lblCerterSystem
            // 
            this.lblCerterSystem.AutoSize = true;
            this.lblCerterSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCerterSystem.Location = new System.Drawing.Point(6, 18);
            this.lblCerterSystem.Name = "lblCerterSystem";
            this.lblCerterSystem.Size = new System.Drawing.Size(67, 16);
            this.lblCerterSystem.TabIndex = 24;
            this.lblCerterSystem.Text = "Система:";
            // 
            // gpbCurrent
            // 
            this.gpbCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCurrent.Controls.Add(this.btnCurrentCoordinates);
            this.gpbCurrent.Controls.Add(this.tbxCurrentSystem);
            this.gpbCurrent.Controls.Add(this.lblCurentSystem);
            this.gpbCurrent.Controls.Add(this.lblCurrentZ);
            this.gpbCurrent.Controls.Add(this.lblCurrentX);
            this.gpbCurrent.Controls.Add(this.tbxCurrentX);
            this.gpbCurrent.Controls.Add(this.lblCurrentY);
            this.gpbCurrent.Controls.Add(this.tbxCurrentY);
            this.gpbCurrent.Controls.Add(this.tbxCurrentRadius);
            this.gpbCurrent.Controls.Add(this.tbxCurrentZ);
            this.gpbCurrent.Controls.Add(this.lblCurrentRadius);
            this.gpbCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpbCurrent.Location = new System.Drawing.Point(3, 87);
            this.gpbCurrent.Name = "gpbCurrent";
            this.gpbCurrent.Size = new System.Drawing.Size(770, 74);
            this.gpbCurrent.TabIndex = 24;
            this.gpbCurrent.TabStop = false;
            this.gpbCurrent.Text = "Текущая система:";
            // 
            // btnCurrentCoordinates
            // 
            this.btnCurrentCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCurrentCoordinates.Location = new System.Drawing.Point(427, 14);
            this.btnCurrentCoordinates.Name = "btnCurrentCoordinates";
            this.btnCurrentCoordinates.Size = new System.Drawing.Size(219, 23);
            this.btnCurrentCoordinates.TabIndex = 27;
            this.btnCurrentCoordinates.Text = "Получить координаты";
            this.btnCurrentCoordinates.UseVisualStyleBackColor = true;
            this.btnCurrentCoordinates.Click += new System.EventHandler(this.btnCurrentCoordinates_Click);
            // 
            // tbxCurrentSystem
            // 
            this.tbxCurrentSystem.Location = new System.Drawing.Point(79, 15);
            this.tbxCurrentSystem.Name = "tbxCurrentSystem";
            this.tbxCurrentSystem.Size = new System.Drawing.Size(342, 22);
            this.tbxCurrentSystem.TabIndex = 26;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSearch);
            this.tabControl.Controls.Add(this.tabPageRoute);
            this.tabControl.Controls.Add(this.tabPageSearch3D);
            this.tabControl.Controls.Add(this.tabPageRoute3D);
            this.tabControl.Controls.Add(this.tabCoordsOnSphere);
            this.tabControl.Controls.Add(this.tabPageBacup);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 562);
            this.tabControl.TabIndex = 25;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackColor = System.Drawing.Color.LightGray;
            this.tabPageSearch.Controls.Add(this.pnlResult);
            this.tabPageSearch.Controls.Add(this.gbxCenter);
            this.tabPageSearch.Controls.Add(this.gpbCurrent);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Controls.Add(this.tbxResult);
            this.tabPageSearch.Controls.Add(this.tbxSpan);
            this.tabPageSearch.Controls.Add(this.lblSpan);
            this.tabPageSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(776, 536);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Поиск";
            // 
            // tabPageRoute
            // 
            this.tabPageRoute.BackColor = System.Drawing.Color.LightGray;
            this.tabPageRoute.Controls.Add(this.dgvRoute);
            this.tabPageRoute.Controls.Add(this.menuStripRoute);
            this.tabPageRoute.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoute.Name = "tabPageRoute";
            this.tabPageRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoute.Size = new System.Drawing.Size(776, 536);
            this.tabPageRoute.TabIndex = 1;
            this.tabPageRoute.Text = "Маршрут";
            // 
            // dgvRoute
            // 
            this.dgvRoute.AllowUserToAddRows = false;
            this.dgvRoute.AllowUserToDeleteRows = false;
            this.dgvRoute.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoute.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRouteID,
            this.dgvRoutePassed,
            this.dgvRoutePoint,
            this.dgvRouteSystem,
            this.dgvRouteX,
            this.dgvRouteY,
            this.dgvRouteZ,
            this.dgvRouteComment});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoute.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoute.Location = new System.Drawing.Point(3, 27);
            this.dgvRoute.Name = "dgvRoute";
            this.dgvRoute.Size = new System.Drawing.Size(770, 506);
            this.dgvRoute.TabIndex = 1;
            this.dgvRoute.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoute_CellEndEdit);
            // 
            // dgvRouteID
            // 
            this.dgvRouteID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvRouteID.DataPropertyName = "ID";
            this.dgvRouteID.Frozen = true;
            this.dgvRouteID.HeaderText = "ID";
            this.dgvRouteID.Name = "dgvRouteID";
            this.dgvRouteID.ReadOnly = true;
            this.dgvRouteID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRouteID.Width = 46;
            // 
            // dgvRoutePassed
            // 
            this.dgvRoutePassed.DataPropertyName = "Passed";
            this.dgvRoutePassed.FalseValue = "0";
            this.dgvRoutePassed.Frozen = true;
            this.dgvRoutePassed.HeaderText = "Пройдено";
            this.dgvRoutePassed.IndeterminateValue = "0";
            this.dgvRoutePassed.MinimumWidth = 80;
            this.dgvRoutePassed.Name = "dgvRoutePassed";
            this.dgvRoutePassed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoutePassed.TrueValue = "1";
            this.dgvRoutePassed.Width = 80;
            // 
            // dgvRoutePoint
            // 
            this.dgvRoutePoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvRoutePoint.DataPropertyName = "Point";
            this.dgvRoutePoint.Frozen = true;
            this.dgvRoutePoint.HeaderText = "Точка";
            this.dgvRoutePoint.Name = "dgvRoutePoint";
            this.dgvRoutePoint.Width = 73;
            // 
            // dgvRouteSystem
            // 
            this.dgvRouteSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvRouteSystem.DataPropertyName = "System";
            this.dgvRouteSystem.HeaderText = "Система";
            this.dgvRouteSystem.Name = "dgvRouteSystem";
            this.dgvRouteSystem.ReadOnly = true;
            this.dgvRouteSystem.Width = 89;
            // 
            // dgvRouteX
            // 
            this.dgvRouteX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvRouteX.DataPropertyName = "X";
            this.dgvRouteX.HeaderText = "X";
            this.dgvRouteX.Name = "dgvRouteX";
            this.dgvRouteX.ReadOnly = true;
            this.dgvRouteX.Width = 41;
            // 
            // dgvRouteY
            // 
            this.dgvRouteY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvRouteY.DataPropertyName = "Y";
            this.dgvRouteY.HeaderText = "Y";
            this.dgvRouteY.Name = "dgvRouteY";
            this.dgvRouteY.ReadOnly = true;
            this.dgvRouteY.Width = 42;
            // 
            // dgvRouteZ
            // 
            this.dgvRouteZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvRouteZ.DataPropertyName = "Z";
            this.dgvRouteZ.HeaderText = "Z";
            this.dgvRouteZ.Name = "dgvRouteZ";
            this.dgvRouteZ.ReadOnly = true;
            this.dgvRouteZ.Width = 41;
            // 
            // dgvRouteComment
            // 
            this.dgvRouteComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dgvRouteComment.DataPropertyName = "Comment";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRouteComment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRouteComment.HeaderText = "Комментарий";
            this.dgvRouteComment.MinimumWidth = 300;
            this.dgvRouteComment.Name = "dgvRouteComment";
            this.dgvRouteComment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvRouteComment.Width = 300;
            // 
            // menuStripRoute
            // 
            this.menuStripRoute.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RouteDeleteToolStripMenuItem,
            this.RouteDeleteAllToolStripMenuItem});
            this.menuStripRoute.Location = new System.Drawing.Point(3, 3);
            this.menuStripRoute.Name = "menuStripRoute";
            this.menuStripRoute.Size = new System.Drawing.Size(770, 24);
            this.menuStripRoute.TabIndex = 0;
            this.menuStripRoute.Text = "menuStrip1";
            // 
            // RouteDeleteToolStripMenuItem
            // 
            this.RouteDeleteToolStripMenuItem.Name = "RouteDeleteToolStripMenuItem";
            this.RouteDeleteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.RouteDeleteToolStripMenuItem.Text = "Удалить";
            this.RouteDeleteToolStripMenuItem.Click += new System.EventHandler(this.RouteDeleteToolStripMenuItem_Click);
            // 
            // RouteDeleteAllToolStripMenuItem
            // 
            this.RouteDeleteAllToolStripMenuItem.Name = "RouteDeleteAllToolStripMenuItem";
            this.RouteDeleteAllToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.RouteDeleteAllToolStripMenuItem.Text = "Удалить всё";
            this.RouteDeleteAllToolStripMenuItem.Click += new System.EventHandler(this.RouteDeleteAllToolStripMenuItem_Click);
            // 
            // tabPageSearch3D
            // 
            this.tabPageSearch3D.Controls.Add(this.panelSearchChartButtons);
            this.tabPageSearch3D.Controls.Add(this.chartSearch);
            this.tabPageSearch3D.Controls.Add(this.menuStripSearch3D);
            this.tabPageSearch3D.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch3D.Name = "tabPageSearch3D";
            this.tabPageSearch3D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch3D.Size = new System.Drawing.Size(776, 536);
            this.tabPageSearch3D.TabIndex = 3;
            this.tabPageSearch3D.Text = "Поиск3D";
            this.tabPageSearch3D.UseVisualStyleBackColor = true;
            // 
            // panelSearchChartButtons
            // 
            this.panelSearchChartButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearchChartButtons.BackColor = System.Drawing.Color.Black;
            this.panelSearchChartButtons.Controls.Add(this.btnSeriseChartAddToRoute);
            this.panelSearchChartButtons.Controls.Add(this.tbxSearchChartSelecned);
            this.panelSearchChartButtons.Controls.Add(this.lblSearchChartSelected);
            this.panelSearchChartButtons.Controls.Add(this.lblChartSearchAngleY);
            this.panelSearchChartButtons.Controls.Add(this.lblChartSearchAngleX);
            this.panelSearchChartButtons.Controls.Add(this.nudChartSearchAngleY);
            this.panelSearchChartButtons.Controls.Add(this.nudChartSearchAngleX);
            this.panelSearchChartButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelSearchChartButtons.Location = new System.Drawing.Point(3, 472);
            this.panelSearchChartButtons.Name = "panelSearchChartButtons";
            this.panelSearchChartButtons.Size = new System.Drawing.Size(770, 61);
            this.panelSearchChartButtons.TabIndex = 2;
            // 
            // btnSeriseChartAddToRoute
            // 
            this.btnSeriseChartAddToRoute.Location = new System.Drawing.Point(125, 32);
            this.btnSeriseChartAddToRoute.Name = "btnSeriseChartAddToRoute";
            this.btnSeriseChartAddToRoute.Size = new System.Drawing.Size(161, 23);
            this.btnSeriseChartAddToRoute.TabIndex = 10;
            this.btnSeriseChartAddToRoute.Text = "Добавить в маршрут";
            this.btnSeriseChartAddToRoute.UseVisualStyleBackColor = true;
            this.btnSeriseChartAddToRoute.Click += new System.EventHandler(this.btnSeriseChartAddToRoute_Click);
            // 
            // tbxSearchChartSelecned
            // 
            this.tbxSearchChartSelecned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSearchChartSelecned.Location = new System.Drawing.Point(269, 4);
            this.tbxSearchChartSelecned.Name = "tbxSearchChartSelecned";
            this.tbxSearchChartSelecned.Size = new System.Drawing.Size(272, 22);
            this.tbxSearchChartSelecned.TabIndex = 9;
            // 
            // lblSearchChartSelected
            // 
            this.lblSearchChartSelected.AutoSize = true;
            this.lblSearchChartSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchChartSelected.ForeColor = System.Drawing.Color.White;
            this.lblSearchChartSelected.Location = new System.Drawing.Point(122, 7);
            this.lblSearchChartSelected.Name = "lblSearchChartSelected";
            this.lblSearchChartSelected.Size = new System.Drawing.Size(141, 16);
            this.lblSearchChartSelected.TabIndex = 8;
            this.lblSearchChartSelected.Text = "Выбранная система:";
            this.lblSearchChartSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChartSearchAngleY
            // 
            this.lblChartSearchAngleY.AutoSize = true;
            this.lblChartSearchAngleY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChartSearchAngleY.ForeColor = System.Drawing.Color.White;
            this.lblChartSearchAngleY.Location = new System.Drawing.Point(3, 35);
            this.lblChartSearchAngleY.Name = "lblChartSearchAngleY";
            this.lblChartSearchAngleY.Size = new System.Drawing.Size(51, 16);
            this.lblChartSearchAngleY.TabIndex = 7;
            this.lblChartSearchAngleY.Text = "Угол Y";
            this.lblChartSearchAngleY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChartSearchAngleX
            // 
            this.lblChartSearchAngleX.AutoSize = true;
            this.lblChartSearchAngleX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChartSearchAngleX.ForeColor = System.Drawing.Color.White;
            this.lblChartSearchAngleX.Location = new System.Drawing.Point(3, 7);
            this.lblChartSearchAngleX.Name = "lblChartSearchAngleX";
            this.lblChartSearchAngleX.Size = new System.Drawing.Size(50, 16);
            this.lblChartSearchAngleX.TabIndex = 6;
            this.lblChartSearchAngleX.Text = "Угол X";
            this.lblChartSearchAngleX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudChartSearchAngleY
            // 
            this.nudChartSearchAngleY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudChartSearchAngleY.Location = new System.Drawing.Point(59, 33);
            this.nudChartSearchAngleY.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudChartSearchAngleY.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudChartSearchAngleY.Name = "nudChartSearchAngleY";
            this.nudChartSearchAngleY.Size = new System.Drawing.Size(57, 22);
            this.nudChartSearchAngleY.TabIndex = 5;
            this.nudChartSearchAngleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudChartSearchAngleY.ValueChanged += new System.EventHandler(this.nudChartSearchAngleY_ValueChanged);
            // 
            // nudChartSearchAngleX
            // 
            this.nudChartSearchAngleX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudChartSearchAngleX.Location = new System.Drawing.Point(59, 5);
            this.nudChartSearchAngleX.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudChartSearchAngleX.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudChartSearchAngleX.Name = "nudChartSearchAngleX";
            this.nudChartSearchAngleX.Size = new System.Drawing.Size(57, 22);
            this.nudChartSearchAngleX.TabIndex = 4;
            this.nudChartSearchAngleX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudChartSearchAngleX.ValueChanged += new System.EventHandler(this.nudChartSearchAngleX_ValueChanged);
            // 
            // chartSearch
            // 
            this.chartSearch.BackColor = System.Drawing.Color.Black;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = -30;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Rotation = -30;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Title = "Y";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "SearchChartArea";
            this.chartSearch.ChartAreas.Add(chartArea1);
            this.chartSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSearch.IsSoftShadows = false;
            this.chartSearch.Location = new System.Drawing.Point(3, 27);
            this.chartSearch.Name = "chartSearch";
            series1.ChartArea = "SearchChartArea";
            series1.Name = "Series1";
            this.chartSearch.Series.Add(series1);
            this.chartSearch.Size = new System.Drawing.Size(770, 506);
            this.chartSearch.TabIndex = 1;
            this.chartSearch.Text = "chart1";
            this.chartSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartSearch_MouseClick);
            // 
            // menuStripSearch3D
            // 
            this.menuStripSearch3D.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search3DShowToolStripMenuItem,
            this.ChartSearch3DToolStripMenuItem});
            this.menuStripSearch3D.Location = new System.Drawing.Point(3, 3);
            this.menuStripSearch3D.Name = "menuStripSearch3D";
            this.menuStripSearch3D.Size = new System.Drawing.Size(770, 24);
            this.menuStripSearch3D.TabIndex = 0;
            this.menuStripSearch3D.Text = "menuStrip1";
            // 
            // Search3DShowToolStripMenuItem
            // 
            this.Search3DShowToolStripMenuItem.Name = "Search3DShowToolStripMenuItem";
            this.Search3DShowToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.Search3DShowToolStripMenuItem.Text = "Показать";
            this.Search3DShowToolStripMenuItem.Click += new System.EventHandler(this.Search3DShowToolStripMenuItem_Click);
            // 
            // ChartSearch3DToolStripMenuItem
            // 
            this.ChartSearch3DToolStripMenuItem.Name = "ChartSearch3DToolStripMenuItem";
            this.ChartSearch3DToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.ChartSearch3DToolStripMenuItem.Text = "3D";
            this.ChartSearch3DToolStripMenuItem.Click += new System.EventHandler(this.ChartSearch3DToolStripMenuItem_Click);
            // 
            // tabPageRoute3D
            // 
            this.tabPageRoute3D.Controls.Add(this.panelRouteChartButtons);
            this.tabPageRoute3D.Controls.Add(this.chartRoute);
            this.tabPageRoute3D.Controls.Add(this.menuStripRoute3D);
            this.tabPageRoute3D.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoute3D.Name = "tabPageRoute3D";
            this.tabPageRoute3D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoute3D.Size = new System.Drawing.Size(776, 536);
            this.tabPageRoute3D.TabIndex = 2;
            this.tabPageRoute3D.Text = "Маршрут 3D";
            this.tabPageRoute3D.UseVisualStyleBackColor = true;
            // 
            // panelRouteChartButtons
            // 
            this.panelRouteChartButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRouteChartButtons.BackColor = System.Drawing.Color.Black;
            this.panelRouteChartButtons.Controls.Add(this.tbxChartRouteJump);
            this.panelRouteChartButtons.Controls.Add(this.lblChartRouteJump);
            this.panelRouteChartButtons.Controls.Add(this.tbxChartRouteSelected);
            this.panelRouteChartButtons.Controls.Add(this.lblSearchRouteSelected);
            this.panelRouteChartButtons.Controls.Add(this.lblChartRouteAngleY);
            this.panelRouteChartButtons.Controls.Add(this.lblChartRouteAngleX);
            this.panelRouteChartButtons.Controls.Add(this.nudChartRouteAngleY);
            this.panelRouteChartButtons.Controls.Add(this.nudChartRouteAngleX);
            this.panelRouteChartButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelRouteChartButtons.Location = new System.Drawing.Point(3, 472);
            this.panelRouteChartButtons.Name = "panelRouteChartButtons";
            this.panelRouteChartButtons.Size = new System.Drawing.Size(770, 61);
            this.panelRouteChartButtons.TabIndex = 3;
            // 
            // tbxChartRouteJump
            // 
            this.tbxChartRouteJump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxChartRouteJump.Location = new System.Drawing.Point(204, 32);
            this.tbxChartRouteJump.Name = "tbxChartRouteJump";
            this.tbxChartRouteJump.Size = new System.Drawing.Size(73, 22);
            this.tbxChartRouteJump.TabIndex = 11;
            this.tbxChartRouteJump.Text = "50";
            this.tbxChartRouteJump.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblChartRouteJump
            // 
            this.lblChartRouteJump.AutoSize = true;
            this.lblChartRouteJump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChartRouteJump.ForeColor = System.Drawing.Color.White;
            this.lblChartRouteJump.Location = new System.Drawing.Point(122, 35);
            this.lblChartRouteJump.Name = "lblChartRouteJump";
            this.lblChartRouteJump.Size = new System.Drawing.Size(76, 16);
            this.lblChartRouteJump.TabIndex = 10;
            this.lblChartRouteJump.Text = "Шаг сетки:";
            this.lblChartRouteJump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxChartRouteSelected
            // 
            this.tbxChartRouteSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxChartRouteSelected.Location = new System.Drawing.Point(269, 4);
            this.tbxChartRouteSelected.Name = "tbxChartRouteSelected";
            this.tbxChartRouteSelected.Size = new System.Drawing.Size(272, 22);
            this.tbxChartRouteSelected.TabIndex = 9;
            // 
            // lblSearchRouteSelected
            // 
            this.lblSearchRouteSelected.AutoSize = true;
            this.lblSearchRouteSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchRouteSelected.ForeColor = System.Drawing.Color.White;
            this.lblSearchRouteSelected.Location = new System.Drawing.Point(122, 7);
            this.lblSearchRouteSelected.Name = "lblSearchRouteSelected";
            this.lblSearchRouteSelected.Size = new System.Drawing.Size(141, 16);
            this.lblSearchRouteSelected.TabIndex = 8;
            this.lblSearchRouteSelected.Text = "Выбранная система:";
            this.lblSearchRouteSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChartRouteAngleY
            // 
            this.lblChartRouteAngleY.AutoSize = true;
            this.lblChartRouteAngleY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChartRouteAngleY.ForeColor = System.Drawing.Color.White;
            this.lblChartRouteAngleY.Location = new System.Drawing.Point(3, 35);
            this.lblChartRouteAngleY.Name = "lblChartRouteAngleY";
            this.lblChartRouteAngleY.Size = new System.Drawing.Size(51, 16);
            this.lblChartRouteAngleY.TabIndex = 7;
            this.lblChartRouteAngleY.Text = "Угол Y";
            this.lblChartRouteAngleY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChartRouteAngleX
            // 
            this.lblChartRouteAngleX.AutoSize = true;
            this.lblChartRouteAngleX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChartRouteAngleX.ForeColor = System.Drawing.Color.White;
            this.lblChartRouteAngleX.Location = new System.Drawing.Point(3, 7);
            this.lblChartRouteAngleX.Name = "lblChartRouteAngleX";
            this.lblChartRouteAngleX.Size = new System.Drawing.Size(50, 16);
            this.lblChartRouteAngleX.TabIndex = 6;
            this.lblChartRouteAngleX.Text = "Угол X";
            this.lblChartRouteAngleX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudChartRouteAngleY
            // 
            this.nudChartRouteAngleY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudChartRouteAngleY.Location = new System.Drawing.Point(59, 33);
            this.nudChartRouteAngleY.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudChartRouteAngleY.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudChartRouteAngleY.Name = "nudChartRouteAngleY";
            this.nudChartRouteAngleY.Size = new System.Drawing.Size(57, 22);
            this.nudChartRouteAngleY.TabIndex = 5;
            this.nudChartRouteAngleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudChartRouteAngleY.ValueChanged += new System.EventHandler(this.nudChartRouteAngleY_ValueChanged);
            // 
            // nudChartRouteAngleX
            // 
            this.nudChartRouteAngleX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudChartRouteAngleX.Location = new System.Drawing.Point(59, 5);
            this.nudChartRouteAngleX.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudChartRouteAngleX.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudChartRouteAngleX.Name = "nudChartRouteAngleX";
            this.nudChartRouteAngleX.Size = new System.Drawing.Size(57, 22);
            this.nudChartRouteAngleX.TabIndex = 4;
            this.nudChartRouteAngleX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudChartRouteAngleX.ValueChanged += new System.EventHandler(this.nudChartRouteAngleX_ValueChanged);
            // 
            // chartRoute
            // 
            this.chartRoute.BackColor = System.Drawing.Color.Black;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = -30;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Rotation = -30;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.Title = "X";
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.IsMarginVisible = false;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Title = "Y";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "RouteChartArea";
            this.chartRoute.ChartAreas.Add(chartArea2);
            this.chartRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRoute.IsSoftShadows = false;
            this.chartRoute.Location = new System.Drawing.Point(3, 27);
            this.chartRoute.Name = "chartRoute";
            series2.ChartArea = "RouteChartArea";
            series2.Name = "Series1";
            this.chartRoute.Series.Add(series2);
            this.chartRoute.Size = new System.Drawing.Size(770, 506);
            this.chartRoute.TabIndex = 2;
            this.chartRoute.Text = "chart1";
            this.chartRoute.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartRoute_MouseClick);
            // 
            // menuStripRoute3D
            // 
            this.menuStripRoute3D.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Route3DShowToolStripMenuItem});
            this.menuStripRoute3D.Location = new System.Drawing.Point(3, 3);
            this.menuStripRoute3D.Name = "menuStripRoute3D";
            this.menuStripRoute3D.Size = new System.Drawing.Size(770, 24);
            this.menuStripRoute3D.TabIndex = 0;
            this.menuStripRoute3D.Text = "menuStrip1";
            // 
            // Route3DShowToolStripMenuItem
            // 
            this.Route3DShowToolStripMenuItem.Name = "Route3DShowToolStripMenuItem";
            this.Route3DShowToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.Route3DShowToolStripMenuItem.Text = "Показать";
            this.Route3DShowToolStripMenuItem.Click += new System.EventHandler(this.Route3DShowToolStripMenuItem_Click);
            // 
            // tabCoordsOnSphere
            // 
            this.tabCoordsOnSphere.Controls.Add(this.dgvCoords);
            this.tabCoordsOnSphere.Controls.Add(this.panelCoordsOnSphere);
            this.tabCoordsOnSphere.Location = new System.Drawing.Point(4, 22);
            this.tabCoordsOnSphere.Name = "tabCoordsOnSphere";
            this.tabCoordsOnSphere.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoordsOnSphere.Size = new System.Drawing.Size(776, 536);
            this.tabCoordsOnSphere.TabIndex = 4;
            this.tabCoordsOnSphere.Text = "Расчет координат";
            this.tabCoordsOnSphere.UseVisualStyleBackColor = true;
            // 
            // dgvCoords
            // 
            this.dgvCoords.AllowUserToAddRows = false;
            this.dgvCoords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCoords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcCooordsID,
            this.dgvcCooordsX,
            this.dgvcCooordsY,
            this.dgvcCooordsZ,
            this.dgvcCopied,
            this.dgvcCooordsSystem,
            this.dgvcCooordsSX,
            this.dgvcCooordsSY,
            this.dgvcCooordsSZ});
            this.dgvCoords.ContextMenuStrip = this.contextMenuStripCoords;
            this.dgvCoords.Location = new System.Drawing.Point(6, 42);
            this.dgvCoords.Name = "dgvCoords";
            this.dgvCoords.Size = new System.Drawing.Size(764, 486);
            this.dgvCoords.TabIndex = 1;
            // 
            // dgvcCooordsID
            // 
            this.dgvcCooordsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcCooordsID.DataPropertyName = "ID";
            this.dgvcCooordsID.Frozen = true;
            this.dgvcCooordsID.HeaderText = "№";
            this.dgvcCooordsID.Name = "dgvcCooordsID";
            this.dgvcCooordsID.ReadOnly = true;
            this.dgvcCooordsID.Width = 43;
            // 
            // dgvcCooordsX
            // 
            this.dgvcCooordsX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcCooordsX.DataPropertyName = "X";
            this.dgvcCooordsX.Frozen = true;
            this.dgvcCooordsX.HeaderText = "X";
            this.dgvcCooordsX.Name = "dgvcCooordsX";
            this.dgvcCooordsX.ReadOnly = true;
            this.dgvcCooordsX.Width = 39;
            // 
            // dgvcCooordsY
            // 
            this.dgvcCooordsY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcCooordsY.DataPropertyName = "Y";
            this.dgvcCooordsY.Frozen = true;
            this.dgvcCooordsY.HeaderText = "Y";
            this.dgvcCooordsY.Name = "dgvcCooordsY";
            this.dgvcCooordsY.ReadOnly = true;
            this.dgvcCooordsY.Width = 39;
            // 
            // dgvcCooordsZ
            // 
            this.dgvcCooordsZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcCooordsZ.DataPropertyName = "Z";
            this.dgvcCooordsZ.Frozen = true;
            this.dgvcCooordsZ.HeaderText = "Z";
            this.dgvcCooordsZ.Name = "dgvcCooordsZ";
            this.dgvcCooordsZ.ReadOnly = true;
            this.dgvcCooordsZ.Width = 39;
            // 
            // dgvcCopied
            // 
            this.dgvcCopied.Frozen = true;
            this.dgvcCopied.HeaderText = "Обработано";
            this.dgvcCopied.Name = "dgvcCopied";
            this.dgvcCopied.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcCopied.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvcCooordsSystem
            // 
            this.dgvcCooordsSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcCooordsSystem.DataPropertyName = "System";
            this.dgvcCooordsSystem.Frozen = true;
            this.dgvcCooordsSystem.HeaderText = "Система";
            this.dgvcCooordsSystem.Name = "dgvcCooordsSystem";
            this.dgvcCooordsSystem.ReadOnly = true;
            this.dgvcCooordsSystem.Width = 76;
            // 
            // dgvcCooordsSX
            // 
            this.dgvcCooordsSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcCooordsSX.DataPropertyName = "SX";
            this.dgvcCooordsSX.Frozen = true;
            this.dgvcCooordsSX.HeaderText = "X";
            this.dgvcCooordsSX.Name = "dgvcCooordsSX";
            this.dgvcCooordsSX.ReadOnly = true;
            this.dgvcCooordsSX.Width = 39;
            // 
            // dgvcCooordsSY
            // 
            this.dgvcCooordsSY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcCooordsSY.DataPropertyName = "SY";
            this.dgvcCooordsSY.Frozen = true;
            this.dgvcCooordsSY.HeaderText = "Y";
            this.dgvcCooordsSY.Name = "dgvcCooordsSY";
            this.dgvcCooordsSY.ReadOnly = true;
            this.dgvcCooordsSY.Width = 39;
            // 
            // dgvcCooordsSZ
            // 
            this.dgvcCooordsSZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcCooordsSZ.DataPropertyName = "SZ";
            this.dgvcCooordsSZ.Frozen = true;
            this.dgvcCooordsSZ.HeaderText = "Z";
            this.dgvcCooordsSZ.Name = "dgvcCooordsSZ";
            this.dgvcCooordsSZ.ReadOnly = true;
            this.dgvcCooordsSZ.Width = 39;
            // 
            // contextMenuStripCoords
            // 
            this.contextMenuStripCoords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoordsCopyToSearchToolStripMenuItem,
            this.CoordsAddSystemToRouteToolStripMenuItem});
            this.contextMenuStripCoords.Name = "contextMenuStripCoords";
            this.contextMenuStripCoords.Size = new System.Drawing.Size(262, 48);
            // 
            // CoordsCopyToSearchToolStripMenuItem
            // 
            this.CoordsCopyToSearchToolStripMenuItem.Name = "CoordsCopyToSearchToolStripMenuItem";
            this.CoordsCopyToSearchToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.CoordsCopyToSearchToolStripMenuItem.Text = "Скопировать координаты в поиск";
            this.CoordsCopyToSearchToolStripMenuItem.Click += new System.EventHandler(this.CoordsCopyToSearchToolStripMenuItem_Click);
            // 
            // CoordsAddSystemToRouteToolStripMenuItem
            // 
            this.CoordsAddSystemToRouteToolStripMenuItem.Name = "CoordsAddSystemToRouteToolStripMenuItem";
            this.CoordsAddSystemToRouteToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.CoordsAddSystemToRouteToolStripMenuItem.Text = "Добавить систему в маршрут";
            // 
            // panelCoordsOnSphere
            // 
            this.panelCoordsOnSphere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCoordsOnSphere.Controls.Add(this.btnCoordsToRoute);
            this.panelCoordsOnSphere.Controls.Add(this.lblCoordsStatus);
            this.panelCoordsOnSphere.Controls.Add(this.btnCoordsCalculate);
            this.panelCoordsOnSphere.Controls.Add(this.lblCoordsStep);
            this.panelCoordsOnSphere.Controls.Add(this.nudCoordsStep);
            this.panelCoordsOnSphere.Location = new System.Drawing.Point(6, 6);
            this.panelCoordsOnSphere.Name = "panelCoordsOnSphere";
            this.panelCoordsOnSphere.Size = new System.Drawing.Size(764, 30);
            this.panelCoordsOnSphere.TabIndex = 0;
            // 
            // btnCoordsToRoute
            // 
            this.btnCoordsToRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoordsToRoute.Location = new System.Drawing.Point(325, 2);
            this.btnCoordsToRoute.Name = "btnCoordsToRoute";
            this.btnCoordsToRoute.Size = new System.Drawing.Size(95, 23);
            this.btnCoordsToRoute.TabIndex = 4;
            this.btnCoordsToRoute.Text = "В маршрут";
            this.btnCoordsToRoute.UseVisualStyleBackColor = true;
            this.btnCoordsToRoute.Click += new System.EventHandler(this.btnCoordsToRoute_Click);
            // 
            // lblCoordsStatus
            // 
            this.lblCoordsStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoordsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoordsStatus.Location = new System.Drawing.Point(477, 5);
            this.lblCoordsStatus.Name = "lblCoordsStatus";
            this.lblCoordsStatus.Size = new System.Drawing.Size(284, 16);
            this.lblCoordsStatus.TabIndex = 3;
            // 
            // btnCoordsCalculate
            // 
            this.btnCoordsCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoordsCalculate.Location = new System.Drawing.Point(224, 2);
            this.btnCoordsCalculate.Name = "btnCoordsCalculate";
            this.btnCoordsCalculate.Size = new System.Drawing.Size(95, 23);
            this.btnCoordsCalculate.TabIndex = 2;
            this.btnCoordsCalculate.Text = "Рассчитать";
            this.btnCoordsCalculate.UseVisualStyleBackColor = true;
            this.btnCoordsCalculate.Click += new System.EventHandler(this.btnCoordsCalculate_Click);
            // 
            // lblCoordsStep
            // 
            this.lblCoordsStep.AutoSize = true;
            this.lblCoordsStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoordsStep.Location = new System.Drawing.Point(3, 5);
            this.lblCoordsStep.Name = "lblCoordsStep";
            this.lblCoordsStep.Size = new System.Drawing.Size(138, 16);
            this.lblCoordsStep.TabIndex = 1;
            this.lblCoordsStep.Text = "Шаг сетки (градусы)";
            // 
            // nudCoordsStep
            // 
            this.nudCoordsStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCoordsStep.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCoordsStep.Location = new System.Drawing.Point(147, 3);
            this.nudCoordsStep.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudCoordsStep.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCoordsStep.Name = "nudCoordsStep";
            this.nudCoordsStep.Size = new System.Drawing.Size(71, 22);
            this.nudCoordsStep.TabIndex = 0;
            this.nudCoordsStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCoordsStep.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // tabPageBacup
            // 
            this.tabPageBacup.BackColor = System.Drawing.Color.Silver;
            this.tabPageBacup.Controls.Add(this.btnStart);
            this.tabPageBacup.Controls.Add(this.tbxLog);
            this.tabPageBacup.Controls.Add(this.lblTo);
            this.tabPageBacup.Controls.Add(this.lblFrom);
            this.tabPageBacup.Controls.Add(this.btnTo);
            this.tabPageBacup.Controls.Add(this.btnFrom);
            this.tabPageBacup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageBacup.Location = new System.Drawing.Point(4, 22);
            this.tabPageBacup.Name = "tabPageBacup";
            this.tabPageBacup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBacup.Size = new System.Drawing.Size(776, 536);
            this.tabPageBacup.TabIndex = 5;
            this.tabPageBacup.Text = "Бэкап логов";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 64);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Скопировать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxLog
            // 
            this.tbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLog.Location = new System.Drawing.Point(8, 93);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxLog.Size = new System.Drawing.Size(760, 435);
            this.tbxLog.TabIndex = 4;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.Location = new System.Drawing.Point(127, 38);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(643, 20);
            this.lblTo.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.Location = new System.Drawing.Point(130, 9);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(638, 20);
            this.lblFrom.TabIndex = 2;
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(8, 35);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(107, 23);
            this.btnTo.TabIndex = 1;
            this.btnTo.Text = "Куда";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnFrom
            // 
            this.btnFrom.Location = new System.Drawing.Point(8, 6);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(107, 23);
            this.btnFrom.TabIndex = 0;
            this.btnFrom.Text = "Откуда";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // dgvcSystem
            // 
            this.dgvcSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcSystem.DataPropertyName = "System";
            this.dgvcSystem.Frozen = true;
            this.dgvcSystem.HeaderText = "Система";
            this.dgvcSystem.MinimumWidth = 20;
            this.dgvcSystem.Name = "dgvcSystem";
            this.dgvcSystem.ReadOnly = true;
            this.dgvcSystem.Width = 89;
            // 
            // dgvcCenterDistance
            // 
            this.dgvcCenterDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcCenterDistance.DataPropertyName = "CenterDistance";
            this.dgvcCenterDistance.HeaderText = "От центра";
            this.dgvcCenterDistance.Name = "dgvcCenterDistance";
            this.dgvcCenterDistance.ReadOnly = true;
            // 
            // dgvcCurrentDistance
            // 
            this.dgvcCurrentDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcCurrentDistance.DataPropertyName = "CurrentDistance";
            this.dgvcCurrentDistance.HeaderText = "От текущего";
            this.dgvcCurrentDistance.Name = "dgvcCurrentDistance";
            this.dgvcCurrentDistance.ReadOnly = true;
            this.dgvcCurrentDistance.Width = 114;
            // 
            // dgvcX
            // 
            this.dgvcX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcX.DataPropertyName = "X";
            this.dgvcX.HeaderText = "X";
            this.dgvcX.Name = "dgvcX";
            this.dgvcX.ReadOnly = true;
            this.dgvcX.Width = 41;
            // 
            // dgvcY
            // 
            this.dgvcY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcY.DataPropertyName = "Y";
            this.dgvcY.HeaderText = "Y";
            this.dgvcY.Name = "dgvcY";
            this.dgvcY.ReadOnly = true;
            this.dgvcY.Width = 42;
            // 
            // dgvcZ
            // 
            this.dgvcZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcZ.DataPropertyName = "Z";
            this.dgvcZ.HeaderText = "Z";
            this.dgvcZ.Name = "dgvcZ";
            this.dgvcZ.ReadOnly = true;
            this.dgvcZ.Width = 41;
            // 
            // dgvcAngleH
            // 
            this.dgvcAngleH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcAngleH.DataPropertyName = "AngleH";
            this.dgvcAngleH.HeaderText = "Угол гор.";
            this.dgvcAngleH.Name = "dgvcAngleH";
            this.dgvcAngleH.ReadOnly = true;
            this.dgvcAngleH.ToolTipText = "угол между направлением на Sol и на направлением на эту систему";
            this.dgvcAngleH.Width = 92;
            // 
            // dgvcAngleV
            // 
            this.dgvcAngleV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcAngleV.DataPropertyName = "AngleV";
            this.dgvcAngleV.HeaderText = "Урол верт.";
            this.dgvcAngleV.Name = "dgvcAngleV";
            this.dgvcAngleV.ReadOnly = true;
            this.dgvcAngleV.ToolTipText = "угол между направлением на Sol и на направлением на эту систему";
            this.dgvcAngleV.Width = 103;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripRoute;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "ED Sphere";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.contextMenuStripSearch.ResumeLayout(false);
            this.gbxCenter.ResumeLayout(false);
            this.gbxCenter.PerformLayout();
            this.gpbCurrent.ResumeLayout(false);
            this.gpbCurrent.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageRoute.ResumeLayout(false);
            this.tabPageRoute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).EndInit();
            this.menuStripRoute.ResumeLayout(false);
            this.menuStripRoute.PerformLayout();
            this.tabPageSearch3D.ResumeLayout(false);
            this.tabPageSearch3D.PerformLayout();
            this.panelSearchChartButtons.ResumeLayout(false);
            this.panelSearchChartButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartSearchAngleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartSearchAngleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSearch)).EndInit();
            this.menuStripSearch3D.ResumeLayout(false);
            this.menuStripSearch3D.PerformLayout();
            this.tabPageRoute3D.ResumeLayout(false);
            this.tabPageRoute3D.PerformLayout();
            this.panelRouteChartButtons.ResumeLayout(false);
            this.panelRouteChartButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartRouteAngleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartRouteAngleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoute)).EndInit();
            this.menuStripRoute3D.ResumeLayout(false);
            this.menuStripRoute3D.PerformLayout();
            this.tabCoordsOnSphere.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoords)).EndInit();
            this.contextMenuStripCoords.ResumeLayout(false);
            this.panelCoordsOnSphere.ResumeLayout(false);
            this.panelCoordsOnSphere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoordsStep)).EndInit();
            this.tabPageBacup.ResumeLayout(false);
            this.tabPageBacup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCenterX;
        private System.Windows.Forms.TextBox tbxCenterX;
        private System.Windows.Forms.Label lblCenterY;
        private System.Windows.Forms.TextBox tbxCenterY;
        private System.Windows.Forms.Label lblCenterZ;
        private System.Windows.Forms.TextBox tbxCenterZ;
        private System.Windows.Forms.Label lblCenterRadius;
        private System.Windows.Forms.TextBox tbxCenterRadius;
        private System.Windows.Forms.Label lblCurentSystem;
        private System.Windows.Forms.Label lblCurrentX;
        private System.Windows.Forms.TextBox tbxCurrentX;
        private System.Windows.Forms.Label lblCurrentY;
        private System.Windows.Forms.TextBox tbxCurrentY;
        private System.Windows.Forms.Label lblCurrentZ;
        private System.Windows.Forms.TextBox tbxCurrentZ;
        private System.Windows.Forms.Label lblCurrentRadius;
        private System.Windows.Forms.TextBox tbxCurrentRadius;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label lblSpan;
        private System.Windows.Forms.TextBox tbxSpan;
        private System.Windows.Forms.GroupBox gbxCenter;
        private System.Windows.Forms.TextBox tbxCenterSystem;
        private System.Windows.Forms.Label lblCerterSystem;
        private System.Windows.Forms.GroupBox gpbCurrent;
        private System.Windows.Forms.TextBox tbxCurrentSystem;
        private System.Windows.Forms.Button btnCenterCoordinates;
        private System.Windows.Forms.Button btnCurrentCoordinates;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPageRoute;
        private System.Windows.Forms.DataGridView dgvRoute;
        private System.Windows.Forms.MenuStrip menuStripRoute;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSearch;
        private System.Windows.Forms.ToolStripMenuItem SearchAddToRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RouteDeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRouteID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvRoutePassed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRoutePoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRouteSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRouteX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRouteY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRouteZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRouteComment;
        private System.Windows.Forms.TabPage tabPageRoute3D;
        private System.Windows.Forms.TabPage tabPageSearch3D;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSearch;
        private System.Windows.Forms.MenuStrip menuStripSearch3D;
        private System.Windows.Forms.MenuStrip menuStripRoute3D;
        private System.Windows.Forms.ToolStripMenuItem Search3DShowToolStripMenuItem;
        private System.Windows.Forms.Panel panelSearchChartButtons;
        private System.Windows.Forms.NumericUpDown nudChartSearchAngleX;
        private System.Windows.Forms.NumericUpDown nudChartSearchAngleY;
        private System.Windows.Forms.Label lblChartSearchAngleY;
        private System.Windows.Forms.Label lblChartSearchAngleX;
        private System.Windows.Forms.TextBox tbxSearchChartSelecned;
        private System.Windows.Forms.Label lblSearchChartSelected;
        private System.Windows.Forms.Button btnSeriseChartAddToRoute;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRoute;
        private System.Windows.Forms.ToolStripMenuItem Route3DShowToolStripMenuItem;
        private System.Windows.Forms.Panel panelRouteChartButtons;
        private System.Windows.Forms.TextBox tbxChartRouteSelected;
        private System.Windows.Forms.Label lblSearchRouteSelected;
        private System.Windows.Forms.Label lblChartRouteAngleY;
        private System.Windows.Forms.Label lblChartRouteAngleX;
        private System.Windows.Forms.NumericUpDown nudChartRouteAngleY;
        private System.Windows.Forms.NumericUpDown nudChartRouteAngleX;
        private System.Windows.Forms.TextBox tbxChartRouteJump;
        private System.Windows.Forms.Label lblChartRouteJump;
        private System.Windows.Forms.ToolStripMenuItem ChartSearch3DToolStripMenuItem;
        private System.Windows.Forms.TabPage tabCoordsOnSphere;
        private System.Windows.Forms.DataGridView dgvCoords;
        private System.Windows.Forms.Panel panelCoordsOnSphere;
        private System.Windows.Forms.Button btnCoordsCalculate;
        private System.Windows.Forms.Label lblCoordsStep;
        private System.Windows.Forms.NumericUpDown nudCoordsStep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCoords;
        private System.Windows.Forms.ToolStripMenuItem CoordsCopyToSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RouteDeleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CoordsAddSystemToRouteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCooordsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCooordsX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCooordsY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCooordsZ;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcCopied;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCooordsSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCooordsSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCooordsSY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCooordsSZ;
        private System.Windows.Forms.Label lblCoordsStatus;
        private System.Windows.Forms.Button btnCoordsToRoute;
        private System.Windows.Forms.TabPage tabPageBacup;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCenterDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCurrentDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcAngleH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcAngleV;
    }
}

