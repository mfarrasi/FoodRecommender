
namespace FoodRecommender
{
    partial class FoodTypeA
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
            this.btnSweet = new System.Windows.Forms.Button();
            this.btnSavory = new System.Windows.Forms.Button();
            this.lblRecommend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSweet
            // 
            this.btnSweet.Location = new System.Drawing.Point(84, 84);
            this.btnSweet.Name = "btnSweet";
            this.btnSweet.Size = new System.Drawing.Size(75, 23);
            this.btnSweet.TabIndex = 0;
            this.btnSweet.Text = "Sweet";
            this.btnSweet.UseVisualStyleBackColor = true;
            this.btnSweet.Click += new System.EventHandler(this.btnSweet_Click);
            // 
            // btnSavory
            // 
            this.btnSavory.Location = new System.Drawing.Point(222, 84);
            this.btnSavory.Name = "btnSavory";
            this.btnSavory.Size = new System.Drawing.Size(75, 23);
            this.btnSavory.TabIndex = 1;
            this.btnSavory.Text = "Savory";
            this.btnSavory.UseVisualStyleBackColor = true;
            this.btnSavory.Click += new System.EventHandler(this.btnSavory_Click);
            // 
            // lblRecommend
            // 
            this.lblRecommend.AutoSize = true;
            this.lblRecommend.Location = new System.Drawing.Point(120, 46);
            this.lblRecommend.Name = "lblRecommend";
            this.lblRecommend.Size = new System.Drawing.Size(148, 13);
            this.lblRecommend.TabIndex = 2;
            this.lblRecommend.Text = "What do you feel like having?";
            this.lblRecommend.Click += new System.EventHandler(this.label1_Click);
            // 
            // FoodTypeA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 152);
            this.Controls.Add(this.lblRecommend);
            this.Controls.Add(this.btnSavory);
            this.Controls.Add(this.btnSweet);
            this.Name = "FoodTypeA";
            this.Text = "Not so hungry recommendations";
            this.Load += new System.EventHandler(this.FoodTypeA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSweet;
        private System.Windows.Forms.Button btnSavory;
        private System.Windows.Forms.Label lblRecommend;
    }
}