namespace hello
{
    partial class textboxname
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
            this.button3 = new System.Windows.Forms.Button();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxName2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Goodbye";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(225, 215);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 20);
            this.txtBxName.TabIndex = 1;
            this.txtBxName.Text = "Henry";
            // 
            // txtBxName2
            // 
            this.txtBxName2.Location = new System.Drawing.Point(412, 215);
            this.txtBxName2.Name = "txtBxName2";
            this.txtBxName2.Size = new System.Drawing.Size(100, 20);
            this.txtBxName2.TabIndex = 2;
            // 
            // textboxname
            // 
            this.ClientSize = new System.Drawing.Size(707, 497);
            this.Controls.Add(this.txtBxName2);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.button3);
            this.Name = "textboxname";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxName2;
    }
}

