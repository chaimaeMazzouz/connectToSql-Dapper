namespace SqlDataAccessDemo
{
    partial class Dashboard
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
            this.peopleFoundLBox = new System.Windows.Forms.ListBox();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peopleFoundLBox
            // 
            this.peopleFoundLBox.FormattingEnabled = true;
            this.peopleFoundLBox.Location = new System.Drawing.Point(42, 130);
            this.peopleFoundLBox.Name = "peopleFoundLBox";
            this.peopleFoundLBox.Size = new System.Drawing.Size(222, 56);
            this.peopleFoundLBox.TabIndex = 0;
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(84, 51);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(180, 20);
            this.Idtxt.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(116, 92);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(39, 51);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(33, 16);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "Id : ";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 198);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.peopleFoundLBox);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundLBox;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label IdLabel;
    }
}

