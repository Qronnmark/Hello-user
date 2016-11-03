namespace WindowsFormsApplication2
{
    partial class frmHello
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
            this.btnEntertheMatrix = new System.Windows.Forms.Button();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblnameResponse = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblAgeResponse = new System.Windows.Forms.Label();
            this.txtFeeling = new System.Windows.Forms.TextBox();
            this.lblFinalResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntertheMatrix
            // 
            this.btnEntertheMatrix.Location = new System.Drawing.Point(374, 12);
            this.btnEntertheMatrix.Name = "btnEntertheMatrix";
            this.btnEntertheMatrix.Size = new System.Drawing.Size(442, 154);
            this.btnEntertheMatrix.TabIndex = 1;
            this.btnEntertheMatrix.Text = "Please press here.";
            this.btnEntertheMatrix.UseVisualStyleBackColor = true;
            this.btnEntertheMatrix.Click += new System.EventHandler(this.btnEntertheMatrix_Click);
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(568, 180);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(0, 13);
            this.lblMatrix.TabIndex = 2;
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.Location = new System.Drawing.Point(338, 497);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(0, 13);
            this.lblYes.TabIndex = 5;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(713, 497);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(0, 13);
            this.lblNo.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(470, 210);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblnameResponse
            // 
            this.lblnameResponse.AutoSize = true;
            this.lblnameResponse.Location = new System.Drawing.Point(568, 244);
            this.lblnameResponse.Name = "lblnameResponse";
            this.lblnameResponse.Size = new System.Drawing.Size(0, 13);
            this.lblnameResponse.TabIndex = 8;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(487, 271);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(174, 20);
            this.txtage.TabIndex = 9;
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            // 
            // lblAgeResponse
            // 
            this.lblAgeResponse.AutoSize = true;
            this.lblAgeResponse.Location = new System.Drawing.Point(552, 308);
            this.lblAgeResponse.Name = "lblAgeResponse";
            this.lblAgeResponse.Size = new System.Drawing.Size(0, 13);
            this.lblAgeResponse.TabIndex = 10;
            // 
            // txtFeeling
            // 
            this.txtFeeling.Location = new System.Drawing.Point(487, 334);
            this.txtFeeling.Name = "txtFeeling";
            this.txtFeeling.Size = new System.Drawing.Size(158, 20);
            this.txtFeeling.TabIndex = 11;
            this.txtFeeling.TextChanged += new System.EventHandler(this.txtFeeling_TextChanged);
            // 
            // lblFinalResponse
            // 
            this.lblFinalResponse.AutoSize = true;
            this.lblFinalResponse.Location = new System.Drawing.Point(533, 367);
            this.lblFinalResponse.Name = "lblFinalResponse";
            this.lblFinalResponse.Size = new System.Drawing.Size(0, 13);
            this.lblFinalResponse.TabIndex = 12;
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 646);
            this.Controls.Add(this.lblFinalResponse);
            this.Controls.Add(this.txtFeeling);
            this.Controls.Add(this.lblAgeResponse);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblnameResponse);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblYes);
            this.Controls.Add(this.lblMatrix);
            this.Controls.Add(this.btnEntertheMatrix);
            this.Name = "frmHello";
            this.Text = "Hello.";
            this.Load += new System.EventHandler(this.frmHello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEntertheMatrix;
        private System.Windows.Forms.Label lblMatrix;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblnameResponse;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblAgeResponse;
        private System.Windows.Forms.TextBox txtFeeling;
        private System.Windows.Forms.Label lblFinalResponse;
    }
}

