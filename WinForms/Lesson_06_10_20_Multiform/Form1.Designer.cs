namespace Lesson_06_10_20_Multiform
{
    partial class MainForm
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
            this.viewButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.personListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewButton.Location = new System.Drawing.Point(50, 502);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(217, 90);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(378, 502);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(217, 90);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseMnemonic = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // personListBox
            // 
            this.personListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personListBox.FormattingEnabled = true;
            this.personListBox.ItemHeight = 32;
            this.personListBox.Location = new System.Drawing.Point(29, 34);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(578, 420);
            this.personListBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 637);
            this.Controls.Add(this.personListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.viewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Info App";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox personListBox;
    }
}

