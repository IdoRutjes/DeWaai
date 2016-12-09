﻿namespace DeWaaiBeheer
{
    partial class frmCourses
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
            this.lblNieuweOpgaven = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCoursenumber = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNavigation = new System.Windows.Forms.Label();
            this.tlpNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCharts = new System.Windows.Forms.Button();
            this.btnRegistrations = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnInstructors = new System.Windows.Forms.Button();
            this.btnFleets = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNieuweOpgaven
            // 
            this.lblNieuweOpgaven.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblNieuweOpgaven, 3);
            this.lblNieuweOpgaven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNieuweOpgaven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNieuweOpgaven.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNieuweOpgaven.Location = new System.Drawing.Point(3, 0);
            this.lblNieuweOpgaven.Name = "lblNieuweOpgaven";
            this.lblNieuweOpgaven.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNieuweOpgaven.Size = new System.Drawing.Size(256, 35);
            this.lblNieuweOpgaven.TabIndex = 2;
            this.lblNieuweOpgaven.Text = "Cursussen";
            this.lblNieuweOpgaven.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.9421F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.171291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.930036F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.40531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.84922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.930036F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.447527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02413F));
            this.tableLayoutPanel1.Controls.Add(this.lblNieuweOpgaven, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstCourses, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCoursenumber, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrice, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtColor, 6, 10);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.dtpDate, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNavigation, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlpNavigation, 9, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.934837F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.893174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.1689F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.53341F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.506681F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.28503F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.327339F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.854619F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.590979F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.588377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.378983F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.937676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 400);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lstCourses
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lstCourses, 3);
            this.lstCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(3, 38);
            this.lstCourses.Name = "lstCourses";
            this.tableLayoutPanel1.SetRowSpan(this.lstCourses, 10);
            this.lstCourses.Size = new System.Drawing.Size(256, 327);
            this.lstCourses.TabIndex = 0;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(3, 371);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(76, 26);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Nieuw";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(85, 371);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 26);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Wijzig";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(167, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 26);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prijs:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naam:";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(432, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 20);
            this.txtName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 90);
            this.label2.Name = "label2";
            this.tableLayoutPanel1.SetRowSpan(this.label2, 2);
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Beschrijving:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(432, 93);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.tableLayoutPanel1.SetRowSpan(this.txtDescription, 3);
            this.txtDescription.Size = new System.Drawing.Size(198, 139);
            this.txtDescription.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(297, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cursusnummer:";
            // 
            // txtCoursenumber
            // 
            this.txtCoursenumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCoursenumber.Location = new System.Drawing.Point(432, 38);
            this.txtCoursenumber.Name = "txtCoursenumber";
            this.txtCoursenumber.ReadOnly = true;
            this.txtCoursenumber.Size = new System.Drawing.Size(198, 20);
            this.txtCoursenumber.TabIndex = 28;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(432, 263);
            this.txtPrice.Name = "txtPrice";
            this.tableLayoutPanel1.SetRowSpan(this.txtPrice, 2);
            this.txtPrice.Size = new System.Drawing.Size(198, 20);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kleur";
            // 
            // txtColor
            // 
            this.txtColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtColor.Location = new System.Drawing.Point(432, 342);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(198, 20);
            this.txtColor.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vrije plaatsen:";
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmount.Location = new System.Drawing.Point(432, 316);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(198, 20);
            this.txtAmount.TabIndex = 31;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Location = new System.Drawing.Point(432, 238);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(198, 20);
            this.dtpDate.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(662, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(164, 35);
            this.label9.TabIndex = 2;
            this.label9.Text = "Navigeren";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 2);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(297, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(333, 35);
            this.label8.TabIndex = 2;
            this.label8.Text = "Gegevens";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SkyBlue;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(282, 35);
            this.label10.Name = "label10";
            this.tableLayoutPanel1.SetRowSpan(this.label10, 10);
            this.label10.Size = new System.Drawing.Size(9, 333);
            this.label10.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SkyBlue;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(636, 35);
            this.label11.Name = "label11";
            this.tableLayoutPanel1.SetRowSpan(this.label11, 10);
            this.label11.Size = new System.Drawing.Size(9, 333);
            this.label11.TabIndex = 34;
            // 
            // lblNavigation
            // 
            this.lblNavigation.AutoSize = true;
            this.lblNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNavigation.Location = new System.Drawing.Point(662, 35);
            this.lblNavigation.Name = "lblNavigation";
            this.lblNavigation.Size = new System.Drawing.Size(164, 27);
            this.lblNavigation.TabIndex = 35;
            this.lblNavigation.Text = "▼";
            this.lblNavigation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNavigation.Click += new System.EventHandler(this.lblNavigation_Click);
            this.lblNavigation.MouseEnter += new System.EventHandler(this.lblNavigation_MouseEnter);
            this.lblNavigation.MouseLeave += new System.EventHandler(this.lblNavigation_MouseLeave);
            // 
            // tlpNavigation
            // 
            this.tlpNavigation.ColumnCount = 1;
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavigation.Controls.Add(this.btnHome, 0, 0);
            this.tlpNavigation.Controls.Add(this.btnCharts, 0, 1);
            this.tlpNavigation.Controls.Add(this.btnRegistrations, 0, 2);
            this.tlpNavigation.Controls.Add(this.btnUsers, 0, 3);
            this.tlpNavigation.Controls.Add(this.btnInstructors, 0, 4);
            this.tlpNavigation.Controls.Add(this.btnFleets, 0, 5);
            this.tlpNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavigation.Location = new System.Drawing.Point(662, 65);
            this.tlpNavigation.Name = "tlpNavigation";
            this.tlpNavigation.RowCount = 6;
            this.tableLayoutPanel1.SetRowSpan(this.tlpNavigation, 9);
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpNavigation.Size = new System.Drawing.Size(164, 300);
            this.tlpNavigation.TabIndex = 36;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(158, 43);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCharts
            // 
            this.btnCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCharts.Location = new System.Drawing.Point(3, 52);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(158, 43);
            this.btnCharts.TabIndex = 1;
            this.btnCharts.Text = "Overzicht";
            this.btnCharts.UseVisualStyleBackColor = true;
            this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click);
            // 
            // btnRegistrations
            // 
            this.btnRegistrations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegistrations.Location = new System.Drawing.Point(3, 101);
            this.btnRegistrations.Name = "btnRegistrations";
            this.btnRegistrations.Size = new System.Drawing.Size(158, 43);
            this.btnRegistrations.TabIndex = 2;
            this.btnRegistrations.Text = "Inschrijvingen";
            this.btnRegistrations.UseVisualStyleBackColor = true;
            this.btnRegistrations.Click += new System.EventHandler(this.btnRegistrations_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.Location = new System.Drawing.Point(3, 150);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(158, 43);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Klanten";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnInstructors
            // 
            this.btnInstructors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstructors.Location = new System.Drawing.Point(3, 199);
            this.btnInstructors.Name = "btnInstructors";
            this.btnInstructors.Size = new System.Drawing.Size(158, 43);
            this.btnInstructors.TabIndex = 4;
            this.btnInstructors.Text = "Instructeurs";
            this.btnInstructors.UseVisualStyleBackColor = true;
            this.btnInstructors.Click += new System.EventHandler(this.btnInstructors_Click);
            // 
            // btnFleets
            // 
            this.btnFleets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFleets.Location = new System.Drawing.Point(3, 248);
            this.btnFleets.Name = "btnFleets";
            this.btnFleets.Size = new System.Drawing.Size(158, 49);
            this.btnFleets.TabIndex = 5;
            this.btnFleets.Text = "Vloten";
            this.btnFleets.UseVisualStyleBackColor = true;
            this.btnFleets.Click += new System.EventHandler(this.btnFleets_Click);
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursussen overzicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCourses_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNieuweOpgaven;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCoursenumber;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.TableLayoutPanel tlpNavigation;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCharts;
        private System.Windows.Forms.Button btnRegistrations;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnInstructors;
        private System.Windows.Forms.Button btnFleets;
    }
}