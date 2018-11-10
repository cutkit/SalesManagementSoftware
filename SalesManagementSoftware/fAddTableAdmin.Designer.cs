namespace SalesManagementSoftware
{
    partial class fAddTableAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddTable);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(36, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 180);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(190, 109);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(106, 35);
            this.btnAddTable.TabIndex = 2;
            this.btnAddTable.Text = "Thêm Bàn";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbStatus);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(25, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 34);
            this.panel3.TabIndex = 1;
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(165, 5);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(206, 25);
            this.txbStatus.TabIndex = 1;
            this.txbStatus.Text = "Trống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng Thái";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTableName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 37);
            this.panel2.TabIndex = 0;
            // 
            // txbTableName
            // 
            this.txbTableName.Location = new System.Drawing.Point(165, 5);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(206, 25);
            this.txbTableName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Bàn";
            // 
            // fAddTableAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 242);
            this.Controls.Add(this.panel1);
            this.Name = "fAddTableAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Bàn";
            this.Load += new System.EventHandler(this.fAddTableAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.Label label1;
    }
}