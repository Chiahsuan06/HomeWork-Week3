
namespace UseLicenseTax
{
    partial class LicenseTax
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.radioButtonPeriod = new System.Windows.Forms.RadioButton();
            this.txtdate1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUse = new System.Windows.Forms.ComboBox();
            this.cmbCCscooter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdate2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.butSend = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCCtruck = new System.Windows.Forms.ComboBox();
            this.cmbCCcoach = new System.Windows.Forms.ComboBox();
            this.cmbCCcar = new System.Windows.Forms.ComboBox();
            this.cmbCCBusinesscar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonYear.Location = new System.Drawing.Point(92, 135);
            this.radioButtonYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(93, 29);
            this.radioButtonYear.TabIndex = 0;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "全年度";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            this.radioButtonYear.Click += new System.EventHandler(this.radioButtonYear_Click);
            // 
            // radioButtonPeriod
            // 
            this.radioButtonPeriod.AutoSize = true;
            this.radioButtonPeriod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonPeriod.Location = new System.Drawing.Point(272, 135);
            this.radioButtonPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPeriod.Name = "radioButtonPeriod";
            this.radioButtonPeriod.Size = new System.Drawing.Size(93, 29);
            this.radioButtonPeriod.TabIndex = 1;
            this.radioButtonPeriod.TabStop = true;
            this.radioButtonPeriod.Text = "依期間";
            this.radioButtonPeriod.UseVisualStyleBackColor = true;
            this.radioButtonPeriod.Click += new System.EventHandler(this.radioButtonPeriod_Click);
            // 
            // txtdate1
            // 
            this.txtdate1.Location = new System.Drawing.Point(66, 47);
            this.txtdate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdate1.Name = "txtdate1";
            this.txtdate1.Size = new System.Drawing.Size(148, 34);
            this.txtdate1.TabIndex = 2;
            this.txtdate1.Click += new System.EventHandler(this.txtdate1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "使用期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(51, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "用途";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(51, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "汽缸CC數／馬達馬力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(51, 464);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "試算結果";
            // 
            // cmbUse
            // 
            this.cmbUse.AutoCompleteCustomSource.AddRange(new string[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cmbUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbUse.FormattingEnabled = true;
            this.cmbUse.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cmbUse.Location = new System.Drawing.Point(56, 265);
            this.cmbUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUse.Name = "cmbUse";
            this.cmbUse.Size = new System.Drawing.Size(538, 33);
            this.cmbUse.TabIndex = 10;
            this.cmbUse.SelectedIndexChanged += new System.EventHandler(this.cmbUse_SelectedIndexChanged);
            // 
            // cmbCCscooter
            // 
            this.cmbCCscooter.AutoCompleteCustomSource.AddRange(new string[] {
            "150以下 / 12HP以下(12.2PS以下)",
            "151-250 / 12.1-20HP(12.3-20.3PS)",
            "251-500 / 20.1HP以上(20.4PS以上)",
            "501-600",
            "601-1200",
            "1201-1800",
            "1801或以上"});
            this.cmbCCscooter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCCscooter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCCscooter.FormattingEnabled = true;
            this.cmbCCscooter.Items.AddRange(new object[] {
            "150以下 / 12HP以下(12.2PS以下)",
            "151-250 / 12.1-20HP(12.3-20.3PS)",
            "251-500 / 20.1HP以上(20.4PS以上)",
            "501-600",
            "601-1200",
            "1201-1800",
            "1801或以上"});
            this.cmbCCscooter.Location = new System.Drawing.Point(56, 379);
            this.cmbCCscooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCCscooter.Name = "cmbCCscooter";
            this.cmbCCscooter.Size = new System.Drawing.Size(538, 33);
            this.cmbCCscooter.TabIndex = 11;
            this.cmbCCscooter.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "從";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "至";
            // 
            // txtdate2
            // 
            this.txtdate2.Location = new System.Drawing.Point(394, 47);
            this.txtdate2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdate2.Name = "txtdate2";
            this.txtdate2.Size = new System.Drawing.Size(148, 34);
            this.txtdate2.TabIndex = 14;
            this.txtdate2.Click += new System.EventHandler(this.txtdate2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 80);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 34);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(394, 80);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(206, 34);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            this.dateTimePicker2.Visible = false;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // butSend
            // 
            this.butSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSend.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butSend.Location = new System.Drawing.Point(656, 299);
            this.butSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(225, 77);
            this.butSend.TabIndex = 17;
            this.butSend.Text = "確認送出";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // butCancel
            // 
            this.butCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butCancel.Location = new System.Drawing.Point(921, 299);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(225, 77);
            this.butCancel.TabIndex = 18;
            this.butCancel.Text = "取消重填";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoEllipsis = true;
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblresult.Location = new System.Drawing.Point(13, 14);
            this.lblresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(52, 25);
            this.lblresult.TabIndex = 19;
            this.lblresult.Text = "結果";
            this.lblresult.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdate2);
            this.groupBox1.Controls.Add(this.txtdate1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(440, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(610, 126);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // cmbCCtruck
            // 
            this.cmbCCtruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCCtruck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCCtruck.FormattingEnabled = true;
            this.cmbCCtruck.Items.AddRange(new object[] {
            "500以下",
            "501~600",
            "601~1200",
            "1201~1800",
            "1801~2400",
            "2401~3000",
            "3001~3600",
            "3601~4200",
            "4201~4800",
            "4801~5400",
            "5401~6000",
            "6001~6600",
            "6601~7200",
            "7201~7800",
            "7801~8400",
            "8401~9000",
            "9001~9600",
            "9601~10200",
            "10201以上"});
            this.cmbCCtruck.Location = new System.Drawing.Point(56, 379);
            this.cmbCCtruck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCCtruck.Name = "cmbCCtruck";
            this.cmbCCtruck.Size = new System.Drawing.Size(538, 33);
            this.cmbCCtruck.TabIndex = 21;
            this.cmbCCtruck.Visible = false;
            // 
            // cmbCCcoach
            // 
            this.cmbCCcoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCCcoach.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCCcoach.FormattingEnabled = true;
            this.cmbCCcoach.Items.AddRange(new object[] {
            "501~600",
            "601~1200",
            "1201~1800",
            "1801~2400",
            "2401~3000",
            "3001~3600",
            "3601~4200",
            "4201~4800",
            "4801~5400",
            "5401~6000",
            "6001~6600",
            "6601~7200",
            "7201~7800",
            "7801~8400",
            "8401~9000",
            "9001~9600",
            "9601~10200",
            "10201以上"});
            this.cmbCCcoach.Location = new System.Drawing.Point(56, 379);
            this.cmbCCcoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCCcoach.Name = "cmbCCcoach";
            this.cmbCCcoach.Size = new System.Drawing.Size(538, 33);
            this.cmbCCcoach.TabIndex = 22;
            this.cmbCCcoach.Visible = false;
            // 
            // cmbCCcar
            // 
            this.cmbCCcar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCCcar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCCcar.FormattingEnabled = true;
            this.cmbCCcar.Items.AddRange(new object[] {
            "500以下",
            "501~600",
            "601~1200",
            "1201~1800",
            "1801~2400",
            "2401~4200",
            "4201~5400",
            "5401~6600",
            "6601~7800",
            "7801以上"});
            this.cmbCCcar.Location = new System.Drawing.Point(56, 379);
            this.cmbCCcar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCCcar.Name = "cmbCCcar";
            this.cmbCCcar.Size = new System.Drawing.Size(538, 33);
            this.cmbCCcar.TabIndex = 23;
            this.cmbCCcar.Visible = false;
            // 
            // cmbCCBusinesscar
            // 
            this.cmbCCBusinesscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCCBusinesscar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCCBusinesscar.FormattingEnabled = true;
            this.cmbCCBusinesscar.Items.AddRange(new object[] {
            "500以下",
            "501~600",
            "601~1200",
            "1201~1800",
            "1801~2400",
            "2401~4200",
            "4201~5400",
            "5401~6600",
            "6601~7800",
            "7801以上"});
            this.cmbCCBusinesscar.Location = new System.Drawing.Point(56, 379);
            this.cmbCCBusinesscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCCBusinesscar.Name = "cmbCCBusinesscar";
            this.cmbCCBusinesscar.Size = new System.Drawing.Size(538, 33);
            this.cmbCCBusinesscar.TabIndex = 24;
            this.cmbCCBusinesscar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblresult);
            this.panel1.Location = new System.Drawing.Point(56, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 343);
            this.panel1.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 379);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(538, 33);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // LicenseTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1202, 867);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButtonPeriod);
            this.Controls.Add(this.radioButtonYear);
            this.Controls.Add(this.cmbCCBusinesscar);
            this.Controls.Add(this.cmbCCcar);
            this.Controls.Add(this.cmbCCcoach);
            this.Controls.Add(this.cmbCCtruck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.cmbCCscooter);
            this.Controls.Add(this.cmbUse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LicenseTax";
            this.Text = "使用牌照稅應納稅額試算";
            this.Load += new System.EventHandler(this.LicenseTax_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.RadioButton radioButtonPeriod;
        private System.Windows.Forms.TextBox txtdate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUse;
        private System.Windows.Forms.ComboBox cmbCCscooter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdate2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCCtruck;
        private System.Windows.Forms.ComboBox cmbCCcoach;
        private System.Windows.Forms.ComboBox cmbCCcar;
        private System.Windows.Forms.ComboBox cmbCCBusinesscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

