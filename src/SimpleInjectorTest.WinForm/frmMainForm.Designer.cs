
namespace SimpleInjectorTest.WinForm
{
    partial class frmMainForm
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
            this.btnValidator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValidator
            // 
            this.btnValidator.Location = new System.Drawing.Point(93, 118);
            this.btnValidator.Name = "btnValidator";
            this.btnValidator.Size = new System.Drawing.Size(182, 64);
            this.btnValidator.TabIndex = 0;
            this.btnValidator.Text = "RegexValidator";
            this.btnValidator.UseVisualStyleBackColor = true;
            this.btnValidator.Click += new System.EventHandler(this.btnValidator_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 296);
            this.Controls.Add(this.btnValidator);
            this.Name = "frmMainForm";
            this.Text = "frmMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValidator;
    }
}