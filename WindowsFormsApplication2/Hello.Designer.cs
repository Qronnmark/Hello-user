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
            this.SuspendLayout();
            // 
            // btnEntertheMatrix
            // 
            this.btnEntertheMatrix.Location = new System.Drawing.Point(401, 192);
            this.btnEntertheMatrix.Name = "btnEntertheMatrix";
            this.btnEntertheMatrix.Size = new System.Drawing.Size(442, 154);
            this.btnEntertheMatrix.TabIndex = 1;
            this.btnEntertheMatrix.Text = "Press here.";
            this.btnEntertheMatrix.UseVisualStyleBackColor = true;
            this.btnEntertheMatrix.Click += new System.EventHandler(this.btnEntertheMatrix_Click);
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(604, 427);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(0, 13);
            this.lblMatrix.TabIndex = 2;
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 646);
            this.Controls.Add(this.lblMatrix);
            this.Controls.Add(this.btnEntertheMatrix);
            this.Name = "frmHello";
            this.Text = "Hello.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEntertheMatrix;
        private System.Windows.Forms.Label lblMatrix;
    }
}

