namespace HelloWorld.WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbShowHello = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbShowHello
            // 
            this.tbShowHello.Location = new System.Drawing.Point(12, 12);
            this.tbShowHello.Name = "tbShowHello";
            this.tbShowHello.Size = new System.Drawing.Size(776, 23);
            this.tbShowHello.TabIndex = 0;
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(12, 42);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(776, 23);
            this.btnSayHello.TabIndex = 1;
            this.btnSayHello.Text = "Click";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.tbShowHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbShowHello;
        private System.Windows.Forms.Button btnSayHello;
    }
}

