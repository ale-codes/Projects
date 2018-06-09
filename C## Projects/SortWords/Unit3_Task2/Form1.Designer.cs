namespace Unit3_Task2
{
    partial class SortWords
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.ResultsLbl = new System.Windows.Forms.Label();
            this.MsgLbl = new System.Windows.Forms.Label();
            this.SortedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(12, 32);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(0, 18);
            this.TitleLbl.TabIndex = 0;
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(98, 104);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 24);
            this.TextBox.TabIndex = 1;
            this.TextBox.UseWaitCursor = true;
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SortButton.FlatAppearance.BorderSize = 0;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.Location = new System.Drawing.Point(332, 92);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(100, 49);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Add word";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // ResultsLbl
            // 
            this.ResultsLbl.AutoSize = true;
            this.ResultsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsLbl.Location = new System.Drawing.Point(12, 199);
            this.ResultsLbl.Name = "ResultsLbl";
            this.ResultsLbl.Size = new System.Drawing.Size(0, 18);
            this.ResultsLbl.TabIndex = 3;
            // 
            // MsgLbl
            // 
            this.MsgLbl.AutoSize = true;
            this.MsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLbl.Location = new System.Drawing.Point(12, 160);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(0, 18);
            this.MsgLbl.TabIndex = 4;
            // 
            // SortedLbl
            // 
            this.SortedLbl.AutoSize = true;
            this.SortedLbl.Location = new System.Drawing.Point(13, 295);
            this.SortedLbl.Name = "SortedLbl";
            this.SortedLbl.Size = new System.Drawing.Size(0, 13);
            this.SortedLbl.TabIndex = 5;
            // 
            // SortWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 248);
            this.Controls.Add(this.SortedLbl);
            this.Controls.Add(this.MsgLbl);
            this.Controls.Add(this.ResultsLbl);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SortWords";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SortWords";
            this.Load += new System.EventHandler(this.SortWords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label ResultsLbl;
        private System.Windows.Forms.Label MsgLbl;
        private System.Windows.Forms.Label SortedLbl;
    }
}

