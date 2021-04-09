
namespace FoodRecommender
{
    partial class HungerLevel
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
            this.txtHungerLevel = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHungerLevel
            // 
            this.txtHungerLevel.Location = new System.Drawing.Point(36, 52);
            this.txtHungerLevel.Name = "txtHungerLevel";
            this.txtHungerLevel.Size = new System.Drawing.Size(249, 20);
            this.txtHungerLevel.TabIndex = 0;
            this.txtHungerLevel.Text = "How hungry are you on a scale of 1-10?";
            this.txtHungerLevel.TextChanged += new System.EventHandler(this.txtHungerLevel_TextChanged);
            this.txtHungerLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHungerLevel_KeyDown);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(33, 89);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(0, 13);
            this.lblShow.TabIndex = 1;
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(291, 52);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(63, 20);
            this.btnNext1.TabIndex = 2;
            this.btnNext1.Text = "Enter";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnLess
            // 
            this.btnLess.Location = new System.Drawing.Point(260, 147);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(75, 23);
            this.btnLess.TabIndex = 3;
            this.btnLess.Text = "Less...";
            this.btnLess.UseVisualStyleBackColor = true;
            this.btnLess.Click += new System.EventHandler(this.btnLess_Click);
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(341, 147);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(75, 23);
            this.btnMore.TabIndex = 4;
            this.btnMore.Text = "More...";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            this.btnMore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnMore_KeyDown);
            // 
            // HungerLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 182);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnLess);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtHungerLevel);
            this.Name = "HungerLevel";
            this.Text = "Food Recommender.exe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHungerLevel;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnMore;
    }
}

