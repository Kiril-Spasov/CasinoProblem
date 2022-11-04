namespace CasinoProblem
{
    partial class FormCasinoProblem
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.LstResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 60);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(245, 73);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start Simulation";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LstResult
            // 
            this.LstResult.FormattingEnabled = true;
            this.LstResult.HorizontalScrollbar = true;
            this.LstResult.ItemHeight = 16;
            this.LstResult.Location = new System.Drawing.Point(263, 59);
            this.LstResult.Name = "LstResult";
            this.LstResult.Size = new System.Drawing.Size(499, 324);
            this.LstResult.TabIndex = 1;
            // 
            // FormCasinoProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstResult);
            this.Controls.Add(this.BtnStart);
            this.Name = "FormCasinoProblem";
            this.Text = "Casino";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ListBox LstResult;
    }
}

