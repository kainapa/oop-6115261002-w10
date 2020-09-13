namespace oop_6115261002_w10
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPortfolio = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(614, 525);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "ตกลง";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 26);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(37, 17);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "ลำดับ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(23, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "ชื่อ";
            // 
            // lblPortfolio
            // 
            this.lblPortfolio.AutoSize = true;
            this.lblPortfolio.Location = new System.Drawing.Point(12, 136);
            this.lblPortfolio.Name = "lblPortfolio";
            this.lblPortfolio.Size = new System.Drawing.Size(44, 17);
            this.lblPortfolio.TabIndex = 3;
            this.lblPortfolio.Text = "ผลงาน";
            this.lblPortfolio.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(12, 190);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(32, 17);
            this.lblPage.TabIndex = 4;
            this.lblPage.Text = "หน้า";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Location = new System.Drawing.Point(12, 247);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(89, 17);
            this.lblDocument.TabIndex = 5;
            this.lblDocument.Text = "เอกสารที่ตีพิมพ์";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 302);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(32, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "วันที่";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(12, 356);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(79, 17);
            this.lblQuality.TabIndex = 7;
            this.lblQuality.Text = "ระดับคุณภาพ";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 406);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(63, 17);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "ค่าน้ำหนัก";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(12, 464);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(52, 17);
            this.lblDisplay.TabIndex = 9;
            this.lblDisplay.Text = "แสดงผล";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(135, 23);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 11;
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(135, 131);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(100, 22);
            this.txtWork.TabIndex = 12;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(135, 187);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 22);
            this.txtPage.TabIndex = 13;
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(135, 244);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(100, 22);
            this.txtDocument.TabIndex = 14;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(135, 302);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 15;
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(135, 351);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(100, 22);
            this.txtQuality.TabIndex = 16;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(135, 401);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 560);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblPortfolio);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPortfolio;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.TextBox txtWeight;
    }
}

