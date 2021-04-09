
namespace FoodRecommender
{
    partial class FoodTypeB
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
            this.lblRecommend = new System.Windows.Forms.Label();
            this.btnSavory = new System.Windows.Forms.Button();
            this.btnFilling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecommend
            // 
            this.lblRecommend.AutoSize = true;
            this.lblRecommend.Location = new System.Drawing.Point(40, 40);
            this.lblRecommend.Name = "lblRecommend";
            this.lblRecommend.Size = new System.Drawing.Size(253, 13);
            this.lblRecommend.TabIndex = 0;
            this.lblRecommend.Text = "Do you want to enjoy your food or just stuff yourself?";
            this.lblRecommend.Click += new System.EventHandler(this.lblRecommend_Click);
            // 
            // btnSavory
            // 
            this.btnSavory.Location = new System.Drawing.Point(68, 82);
            this.btnSavory.Name = "btnSavory";
            this.btnSavory.Size = new System.Drawing.Size(75, 23);
            this.btnSavory.TabIndex = 1;
            this.btnSavory.Text = "Savory";
            this.btnSavory.UseVisualStyleBackColor = true;
            this.btnSavory.Click += new System.EventHandler(this.btnSavory_Click);
            // 
            // btnFilling
            // 
            this.btnFilling.Location = new System.Drawing.Point(176, 82);
            this.btnFilling.Name = "btnFilling";
            this.btnFilling.Size = new System.Drawing.Size(75, 23);
            this.btnFilling.TabIndex = 2;
            this.btnFilling.Text = "Filling";
            this.btnFilling.UseVisualStyleBackColor = true;
            this.btnFilling.Click += new System.EventHandler(this.btnFilling_Click);
            // 
            // FoodTypeB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 146);
            this.Controls.Add(this.btnFilling);
            this.Controls.Add(this.btnSavory);
            this.Controls.Add(this.lblRecommend);
            this.Name = "FoodTypeB";
            this.Text = "Very hungry recommendations";
            this.Load += new System.EventHandler(this.FoodTypeB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecommend;
        private System.Windows.Forms.Button btnSavory;
        private System.Windows.Forms.Button btnFilling;
    }
}