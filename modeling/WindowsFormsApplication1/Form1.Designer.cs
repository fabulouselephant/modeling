namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Generate = new System.Windows.Forms.TabControl();
            this.generating = new System.Windows.Forms.TabPage();
            this.selection_generate = new System.Windows.Forms.GroupBox();
            this.do_generate = new System.Windows.Forms.Button();
            this.addintion_textbox = new System.Windows.Forms.TextBox();
            this.termal_formation = new System.Windows.Forms.GroupBox();
            this.tf_db_logordinary = new System.Windows.Forms.RadioButton();
            this.tf_db_ordinary = new System.Windows.Forms.RadioButton();
            this.greenhouse_gases = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.RadioButton();
            this.N20_db_type = new System.Windows.Forms.GroupBox();
            this.N20_logordinary = new System.Windows.Forms.RadioButton();
            this.N20_ordinary = new System.Windows.Forms.RadioButton();
            this.nitrous_oxide = new System.Windows.Forms.RadioButton();
            this.CH4_db_type = new System.Windows.Forms.GroupBox();
            this.CH4_logordinary = new System.Windows.Forms.RadioButton();
            this.CH4_ordinary = new System.Windows.Forms.RadioButton();
            this.methane = new System.Windows.Forms.RadioButton();
            this.CO2_db_type = new System.Windows.Forms.GroupBox();
            this.CO2_logordinary = new System.Windows.Forms.RadioButton();
            this.CO2_ordinary = new System.Windows.Forms.RadioButton();
            this.carbon_dioxid = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.graph_holder = new System.Windows.Forms.GroupBox();
            this.graph_name = new System.Windows.Forms.Label();
            this.diagram = new System.Windows.Forms.PictureBox();
            this.variants = new System.Windows.Forms.TabPage();
            this.do_build = new System.Windows.Forms.Button();
            this.row_params = new System.Windows.Forms.GroupBox();
            this.UB_percent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.upper_boundary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_percent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lower_boundary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.math_expectations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amount_of_parts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.interval_width = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.interval_var_row = new System.Windows.Forms.GroupBox();
            this.histogram = new System.Windows.Forms.TabPage();
            this.build_histogram = new System.Windows.Forms.Button();
            this.histogram_holder = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graph = new System.Windows.Forms.PictureBox();
            this.variable_row = new System.Windows.Forms.ListView();
            this.interval_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inreval_start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.interval_end = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rel_frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acc_frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Generate.SuspendLayout();
            this.generating.SuspendLayout();
            this.selection_generate.SuspendLayout();
            this.termal_formation.SuspendLayout();
            this.greenhouse_gases.SuspendLayout();
            this.N20_db_type.SuspendLayout();
            this.CH4_db_type.SuspendLayout();
            this.CO2_db_type.SuspendLayout();
            this.graph_holder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            this.variants.SuspendLayout();
            this.row_params.SuspendLayout();
            this.interval_var_row.SuspendLayout();
            this.histogram.SuspendLayout();
            this.histogram_holder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Controls.Add(this.generating);
            this.Generate.Controls.Add(this.variants);
            this.Generate.Controls.Add(this.histogram);
            this.Generate.Location = new System.Drawing.Point(12, 12);
            this.Generate.Name = "Generate";
            this.Generate.SelectedIndex = 0;
            this.Generate.Size = new System.Drawing.Size(941, 631);
            this.Generate.TabIndex = 0;
            // 
            // generating
            // 
            this.generating.Controls.Add(this.selection_generate);
            this.generating.Controls.Add(this.graph_holder);
            this.generating.Location = new System.Drawing.Point(4, 22);
            this.generating.Name = "generating";
            this.generating.Padding = new System.Windows.Forms.Padding(3);
            this.generating.Size = new System.Drawing.Size(933, 605);
            this.generating.TabIndex = 0;
            this.generating.Text = "Генерування";
            this.generating.UseVisualStyleBackColor = true;
            // 
            // selection_generate
            // 
            this.selection_generate.Controls.Add(this.do_generate);
            this.selection_generate.Controls.Add(this.addintion_textbox);
            this.selection_generate.Controls.Add(this.termal_formation);
            this.selection_generate.Controls.Add(this.greenhouse_gases);
            this.selection_generate.Controls.Add(this.textBox1);
            this.selection_generate.Controls.Add(this.label2);
            this.selection_generate.Location = new System.Drawing.Point(610, 7);
            this.selection_generate.Name = "selection_generate";
            this.selection_generate.Size = new System.Drawing.Size(299, 580);
            this.selection_generate.TabIndex = 2;
            this.selection_generate.TabStop = false;
            this.selection_generate.Text = "Генерування вибірки";
            // 
            // do_generate
            // 
            this.do_generate.Location = new System.Drawing.Point(68, 540);
            this.do_generate.Name = "do_generate";
            this.do_generate.Size = new System.Drawing.Size(167, 23);
            this.do_generate.TabIndex = 5;
            this.do_generate.Text = "Згенерувати";
            this.do_generate.UseVisualStyleBackColor = true;
            this.do_generate.Click += new System.EventHandler(this.do_generate_Click);
            // 
            // addintion_textbox
            // 
            this.addintion_textbox.Enabled = false;
            this.addintion_textbox.Location = new System.Drawing.Point(10, 514);
            this.addintion_textbox.Name = "addintion_textbox";
            this.addintion_textbox.Size = new System.Drawing.Size(283, 20);
            this.addintion_textbox.TabIndex = 4;
            // 
            // termal_formation
            // 
            this.termal_formation.Controls.Add(this.tf_db_logordinary);
            this.termal_formation.Controls.Add(this.tf_db_ordinary);
            this.termal_formation.Location = new System.Drawing.Point(10, 416);
            this.termal_formation.Name = "termal_formation";
            this.termal_formation.Size = new System.Drawing.Size(283, 91);
            this.termal_formation.TabIndex = 3;
            this.termal_formation.TabStop = false;
            this.termal_formation.Text = "Тип розподілу теплових утворень";
            // 
            // tf_db_logordinary
            // 
            this.tf_db_logordinary.AutoSize = true;
            this.tf_db_logordinary.Location = new System.Drawing.Point(15, 44);
            this.tf_db_logordinary.Name = "tf_db_logordinary";
            this.tf_db_logordinary.Size = new System.Drawing.Size(191, 17);
            this.tf_db_logordinary.TabIndex = 1;
            this.tf_db_logordinary.Text = "Логнормальний закон розподілу";
            this.tf_db_logordinary.UseVisualStyleBackColor = true;
            // 
            // tf_db_ordinary
            // 
            this.tf_db_ordinary.AutoSize = true;
            this.tf_db_ordinary.Checked = true;
            this.tf_db_ordinary.Location = new System.Drawing.Point(14, 20);
            this.tf_db_ordinary.Name = "tf_db_ordinary";
            this.tf_db_ordinary.Size = new System.Drawing.Size(174, 17);
            this.tf_db_ordinary.TabIndex = 0;
            this.tf_db_ordinary.TabStop = true;
            this.tf_db_ordinary.Text = "Нормальний закон розподілу";
            this.tf_db_ordinary.UseVisualStyleBackColor = true;
            // 
            // greenhouse_gases
            // 
            this.greenhouse_gases.Controls.Add(this.total);
            this.greenhouse_gases.Controls.Add(this.N20_db_type);
            this.greenhouse_gases.Controls.Add(this.nitrous_oxide);
            this.greenhouse_gases.Controls.Add(this.CH4_db_type);
            this.greenhouse_gases.Controls.Add(this.methane);
            this.greenhouse_gases.Controls.Add(this.CO2_db_type);
            this.greenhouse_gases.Controls.Add(this.carbon_dioxid);
            this.greenhouse_gases.Location = new System.Drawing.Point(10, 46);
            this.greenhouse_gases.Name = "greenhouse_gases";
            this.greenhouse_gases.Size = new System.Drawing.Size(283, 364);
            this.greenhouse_gases.TabIndex = 2;
            this.greenhouse_gases.TabStop = false;
            this.greenhouse_gases.Text = "Основні парникові гази";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(7, 338);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(69, 17);
            this.total.TabIndex = 6;
            this.total.TabStop = true;
            this.total.Text = "Загалом";
            this.total.UseVisualStyleBackColor = true;
            // 
            // N20_db_type
            // 
            this.N20_db_type.Controls.Add(this.N20_logordinary);
            this.N20_db_type.Controls.Add(this.N20_ordinary);
            this.N20_db_type.Location = new System.Drawing.Point(7, 257);
            this.N20_db_type.Name = "N20_db_type";
            this.N20_db_type.Size = new System.Drawing.Size(210, 74);
            this.N20_db_type.TabIndex = 5;
            this.N20_db_type.TabStop = false;
            this.N20_db_type.Text = "Тип розподілу N20";
            // 
            // N20_logordinary
            // 
            this.N20_logordinary.AutoSize = true;
            this.N20_logordinary.Location = new System.Drawing.Point(8, 42);
            this.N20_logordinary.Name = "N20_logordinary";
            this.N20_logordinary.Size = new System.Drawing.Size(191, 17);
            this.N20_logordinary.TabIndex = 1;
            this.N20_logordinary.Text = "Логнормальний закон розподілу";
            this.N20_logordinary.UseVisualStyleBackColor = true;
            // 
            // N20_ordinary
            // 
            this.N20_ordinary.AutoSize = true;
            this.N20_ordinary.Checked = true;
            this.N20_ordinary.Location = new System.Drawing.Point(8, 19);
            this.N20_ordinary.Name = "N20_ordinary";
            this.N20_ordinary.Size = new System.Drawing.Size(174, 17);
            this.N20_ordinary.TabIndex = 0;
            this.N20_ordinary.TabStop = true;
            this.N20_ordinary.Text = "Нормальний закон розподілу";
            this.N20_ordinary.UseVisualStyleBackColor = true;
            // 
            // nitrous_oxide
            // 
            this.nitrous_oxide.AutoSize = true;
            this.nitrous_oxide.Location = new System.Drawing.Point(6, 233);
            this.nitrous_oxide.Name = "nitrous_oxide";
            this.nitrous_oxide.Size = new System.Drawing.Size(87, 17);
            this.nitrous_oxide.TabIndex = 4;
            this.nitrous_oxide.TabStop = true;
            this.nitrous_oxide.Text = "Закис азоту";
            this.nitrous_oxide.UseVisualStyleBackColor = true;
            // 
            // CH4_db_type
            // 
            this.CH4_db_type.Controls.Add(this.CH4_logordinary);
            this.CH4_db_type.Controls.Add(this.CH4_ordinary);
            this.CH4_db_type.Location = new System.Drawing.Point(6, 150);
            this.CH4_db_type.Name = "CH4_db_type";
            this.CH4_db_type.Size = new System.Drawing.Size(211, 76);
            this.CH4_db_type.TabIndex = 3;
            this.CH4_db_type.TabStop = false;
            this.CH4_db_type.Text = "Тип розподілу CH4";
            // 
            // CH4_logordinary
            // 
            this.CH4_logordinary.AutoSize = true;
            this.CH4_logordinary.Location = new System.Drawing.Point(8, 44);
            this.CH4_logordinary.Name = "CH4_logordinary";
            this.CH4_logordinary.Size = new System.Drawing.Size(191, 17);
            this.CH4_logordinary.TabIndex = 1;
            this.CH4_logordinary.Text = "Логнормальний закон розподілу";
            this.CH4_logordinary.UseVisualStyleBackColor = true;
            // 
            // CH4_ordinary
            // 
            this.CH4_ordinary.AutoSize = true;
            this.CH4_ordinary.Checked = true;
            this.CH4_ordinary.Location = new System.Drawing.Point(8, 20);
            this.CH4_ordinary.Name = "CH4_ordinary";
            this.CH4_ordinary.Size = new System.Drawing.Size(174, 17);
            this.CH4_ordinary.TabIndex = 0;
            this.CH4_ordinary.TabStop = true;
            this.CH4_ordinary.Text = "Нормальний закон розподілу";
            this.CH4_ordinary.UseVisualStyleBackColor = true;
            // 
            // methane
            // 
            this.methane.AutoSize = true;
            this.methane.Location = new System.Drawing.Point(7, 127);
            this.methane.Name = "methane";
            this.methane.Size = new System.Drawing.Size(57, 17);
            this.methane.TabIndex = 2;
            this.methane.TabStop = true;
            this.methane.Text = "Метан";
            this.methane.UseVisualStyleBackColor = true;
            // 
            // CO2_db_type
            // 
            this.CO2_db_type.Controls.Add(this.CO2_logordinary);
            this.CO2_db_type.Controls.Add(this.CO2_ordinary);
            this.CO2_db_type.Location = new System.Drawing.Point(7, 43);
            this.CO2_db_type.Name = "CO2_db_type";
            this.CO2_db_type.Size = new System.Drawing.Size(210, 77);
            this.CO2_db_type.TabIndex = 1;
            this.CO2_db_type.TabStop = false;
            this.CO2_db_type.Text = "Тип розподілу CO2";
            // 
            // CO2_logordinary
            // 
            this.CO2_logordinary.AutoSize = true;
            this.CO2_logordinary.Location = new System.Drawing.Point(7, 44);
            this.CO2_logordinary.Name = "CO2_logordinary";
            this.CO2_logordinary.Size = new System.Drawing.Size(191, 17);
            this.CO2_logordinary.TabIndex = 1;
            this.CO2_logordinary.Text = "Логнормальний закон розподілу";
            this.CO2_logordinary.UseVisualStyleBackColor = true;
            // 
            // CO2_ordinary
            // 
            this.CO2_ordinary.AutoSize = true;
            this.CO2_ordinary.Checked = true;
            this.CO2_ordinary.Location = new System.Drawing.Point(7, 20);
            this.CO2_ordinary.Name = "CO2_ordinary";
            this.CO2_ordinary.Size = new System.Drawing.Size(168, 17);
            this.CO2_ordinary.TabIndex = 0;
            this.CO2_ordinary.TabStop = true;
            this.CO2_ordinary.Text = "Нормальний закон розоділу";
            this.CO2_ordinary.UseVisualStyleBackColor = true;
            // 
            // carbon_dioxid
            // 
            this.carbon_dioxid.AutoSize = true;
            this.carbon_dioxid.Location = new System.Drawing.Point(7, 20);
            this.carbon_dioxid.Name = "carbon_dioxid";
            this.carbon_dioxid.Size = new System.Drawing.Size(110, 17);
            this.carbon_dioxid.TabIndex = 0;
            this.carbon_dioxid.TabStop = true;
            this.carbon_dioxid.Text = "Вуглекислий газ";
            this.carbon_dioxid.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Об\'єм вибірки = ";
            // 
            // graph_holder
            // 
            this.graph_holder.Controls.Add(this.graph_name);
            this.graph_holder.Controls.Add(this.diagram);
            this.graph_holder.Location = new System.Drawing.Point(7, 7);
            this.graph_holder.Name = "graph_holder";
            this.graph_holder.Size = new System.Drawing.Size(585, 580);
            this.graph_holder.TabIndex = 0;
            this.graph_holder.TabStop = false;
            // 
            // graph_name
            // 
            this.graph_name.AutoSize = true;
            this.graph_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graph_name.Location = new System.Drawing.Point(181, 16);
            this.graph_name.Name = "graph_name";
            this.graph_name.Size = new System.Drawing.Size(156, 24);
            this.graph_name.TabIndex = 1;
            this.graph_name.Text = "Графік вибірки";
            // 
            // diagram
            // 
            this.diagram.Location = new System.Drawing.Point(35, 46);
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(499, 478);
            this.diagram.TabIndex = 0;
            this.diagram.TabStop = false;
            // 
            // variants
            // 
            this.variants.Controls.Add(this.do_build);
            this.variants.Controls.Add(this.row_params);
            this.variants.Controls.Add(this.interval_var_row);
            this.variants.Location = new System.Drawing.Point(4, 22);
            this.variants.Name = "variants";
            this.variants.Padding = new System.Windows.Forms.Padding(3);
            this.variants.Size = new System.Drawing.Size(933, 605);
            this.variants.TabIndex = 1;
            this.variants.Text = "Варіаційний ряд";
            this.variants.UseVisualStyleBackColor = true;
            // 
            // do_build
            // 
            this.do_build.Location = new System.Drawing.Point(654, 34);
            this.do_build.Name = "do_build";
            this.do_build.Size = new System.Drawing.Size(212, 23);
            this.do_build.TabIndex = 3;
            this.do_build.Text = "Побудувати варіаційний ряд";
            this.do_build.UseVisualStyleBackColor = true;
            this.do_build.Click += new System.EventHandler(this.do_build_Click);
            // 
            // row_params
            // 
            this.row_params.Controls.Add(this.UB_percent);
            this.row_params.Controls.Add(this.label9);
            this.row_params.Controls.Add(this.upper_boundary);
            this.row_params.Controls.Add(this.label8);
            this.row_params.Controls.Add(this.lb_percent);
            this.row_params.Controls.Add(this.label7);
            this.row_params.Controls.Add(this.lower_boundary);
            this.row_params.Controls.Add(this.label6);
            this.row_params.Controls.Add(this.math_expectations);
            this.row_params.Controls.Add(this.label5);
            this.row_params.Controls.Add(this.amount_of_parts);
            this.row_params.Controls.Add(this.label4);
            this.row_params.Controls.Add(this.interval_width);
            this.row_params.Controls.Add(this.label3);
            this.row_params.Location = new System.Drawing.Point(634, 75);
            this.row_params.Name = "row_params";
            this.row_params.Size = new System.Drawing.Size(279, 316);
            this.row_params.TabIndex = 2;
            this.row_params.TabStop = false;
            this.row_params.Text = "Параметри ряду";
            // 
            // UB_percent
            // 
            this.UB_percent.Location = new System.Drawing.Point(123, 262);
            this.UB_percent.Name = "UB_percent";
            this.UB_percent.Size = new System.Drawing.Size(100, 20);
            this.UB_percent.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "%";
            // 
            // upper_boundary
            // 
            this.upper_boundary.Location = new System.Drawing.Point(123, 217);
            this.upper_boundary.Name = "upper_boundary";
            this.upper_boundary.Size = new System.Drawing.Size(150, 20);
            this.upper_boundary.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Верхня межа = ";
            // 
            // lb_percent
            // 
            this.lb_percent.Location = new System.Drawing.Point(123, 168);
            this.lb_percent.Name = "lb_percent";
            this.lb_percent.Size = new System.Drawing.Size(100, 20);
            this.lb_percent.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "%";
            // 
            // lower_boundary
            // 
            this.lower_boundary.Location = new System.Drawing.Point(123, 133);
            this.lower_boundary.Name = "lower_boundary";
            this.lower_boundary.Size = new System.Drawing.Size(150, 20);
            this.lower_boundary.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Нижня межа = ";
            // 
            // math_expectations
            // 
            this.math_expectations.Location = new System.Drawing.Point(123, 91);
            this.math_expectations.Name = "math_expectations";
            this.math_expectations.Size = new System.Drawing.Size(150, 20);
            this.math_expectations.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Мат. сподівання = ";
            // 
            // amount_of_parts
            // 
            this.amount_of_parts.Location = new System.Drawing.Point(123, 55);
            this.amount_of_parts.Name = "amount_of_parts";
            this.amount_of_parts.Size = new System.Drawing.Size(150, 20);
            this.amount_of_parts.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Кількість розбиттів = ";
            // 
            // interval_width
            // 
            this.interval_width.Location = new System.Drawing.Point(123, 20);
            this.interval_width.Name = "interval_width";
            this.interval_width.Size = new System.Drawing.Size(150, 20);
            this.interval_width.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ширина інтервалу = ";
            // 
            // interval_var_row
            // 
            this.interval_var_row.Controls.Add(this.variable_row);
            this.interval_var_row.Location = new System.Drawing.Point(7, 19);
            this.interval_var_row.Name = "interval_var_row";
            this.interval_var_row.Size = new System.Drawing.Size(590, 555);
            this.interval_var_row.TabIndex = 1;
            this.interval_var_row.TabStop = false;
            this.interval_var_row.Text = "Інтервальний варіаційний ряд ";
            // 
            // histogram
            // 
            this.histogram.Controls.Add(this.build_histogram);
            this.histogram.Controls.Add(this.histogram_holder);
            this.histogram.Location = new System.Drawing.Point(4, 22);
            this.histogram.Name = "histogram";
            this.histogram.Padding = new System.Windows.Forms.Padding(3);
            this.histogram.Size = new System.Drawing.Size(933, 605);
            this.histogram.TabIndex = 2;
            this.histogram.Text = "Гістограма";
            this.histogram.UseVisualStyleBackColor = true;
            // 
            // build_histogram
            // 
            this.build_histogram.Location = new System.Drawing.Point(684, 234);
            this.build_histogram.Name = "build_histogram";
            this.build_histogram.Size = new System.Drawing.Size(189, 57);
            this.build_histogram.TabIndex = 1;
            this.build_histogram.Text = "Побудувати гістограму";
            this.build_histogram.UseVisualStyleBackColor = true;
            this.build_histogram.Click += new System.EventHandler(this.build_histogram_Click);
            // 
            // histogram_holder
            // 
            this.histogram_holder.Controls.Add(this.label1);
            this.histogram_holder.Controls.Add(this.graph);
            this.histogram_holder.Location = new System.Drawing.Point(7, 6);
            this.histogram_holder.Name = "histogram_holder";
            this.histogram_holder.Size = new System.Drawing.Size(589, 555);
            this.histogram_holder.TabIndex = 0;
            this.histogram_holder.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(212, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гістограма";
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(29, 46);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(524, 459);
            this.graph.TabIndex = 0;
            this.graph.TabStop = false;
            // 
            // listView1
            // 
            this.variable_row.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.variable_row.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.interval_num,
            this.inreval_start,
            this.interval_end,
            this.Frequency,
            this.rel_frequency,
            this.acc_frequency});
            this.variable_row.HotTracking = true;
            this.variable_row.HoverSelection = true;
            this.variable_row.Location = new System.Drawing.Point(15, 19);
            this.variable_row.Name = "listView1";
            this.variable_row.Size = new System.Drawing.Size(558, 530);
            this.variable_row.TabIndex = 0;
            this.variable_row.UseCompatibleStateImageBehavior = false;
            // 
            // interval_num
            // 
            this.interval_num.Text = "Номер інтервалу";
            // 
            // inreval_start
            // 
            this.inreval_start.Text = "Початок інтервалу";
            // 
            // interval_end
            // 
            this.interval_end.Text = "Кінець інтервалу";
            // 
            // Frequency
            // 
            this.Frequency.Text = "Частота попадання";
            // 
            // rel_frequency
            // 
            this.rel_frequency.Text = "Відносна частота";
            // 
            // acc_frequency
            // 
            this.acc_frequency.Text = "Накопичена частота";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 668);
            this.Controls.Add(this.Generate);
            this.Name = "Form1";
            this.Text = "work_form";
            this.Generate.ResumeLayout(false);
            this.generating.ResumeLayout(false);
            this.selection_generate.ResumeLayout(false);
            this.selection_generate.PerformLayout();
            this.termal_formation.ResumeLayout(false);
            this.termal_formation.PerformLayout();
            this.greenhouse_gases.ResumeLayout(false);
            this.greenhouse_gases.PerformLayout();
            this.N20_db_type.ResumeLayout(false);
            this.N20_db_type.PerformLayout();
            this.CH4_db_type.ResumeLayout(false);
            this.CH4_db_type.PerformLayout();
            this.CO2_db_type.ResumeLayout(false);
            this.CO2_db_type.PerformLayout();
            this.graph_holder.ResumeLayout(false);
            this.graph_holder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            this.variants.ResumeLayout(false);
            this.row_params.ResumeLayout(false);
            this.row_params.PerformLayout();
            this.interval_var_row.ResumeLayout(false);
            this.histogram.ResumeLayout(false);
            this.histogram_holder.ResumeLayout(false);
            this.histogram_holder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Generate;
        private System.Windows.Forms.TabPage generating;
        private System.Windows.Forms.GroupBox graph_holder;
        private System.Windows.Forms.Label graph_name;
        private System.Windows.Forms.PictureBox diagram;
        private System.Windows.Forms.TabPage variants;
        private System.Windows.Forms.GroupBox interval_var_row;
        private System.Windows.Forms.TabPage histogram;
        private System.Windows.Forms.GroupBox histogram_holder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox graph;
        private System.Windows.Forms.GroupBox selection_generate;
        private System.Windows.Forms.Button do_generate;
        private System.Windows.Forms.TextBox addintion_textbox;
        private System.Windows.Forms.GroupBox termal_formation;
        private System.Windows.Forms.RadioButton tf_db_logordinary;
        private System.Windows.Forms.RadioButton tf_db_ordinary;
        private System.Windows.Forms.GroupBox greenhouse_gases;
        private System.Windows.Forms.RadioButton total;
        private System.Windows.Forms.GroupBox N20_db_type;
        private System.Windows.Forms.RadioButton N20_logordinary;
        private System.Windows.Forms.RadioButton N20_ordinary;
        private System.Windows.Forms.RadioButton nitrous_oxide;
        private System.Windows.Forms.GroupBox CH4_db_type;
        private System.Windows.Forms.RadioButton CH4_logordinary;
        private System.Windows.Forms.RadioButton CH4_ordinary;
        private System.Windows.Forms.RadioButton methane;
        private System.Windows.Forms.GroupBox CO2_db_type;
        private System.Windows.Forms.RadioButton CO2_logordinary;
        private System.Windows.Forms.RadioButton CO2_ordinary;
        private System.Windows.Forms.RadioButton carbon_dioxid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button do_build;
        private System.Windows.Forms.GroupBox row_params;
        private System.Windows.Forms.TextBox UB_percent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox upper_boundary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lb_percent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lower_boundary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox math_expectations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amount_of_parts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox interval_width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button build_histogram;
        private System.Windows.Forms.ListView variable_row;
        private System.Windows.Forms.ColumnHeader interval_num;
        private System.Windows.Forms.ColumnHeader inreval_start;
        private System.Windows.Forms.ColumnHeader interval_end;
        private System.Windows.Forms.ColumnHeader Frequency;
        private System.Windows.Forms.ColumnHeader rel_frequency;
        private System.Windows.Forms.ColumnHeader acc_frequency;
    }
}

