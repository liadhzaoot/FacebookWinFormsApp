
namespace BasicFacebookFeatures
{
    partial class PostUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.likeBtn = new System.Windows.Forms.Button();
            this.commentBtn = new System.Windows.Forms.Button();
            this.commantTB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.postPB = new System.Windows.Forms.PictureBox();
            this.postLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postPB)).BeginInit();
            this.SuspendLayout();
            // 
            // likeBtn
            // 
            this.likeBtn.Location = new System.Drawing.Point(202, 187);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(75, 23);
            this.likeBtn.TabIndex = 0;
            this.likeBtn.Text = "Like";
            this.likeBtn.UseVisualStyleBackColor = true;
            // 
            // commentBtn
            // 
            this.commentBtn.Location = new System.Drawing.Point(369, 228);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.Size = new System.Drawing.Size(75, 23);
            this.commentBtn.TabIndex = 1;
            this.commentBtn.Text = "Comment";
            this.commentBtn.UseVisualStyleBackColor = true;
            // 
            // commantTB
            // 
            this.commantTB.Location = new System.Drawing.Point(39, 230);
            this.commantTB.Name = "commantTB";
            this.commantTB.Size = new System.Drawing.Size(324, 20);
            this.commantTB.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // postPB
            // 
            this.postPB.Location = new System.Drawing.Point(125, 25);
            this.postPB.Name = "postPB";
            this.postPB.Size = new System.Drawing.Size(238, 112);
            this.postPB.TabIndex = 4;
            this.postPB.TabStop = false;
            // 
            // postLable
            // 
            this.postLable.AutoSize = true;
            this.postLable.Location = new System.Drawing.Point(222, 154);
            this.postLable.Name = "postLable";
            this.postLable.Size = new System.Drawing.Size(35, 13);
            this.postLable.TabIndex = 5;
            this.postLable.Text = "label1";
            this.postLable.Click += new System.EventHandler(this.postLable_Click);
            // 
            // PostUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.postLable);
            this.Controls.Add(this.postPB);
            this.Controls.Add(this.commantTB);
            this.Controls.Add(this.commentBtn);
            this.Controls.Add(this.likeBtn);
            this.Name = "PostUC";
            this.Size = new System.Drawing.Size(481, 309);
            this.Load += new System.EventHandler(this.PostUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button likeBtn;
        private System.Windows.Forms.Button commentBtn;
        private System.Windows.Forms.TextBox commantTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox postPB;
        private System.Windows.Forms.Label postLable;
    }
}
