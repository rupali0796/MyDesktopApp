namespace WindowsFormsApp2
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 240);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(787, 210);
            this.dgv.TabIndex = 0;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseClick);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(160, 197);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Country";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(114, 52);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(114, 98);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(114, 149);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 9;
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(394, 65);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(100, 20);
            this.txtPinCode.TabIndex = 13;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(394, 14);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(100, 20);
            this.txtFatherName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PinCode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "FatherName";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(258, 197);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(354, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

