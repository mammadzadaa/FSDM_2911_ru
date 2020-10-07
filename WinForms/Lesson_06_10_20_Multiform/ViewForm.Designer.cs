namespace Lesson_06_10_20_Multiform
{
    partial class ViewForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.favoriteLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.personPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(153, 55);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.surnameLabel.Location = new System.Drawing.Point(219, 13);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(220, 55);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Surname";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(23, 121);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.ReadOnly = true;
            this.numberTextBox.Size = new System.Drawing.Size(207, 26);
            this.numberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(23, 204);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(207, 26);
            this.emailTextBox.TabIndex = 4;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(23, 279);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(63, 20);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "Gender";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(23, 323);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(100, 20);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = "Aditional info";
            // 
            // favoriteLabel
            // 
            this.favoriteLabel.AutoSize = true;
            this.favoriteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.favoriteLabel.Location = new System.Drawing.Point(514, 14);
            this.favoriteLabel.Name = "favoriteLabel";
            this.favoriteLabel.Size = new System.Drawing.Size(73, 69);
            this.favoriteLabel.TabIndex = 8;
            this.favoriteLabel.Text = "⭐";
            this.favoriteLabel.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(221, 451);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(190, 66);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // personPictureBox
            // 
            this.personPictureBox.Location = new System.Drawing.Point(317, 96);
            this.personPictureBox.Name = "personPictureBox";
            this.personPictureBox.Size = new System.Drawing.Size(270, 296);
            this.personPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personPictureBox.TabIndex = 10;
            this.personPictureBox.TabStop = false;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 547);
            this.Controls.Add(this.personPictureBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.favoriteLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label favoriteLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox personPictureBox;
    }
}