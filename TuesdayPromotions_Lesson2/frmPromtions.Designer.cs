namespace TuesdayPromotions_Lesson2
{
    partial class frmPromtions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromtions));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpDepartment = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtxMemberId = new System.Windows.Forms.MaskedTextBox();
            this.rtxWelcome = new System.Windows.Forms.RichTextBox();
            this.txtPromotion = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdoClothing = new System.Windows.Forms.RadioButton();
            this.rdoEquipmentAccessories = new System.Windows.Forms.RadioButton();
            this.rdoJuiceBar = new System.Windows.Forms.RadioButton();
            this.rdoMembership = new System.Windows.Forms.RadioButton();
            this.rdoPersonalTraining = new System.Windows.Forms.RadioButton();
            this.chkImageVisible = new System.Windows.Forms.CheckBox();
            this.picDepartment = new System.Windows.Forms.PictureBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.grpInput.SuspendLayout();
            this.grpDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Look Sharp Fitness Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(975, 713);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Anju Chawla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Member &ID";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.mtxMemberId);
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(518, 154);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(528, 132);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Please Input";
            // 
            // grpDepartment
            // 
            this.grpDepartment.Controls.Add(this.rdoPersonalTraining);
            this.grpDepartment.Controls.Add(this.rdoMembership);
            this.grpDepartment.Controls.Add(this.rdoJuiceBar);
            this.grpDepartment.Controls.Add(this.rdoEquipmentAccessories);
            this.grpDepartment.Controls.Add(this.rdoClothing);
            this.grpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDepartment.Location = new System.Drawing.Point(54, 166);
            this.grpDepartment.Name = "grpDepartment";
            this.grpDepartment.Size = new System.Drawing.Size(385, 318);
            this.grpDepartment.TabIndex = 2;
            this.grpDepartment.TabStop = false;
            this.grpDepartment.Text = "Department";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(304, 27);
            this.txtName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtName, "Please enter your name");
            // 
            // mtxMemberId
            // 
            this.mtxMemberId.Location = new System.Drawing.Point(188, 80);
            this.mtxMemberId.Mask = "00000";
            this.mtxMemberId.Name = "mtxMemberId";
            this.mtxMemberId.Size = new System.Drawing.Size(58, 27);
            this.mtxMemberId.TabIndex = 3;
            this.toolTip1.SetToolTip(this.mtxMemberId, "Please enter your 5 digited member ID");
            this.mtxMemberId.ValidatingType = typeof(int);
            // 
            // rtxWelcome
            // 
            this.rtxWelcome.Location = new System.Drawing.Point(518, 313);
            this.rtxWelcome.Name = "rtxWelcome";
            this.rtxWelcome.ReadOnly = true;
            this.rtxWelcome.Size = new System.Drawing.Size(528, 96);
            this.rtxWelcome.TabIndex = 9;
            this.rtxWelcome.TabStop = false;
            this.rtxWelcome.Text = "";
            // 
            // txtPromotion
            // 
            this.txtPromotion.Location = new System.Drawing.Point(518, 445);
            this.txtPromotion.Multiline = true;
            this.txtPromotion.Name = "txtPromotion";
            this.txtPromotion.ReadOnly = true;
            this.txtPromotion.Size = new System.Drawing.Size(528, 39);
            this.txtPromotion.TabIndex = 10;
            this.txtPromotion.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(950, 504);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(96, 37);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "&Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(950, 552);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(950, 600);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 37);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(950, 648);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdoClothing
            // 
            this.rdoClothing.AutoSize = true;
            this.rdoClothing.Location = new System.Drawing.Point(27, 44);
            this.rdoClothing.Name = "rdoClothing";
            this.rdoClothing.Size = new System.Drawing.Size(91, 24);
            this.rdoClothing.TabIndex = 0;
            this.rdoClothing.TabStop = true;
            this.rdoClothing.Text = "C&lothing";
            this.rdoClothing.UseVisualStyleBackColor = true;
            this.rdoClothing.CheckedChanged += new System.EventHandler(this.rdoClothing_CheckedChanged);
            // 
            // rdoEquipmentAccessories
            // 
            this.rdoEquipmentAccessories.AutoSize = true;
            this.rdoEquipmentAccessories.Location = new System.Drawing.Point(27, 96);
            this.rdoEquipmentAccessories.Name = "rdoEquipmentAccessories";
            this.rdoEquipmentAccessories.Size = new System.Drawing.Size(207, 24);
            this.rdoEquipmentAccessories.TabIndex = 1;
            this.rdoEquipmentAccessories.TabStop = true;
            this.rdoEquipmentAccessories.Text = "&Equipment/Accessories";
            this.rdoEquipmentAccessories.UseVisualStyleBackColor = true;
            // 
            // rdoJuiceBar
            // 
            this.rdoJuiceBar.AutoSize = true;
            this.rdoJuiceBar.Location = new System.Drawing.Point(27, 147);
            this.rdoJuiceBar.Name = "rdoJuiceBar";
            this.rdoJuiceBar.Size = new System.Drawing.Size(102, 24);
            this.rdoJuiceBar.TabIndex = 2;
            this.rdoJuiceBar.TabStop = true;
            this.rdoJuiceBar.Text = "&Juice Bar";
            this.rdoJuiceBar.UseVisualStyleBackColor = true;
            // 
            // rdoMembership
            // 
            this.rdoMembership.AutoSize = true;
            this.rdoMembership.Location = new System.Drawing.Point(27, 205);
            this.rdoMembership.Name = "rdoMembership";
            this.rdoMembership.Size = new System.Drawing.Size(122, 24);
            this.rdoMembership.TabIndex = 3;
            this.rdoMembership.TabStop = true;
            this.rdoMembership.Text = "&Membership";
            this.rdoMembership.UseVisualStyleBackColor = true;
            // 
            // rdoPersonalTraining
            // 
            this.rdoPersonalTraining.AutoSize = true;
            this.rdoPersonalTraining.Location = new System.Drawing.Point(27, 252);
            this.rdoPersonalTraining.Name = "rdoPersonalTraining";
            this.rdoPersonalTraining.Size = new System.Drawing.Size(161, 24);
            this.rdoPersonalTraining.TabIndex = 4;
            this.rdoPersonalTraining.TabStop = true;
            this.rdoPersonalTraining.Text = "Personal &Training";
            this.rdoPersonalTraining.UseVisualStyleBackColor = true;
            // 
            // chkImageVisible
            // 
            this.chkImageVisible.AutoSize = true;
            this.chkImageVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImageVisible.Location = new System.Drawing.Point(54, 664);
            this.chkImageVisible.Name = "chkImageVisible";
            this.chkImageVisible.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkImageVisible.Size = new System.Drawing.Size(131, 24);
            this.chkImageVisible.TabIndex = 3;
            this.chkImageVisible.Text = "Image &Visible";
            this.chkImageVisible.UseVisualStyleBackColor = true;
            this.chkImageVisible.CheckedChanged += new System.EventHandler(this.chkImageVisible_CheckedChanged);
            // 
            // picDepartment
            // 
            this.picDepartment.Location = new System.Drawing.Point(54, 518);
            this.picDepartment.Name = "picDepartment";
            this.picDepartment.Size = new System.Drawing.Size(385, 119);
            this.picDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDepartment.TabIndex = 12;
            this.picDepartment.TabStop = false;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // frmPromtions
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1100, 742);
            this.Controls.Add(this.picDepartment);
            this.Controls.Add(this.chkImageVisible);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPromotion);
            this.Controls.Add(this.rtxWelcome);
            this.Controls.Add(this.grpDepartment);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPromtions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotions";
            this.Load += new System.EventHandler(this.frmPromtions_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpDepartment.ResumeLayout(false);
            this.grpDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.MaskedTextBox mtxMemberId;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpDepartment;
        private System.Windows.Forms.RichTextBox rtxWelcome;
        private System.Windows.Forms.TextBox txtPromotion;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoPersonalTraining;
        private System.Windows.Forms.RadioButton rdoMembership;
        private System.Windows.Forms.RadioButton rdoJuiceBar;
        private System.Windows.Forms.RadioButton rdoEquipmentAccessories;
        private System.Windows.Forms.RadioButton rdoClothing;
        private System.Windows.Forms.CheckBox chkImageVisible;
        private System.Windows.Forms.PictureBox picDepartment;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

