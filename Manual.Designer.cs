namespace Magical_PingTools
{
    partial class Manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual));
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAddress.Location = new System.Drawing.Point(79, 15);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(37, 19);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "IP：";
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMask.Location = new System.Drawing.Point(55, 48);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(61, 19);
            this.lblMask.TabIndex = 1;
            this.lblMask.Text = "Mask：";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGateway.Location = new System.Drawing.Point(32, 81);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(84, 19);
            this.lblGateway.TabIndex = 2;
            this.lblGateway.Text = "Gateway：";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(122, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 27);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.KeyPress += MainProgram.TextOnlyNum;
            // 
            // txtMask
            // 
            this.txtMask.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMask.Location = new System.Drawing.Point(122, 45);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(150, 27);
            this.txtMask.TabIndex = 4;
            this.txtMask.KeyPress += MainProgram.TextOnlyNum;
            // 
            // txtGateway
            // 
            this.txtGateway.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGateway.Location = new System.Drawing.Point(122, 78);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(150, 27);
            this.txtGateway.TabIndex = 5;
            this.txtGateway.KeyPress += MainProgram.TextOnlyNum;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSend.Location = new System.Drawing.Point(126, 119);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 30);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(202, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblGateway);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.lblAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual IP Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtGateway;
        public System.Windows.Forms.TextBox txtMask;
        public System.Windows.Forms.TextBox txtAddress;
    }
}