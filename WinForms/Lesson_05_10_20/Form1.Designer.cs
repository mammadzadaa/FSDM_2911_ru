namespace Lesson_05_10_20
{
    partial class MyForm
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
            this.myButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(354, 191);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(93, 34);
            this.myButton.TabIndex = 0;
            this.myButton.Text = "Click Me";
            this.myButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.myButton.UseVisualStyleBackColor = true;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.myButton);
            this.Name = "MyForm";
            this.Text = "My First WinForm App";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myButton;
    }
}

