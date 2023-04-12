
namespace game1
{
    partial class Fruit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fruit));
            this.picWord = new System.Windows.Forms.PictureBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.btn_Answer = new System.Windows.Forms.Label();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.btn_Submit = new game1.NewFolder1.RJButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWord)).BeginInit();
            this.SuspendLayout();
            // 
            // picWord
            // 
            this.picWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWord.Location = new System.Drawing.Point(88, 49);
            this.picWord.Name = "picWord";
            this.picWord.Size = new System.Drawing.Size(375, 202);
            this.picWord.TabIndex = 1;
            this.picWord.TabStop = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(581, 49);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(137, 92);
            this.lbl_Score.TabIndex = 2;
            this.lbl_Score.Text = "00";
            // 
            // lbl_Time
            // 
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(586, 168);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(137, 49);
            this.lbl_Time.TabIndex = 3;
            // 
            // btn_Answer
            // 
            this.btn_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Answer.Location = new System.Drawing.Point(574, 274);
            this.btn_Answer.Name = "btn_Answer";
            this.btn_Answer.Size = new System.Drawing.Size(135, 50);
            this.btn_Answer.TabIndex = 4;
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.Location = new System.Drawing.Point(573, 391);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(145, 46);
            this.lbl_Answer.TabIndex = 5;
            // 
            // txt_Answer
            // 
            this.txt_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Answer.Location = new System.Drawing.Point(88, 287);
            this.txt_Answer.Multiline = true;
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(196, 51);
            this.txt_Answer.TabIndex = 6;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Submit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Submit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Submit.BorderRadius = 20;
            this.btn_Submit.BorderSize = 0;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(88, 391);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(150, 40);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Check";
            this.btn_Submit.TextColor = System.Drawing.Color.White;
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Fruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 519);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.btn_Answer);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.picWord);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fruit";
            this.Load += new System.EventHandler(this.Fruit_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWord;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label btn_Answer;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.TextBox txt_Answer;
        private NewFolder1.RJButton btn_Submit;
        private System.Windows.Forms.Timer timer1;
    }
}