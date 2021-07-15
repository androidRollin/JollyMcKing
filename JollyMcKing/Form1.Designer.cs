
namespace JollyMcKing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTypeOrder = new System.Windows.Forms.Label();
            this.rbDriveIn = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.cbValueMeal = new System.Windows.Forms.CheckBox();
            this.cbMeal1 = new System.Windows.Forms.CheckBox();
            this.cbMeal3 = new System.Windows.Forms.CheckBox();
            this.cbMeal2 = new System.Windows.Forms.CheckBox();
            this.cbMeal4 = new System.Windows.Forms.CheckBox();
            this.cbRiceMeal = new System.Windows.Forms.CheckBox();
            this.cbTapsilog = new System.Windows.Forms.CheckBox();
            this.cbTocilog = new System.Windows.Forms.CheckBox();
            this.cbHotsilog = new System.Windows.Forms.CheckBox();
            this.cbHamsilog = new System.Windows.Forms.CheckBox();
            this.cbBeverages = new System.Windows.Forms.CheckBox();
            this.cbSoda = new System.Windows.Forms.CheckBox();
            this.cbIcedTea = new System.Windows.Forms.CheckBox();
            this.cbJuice = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.tbTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblAmountGiven = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.tbAmountGiven = new System.Windows.Forms.TextBox();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbUserPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbUpSize = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTypeOrder
            // 
            this.lblTypeOrder.AutoSize = true;
            this.lblTypeOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTypeOrder.Location = new System.Drawing.Point(19, 33);
            this.lblTypeOrder.Name = "lblTypeOrder";
            this.lblTypeOrder.Size = new System.Drawing.Size(77, 13);
            this.lblTypeOrder.TabIndex = 5;
            this.lblTypeOrder.Text = "Type of Order";
            // 
            // rbDriveIn
            // 
            this.rbDriveIn.AutoSize = true;
            this.rbDriveIn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDriveIn.Location = new System.Drawing.Point(114, 31);
            this.rbDriveIn.Name = "rbDriveIn";
            this.rbDriveIn.Size = new System.Drawing.Size(65, 17);
            this.rbDriveIn.TabIndex = 6;
            this.rbDriveIn.TabStop = true;
            this.rbDriveIn.Text = "Drive-In";
            this.rbDriveIn.UseVisualStyleBackColor = true;
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbTakeOut.Location = new System.Drawing.Point(200, 31);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(71, 17);
            this.rbTakeOut.TabIndex = 7;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            // 
            // cbValueMeal
            // 
            this.cbValueMeal.AutoSize = true;
            this.cbValueMeal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbValueMeal.Location = new System.Drawing.Point(19, 64);
            this.cbValueMeal.Name = "cbValueMeal";
            this.cbValueMeal.Size = new System.Drawing.Size(82, 17);
            this.cbValueMeal.TabIndex = 8;
            this.cbValueMeal.Text = "Value Meal";
            this.cbValueMeal.UseVisualStyleBackColor = true;
            this.cbValueMeal.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbMeal1
            // 
            this.cbMeal1.AutoSize = true;
            this.cbMeal1.Enabled = false;
            this.cbMeal1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMeal1.Location = new System.Drawing.Point(51, 90);
            this.cbMeal1.Name = "cbMeal1";
            this.cbMeal1.Size = new System.Drawing.Size(60, 17);
            this.cbMeal1.TabIndex = 9;
            this.cbMeal1.Text = "Meal 1";
            this.cbMeal1.UseVisualStyleBackColor = true;
            this.cbMeal1.CheckedChanged += new System.EventHandler(this.cbMeal1_CheckedChanged);
            // 
            // cbMeal3
            // 
            this.cbMeal3.AutoSize = true;
            this.cbMeal3.Enabled = false;
            this.cbMeal3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMeal3.Location = new System.Drawing.Point(51, 116);
            this.cbMeal3.Name = "cbMeal3";
            this.cbMeal3.Size = new System.Drawing.Size(60, 17);
            this.cbMeal3.TabIndex = 10;
            this.cbMeal3.Text = "Meal 3";
            this.cbMeal3.UseVisualStyleBackColor = true;
            this.cbMeal3.CheckedChanged += new System.EventHandler(this.cbMeal3_CheckedChanged);
            // 
            // cbMeal2
            // 
            this.cbMeal2.AutoSize = true;
            this.cbMeal2.Enabled = false;
            this.cbMeal2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMeal2.Location = new System.Drawing.Point(140, 90);
            this.cbMeal2.Name = "cbMeal2";
            this.cbMeal2.Size = new System.Drawing.Size(60, 17);
            this.cbMeal2.TabIndex = 11;
            this.cbMeal2.Text = "Meal 2";
            this.cbMeal2.UseVisualStyleBackColor = true;
            this.cbMeal2.CheckedChanged += new System.EventHandler(this.cbMeal2_CheckedChanged);
            // 
            // cbMeal4
            // 
            this.cbMeal4.AutoSize = true;
            this.cbMeal4.Enabled = false;
            this.cbMeal4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMeal4.Location = new System.Drawing.Point(140, 115);
            this.cbMeal4.Name = "cbMeal4";
            this.cbMeal4.Size = new System.Drawing.Size(60, 17);
            this.cbMeal4.TabIndex = 12;
            this.cbMeal4.Text = "Meal 4";
            this.cbMeal4.UseVisualStyleBackColor = true;
            this.cbMeal4.CheckedChanged += new System.EventHandler(this.cbMeal4_CheckedChanged);
            // 
            // cbRiceMeal
            // 
            this.cbRiceMeal.AutoSize = true;
            this.cbRiceMeal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRiceMeal.Location = new System.Drawing.Point(19, 141);
            this.cbRiceMeal.Name = "cbRiceMeal";
            this.cbRiceMeal.Size = new System.Drawing.Size(78, 17);
            this.cbRiceMeal.TabIndex = 13;
            this.cbRiceMeal.Text = "Rice Meal ";
            this.cbRiceMeal.UseVisualStyleBackColor = true;
            this.cbRiceMeal.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // cbTapsilog
            // 
            this.cbTapsilog.AutoSize = true;
            this.cbTapsilog.Enabled = false;
            this.cbTapsilog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTapsilog.Location = new System.Drawing.Point(51, 167);
            this.cbTapsilog.Name = "cbTapsilog";
            this.cbTapsilog.Size = new System.Drawing.Size(69, 17);
            this.cbTapsilog.TabIndex = 14;
            this.cbTapsilog.Text = "Tapsilog";
            this.cbTapsilog.UseVisualStyleBackColor = true;
            this.cbTapsilog.CheckedChanged += new System.EventHandler(this.cbTapsilog_CheckedChanged);
            // 
            // cbTocilog
            // 
            this.cbTocilog.AutoSize = true;
            this.cbTocilog.Enabled = false;
            this.cbTocilog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTocilog.Location = new System.Drawing.Point(140, 167);
            this.cbTocilog.Name = "cbTocilog";
            this.cbTocilog.Size = new System.Drawing.Size(63, 17);
            this.cbTocilog.TabIndex = 15;
            this.cbTocilog.Text = "Tocilog";
            this.cbTocilog.UseVisualStyleBackColor = true;
            this.cbTocilog.CheckedChanged += new System.EventHandler(this.cbTocilog_CheckedChanged);
            // 
            // cbHotsilog
            // 
            this.cbHotsilog.AutoSize = true;
            this.cbHotsilog.Enabled = false;
            this.cbHotsilog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHotsilog.Location = new System.Drawing.Point(51, 193);
            this.cbHotsilog.Name = "cbHotsilog";
            this.cbHotsilog.Size = new System.Drawing.Size(70, 17);
            this.cbHotsilog.TabIndex = 16;
            this.cbHotsilog.Text = "Hotsilog";
            this.cbHotsilog.UseVisualStyleBackColor = true;
            this.cbHotsilog.CheckedChanged += new System.EventHandler(this.cbHotsilog_CheckedChanged);
            // 
            // cbHamsilog
            // 
            this.cbHamsilog.AutoSize = true;
            this.cbHamsilog.Enabled = false;
            this.cbHamsilog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHamsilog.Location = new System.Drawing.Point(140, 192);
            this.cbHamsilog.Name = "cbHamsilog";
            this.cbHamsilog.Size = new System.Drawing.Size(74, 17);
            this.cbHamsilog.TabIndex = 17;
            this.cbHamsilog.Text = "Hamsilog";
            this.cbHamsilog.UseVisualStyleBackColor = true;
            this.cbHamsilog.CheckedChanged += new System.EventHandler(this.cbHamsilog_CheckedChanged);
            // 
            // cbBeverages
            // 
            this.cbBeverages.AutoSize = true;
            this.cbBeverages.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBeverages.Location = new System.Drawing.Point(19, 225);
            this.cbBeverages.Name = "cbBeverages";
            this.cbBeverages.Size = new System.Drawing.Size(77, 17);
            this.cbBeverages.TabIndex = 18;
            this.cbBeverages.Text = "Beverages";
            this.cbBeverages.UseVisualStyleBackColor = true;
            this.cbBeverages.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // cbSoda
            // 
            this.cbSoda.AutoSize = true;
            this.cbSoda.Enabled = false;
            this.cbSoda.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSoda.Location = new System.Drawing.Point(51, 251);
            this.cbSoda.Name = "cbSoda";
            this.cbSoda.Size = new System.Drawing.Size(52, 17);
            this.cbSoda.TabIndex = 19;
            this.cbSoda.Text = "Soda";
            this.cbSoda.UseVisualStyleBackColor = true;
            this.cbSoda.CheckedChanged += new System.EventHandler(this.cbSoda_CheckedChanged);
            // 
            // cbIcedTea
            // 
            this.cbIcedTea.AutoSize = true;
            this.cbIcedTea.Enabled = false;
            this.cbIcedTea.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbIcedTea.Location = new System.Drawing.Point(51, 277);
            this.cbIcedTea.Name = "cbIcedTea";
            this.cbIcedTea.Size = new System.Drawing.Size(60, 17);
            this.cbIcedTea.TabIndex = 20;
            this.cbIcedTea.Text = "Ice Tea";
            this.cbIcedTea.UseVisualStyleBackColor = true;
            this.cbIcedTea.CheckedChanged += new System.EventHandler(this.cbIcedTea_CheckedChanged);
            // 
            // cbJuice
            // 
            this.cbJuice.AutoSize = true;
            this.cbJuice.Enabled = false;
            this.cbJuice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbJuice.Location = new System.Drawing.Point(147, 250);
            this.cbJuice.Name = "cbJuice";
            this.cbJuice.Size = new System.Drawing.Size(51, 17);
            this.cbJuice.TabIndex = 21;
            this.cbJuice.Text = "Juice";
            this.cbJuice.UseVisualStyleBackColor = true;
            this.cbJuice.CheckedChanged += new System.EventHandler(this.cbJuice_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(241, 221);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Food Items";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.Enabled = false;
            this.tbTotalAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTotalAmount.Location = new System.Drawing.Point(158, 283);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.Size = new System.Drawing.Size(122, 22);
            this.tbTotalAmount.TabIndex = 24;
            this.tbTotalAmount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmount.Location = new System.Drawing.Point(76, 287);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(76, 13);
            this.lblTotalAmount.TabIndex = 25;
            this.lblTotalAmount.Text = "Total Amount";
            this.lblTotalAmount.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAmountGiven
            // 
            this.lblAmountGiven.AutoSize = true;
            this.lblAmountGiven.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmountGiven.Location = new System.Drawing.Point(17, 43);
            this.lblAmountGiven.Name = "lblAmountGiven";
            this.lblAmountGiven.Size = new System.Drawing.Size(80, 13);
            this.lblAmountGiven.TabIndex = 26;
            this.lblAmountGiven.Text = "Amount Given";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChange.Location = new System.Drawing.Point(17, 72);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(47, 13);
            this.lblChange.TabIndex = 27;
            this.lblChange.Text = "Change";
            // 
            // tbAmountGiven
            // 
            this.tbAmountGiven.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmountGiven.Location = new System.Drawing.Point(117, 36);
            this.tbAmountGiven.Name = "tbAmountGiven";
            this.tbAmountGiven.Size = new System.Drawing.Size(163, 22);
            this.tbAmountGiven.TabIndex = 28;
            // 
            // tbChange
            // 
            this.tbChange.Enabled = false;
            this.tbChange.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbChange.Location = new System.Drawing.Point(117, 69);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(163, 22);
            this.tbChange.TabIndex = 29;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(159, 552);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5);
            this.btnExit.Size = new System.Drawing.Size(64, 34);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompute.Location = new System.Drawing.Point(117, 110);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 31;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.Location = new System.Drawing.Point(100, 96);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tbUserPass
            // 
            this.tbUserPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUserPass.Location = new System.Drawing.Point(100, 61);
            this.tbUserPass.Name = "tbUserPass";
            this.tbUserPass.PasswordChar = '*';
            this.tbUserPass.Size = new System.Drawing.Size(147, 22);
            this.tbUserPass.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(19, 64);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUserName.Location = new System.Drawing.Point(100, 32);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(147, 22);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(19, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.btnLogIn);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.tbUserPass);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(44, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 135);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log - In";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOrder);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lblTypeOrder);
            this.groupBox2.Controls.Add(this.rbDriveIn);
            this.groupBox2.Controls.Add(this.rbTakeOut);
            this.groupBox2.Controls.Add(this.cbValueMeal);
            this.groupBox2.Controls.Add(this.cbMeal1);
            this.groupBox2.Controls.Add(this.cbMeal3);
            this.groupBox2.Controls.Add(this.cbMeal2);
            this.groupBox2.Controls.Add(this.cbMeal4);
            this.groupBox2.Controls.Add(this.cbRiceMeal);
            this.groupBox2.Controls.Add(this.cbTapsilog);
            this.groupBox2.Controls.Add(this.cbTocilog);
            this.groupBox2.Controls.Add(this.cbHotsilog);
            this.groupBox2.Controls.Add(this.cbJuice);
            this.groupBox2.Controls.Add(this.cbHamsilog);
            this.groupBox2.Controls.Add(this.cbIcedTea);
            this.groupBox2.Controls.Add(this.cbBeverages);
            this.groupBox2.Controls.Add(this.cbSoda);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(44, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 369);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(114, 320);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 37;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbUpSize);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(140, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 33);
            this.panel1.TabIndex = 36;
            // 
            // rbUpSize
            // 
            this.rbUpSize.AutoSize = true;
            this.rbUpSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbUpSize.Location = new System.Drawing.Point(7, 7);
            this.rbUpSize.Name = "rbUpSize";
            this.rbUpSize.Size = new System.Drawing.Size(64, 17);
            this.rbUpSize.TabIndex = 0;
            this.rbUpSize.TabStop = true;
            this.rbUpSize.Text = "Up-Size";
            this.rbUpSize.UseVisualStyleBackColor = true;
            this.rbUpSize.CheckedChanged += new System.EventHandler(this.rbUpSize_CheckedChanged);
            this.rbUpSize.Click += new System.EventHandler(this.rbUpSize_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.lblTotalAmount);
            this.groupBox3.Controls.Add(this.tbTotalAmount);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(366, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 351);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Summary";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblAmountGiven);
            this.groupBox4.Controls.Add(this.lblChange);
            this.groupBox4.Controls.Add(this.tbAmountGiven);
            this.groupBox4.Controls.Add(this.tbChange);
            this.groupBox4.Controls.Add(this.btnCompute);
            this.groupBox4.Enabled = false;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(366, 397);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 149);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 612);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JollyMcKing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTypeOrder;
        private System.Windows.Forms.RadioButton rbDriveIn;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.CheckBox cbValueMeal;
        private System.Windows.Forms.CheckBox cbMeal1;
        private System.Windows.Forms.CheckBox cbMeal3;
        private System.Windows.Forms.CheckBox cbMeal2;
        private System.Windows.Forms.CheckBox cbMeal4;
        private System.Windows.Forms.CheckBox cbRiceMeal;
        private System.Windows.Forms.CheckBox cbTapsilog;
        private System.Windows.Forms.CheckBox cbTocilog;
        private System.Windows.Forms.CheckBox cbHotsilog;
        private System.Windows.Forms.CheckBox cbHamsilog;
        private System.Windows.Forms.CheckBox cbBeverages;
        private System.Windows.Forms.CheckBox cbSoda;
        private System.Windows.Forms.CheckBox cbIcedTea;
        private System.Windows.Forms.CheckBox cbJuice;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblAmountGiven;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox tbAmountGiven;
        private System.Windows.Forms.TextBox tbChange;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox tbUserPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbUpSize;
        private System.Windows.Forms.Button btnOrder;
    }
}

