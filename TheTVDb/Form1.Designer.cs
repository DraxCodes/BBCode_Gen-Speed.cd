namespace TheTVDb
{
    partial class InfoGrabber
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
            this.txtb_Search = new System.Windows.Forms.TextBox();
            this.bbcode = new System.Windows.Forms.RichTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.movie_Id = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbl_Movie_Name = new System.Windows.Forms.Label();
            this.releaseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGrabber = new System.Windows.Forms.Button();
            this.img1 = new System.Windows.Forms.TextBox();
            this.img2 = new System.Windows.Forms.TextBox();
            this.img4 = new System.Windows.Forms.TextBox();
            this.img3 = new System.Windows.Forms.TextBox();
            this.img6 = new System.Windows.Forms.TextBox();
            this.img5 = new System.Windows.Forms.TextBox();
            this.img8 = new System.Windows.Forms.TextBox();
            this.img7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb_Search
            // 
            this.txtb_Search.Location = new System.Drawing.Point(65, 58);
            this.txtb_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb_Search.Name = "txtb_Search";
            this.txtb_Search.Size = new System.Drawing.Size(367, 22);
            this.txtb_Search.TabIndex = 1;
            // 
            // bbcode
            // 
            this.bbcode.Location = new System.Drawing.Point(600, 84);
            this.bbcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bbcode.Name = "bbcode";
            this.bbcode.Size = new System.Drawing.Size(550, 367);
            this.bbcode.TabIndex = 2;
            this.bbcode.Text = "";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(9, 62);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search:";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(305, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Warzone\'s Movie Info Grabber";
            // 
            // movie_Id
            // 
            this.movie_Id.FormattingEnabled = true;
            this.movie_Id.Location = new System.Drawing.Point(65, 89);
            this.movie_Id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movie_Id.Name = "movie_Id";
            this.movie_Id.Size = new System.Drawing.Size(509, 24);
            this.movie_Id.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(438, 57);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 25);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbl_Movie_Name
            // 
            this.lbl_Movie_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Movie_Name.AutoSize = true;
            this.lbl_Movie_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Movie_Name.Location = new System.Drawing.Point(16, 94);
            this.lbl_Movie_Name.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Movie_Name.Name = "lbl_Movie_Name";
            this.lbl_Movie_Name.Size = new System.Drawing.Size(45, 13);
            this.lbl_Movie_Name.TabIndex = 7;
            this.lbl_Movie_Name.Text = "Movie:";
            // 
            // releaseName
            // 
            this.releaseName.Location = new System.Drawing.Point(111, 128);
            this.releaseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.releaseName.Name = "releaseName";
            this.releaseName.Size = new System.Drawing.Size(463, 22);
            this.releaseName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Release Name:";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(19, 185);
            this.info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(570, 266);
            this.info.TabIndex = 10;
            this.info.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "BBCode: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1553, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Please Enter All Release Info Below:";
            // 
            // btnGrabber
            // 
            this.btnGrabber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabber.Location = new System.Drawing.Point(706, 56);
            this.btnGrabber.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabber.Name = "btnGrabber";
            this.btnGrabber.Size = new System.Drawing.Size(444, 26);
            this.btnGrabber.TabIndex = 0;
            this.btnGrabber.Text = "Grab Info";
            this.btnGrabber.UseVisualStyleBackColor = true;
            this.btnGrabber.Click += new System.EventHandler(this.button1_Click);
            // 
            // img1
            // 
            this.img1.Location = new System.Drawing.Point(1158, 84);
            this.img1.Margin = new System.Windows.Forms.Padding(4);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(385, 22);
            this.img1.TabIndex = 14;
            // 
            // img2
            // 
            this.img2.Location = new System.Drawing.Point(1158, 114);
            this.img2.Margin = new System.Windows.Forms.Padding(4);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(385, 22);
            this.img2.TabIndex = 15;
            // 
            // img4
            // 
            this.img4.Location = new System.Drawing.Point(1158, 174);
            this.img4.Margin = new System.Windows.Forms.Padding(4);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(385, 22);
            this.img4.TabIndex = 17;
            // 
            // img3
            // 
            this.img3.Location = new System.Drawing.Point(1158, 144);
            this.img3.Margin = new System.Windows.Forms.Padding(4);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(385, 22);
            this.img3.TabIndex = 16;
            // 
            // img6
            // 
            this.img6.Location = new System.Drawing.Point(1158, 234);
            this.img6.Margin = new System.Windows.Forms.Padding(4);
            this.img6.Name = "img6";
            this.img6.Size = new System.Drawing.Size(385, 22);
            this.img6.TabIndex = 19;
            // 
            // img5
            // 
            this.img5.Location = new System.Drawing.Point(1158, 204);
            this.img5.Margin = new System.Windows.Forms.Padding(4);
            this.img5.Name = "img5";
            this.img5.Size = new System.Drawing.Size(385, 22);
            this.img5.TabIndex = 18;
            // 
            // img8
            // 
            this.img8.Location = new System.Drawing.Point(1158, 294);
            this.img8.Margin = new System.Windows.Forms.Padding(4);
            this.img8.Name = "img8";
            this.img8.Size = new System.Drawing.Size(385, 22);
            this.img8.TabIndex = 21;
            // 
            // img7
            // 
            this.img7.Location = new System.Drawing.Point(1158, 264);
            this.img7.Margin = new System.Windows.Forms.Padding(4);
            this.img7.Name = "img7";
            this.img7.Size = new System.Drawing.Size(385, 22);
            this.img7.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1154, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sample Images: ";
            // 
            // InfoGrabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 471);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.img8);
            this.Controls.Add(this.img7);
            this.Controls.Add(this.img6);
            this.Controls.Add(this.img5);
            this.Controls.Add(this.img4);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.releaseName);
            this.Controls.Add(this.lbl_Movie_Name);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.movie_Id);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.bbcode);
            this.Controls.Add(this.txtb_Search);
            this.Controls.Add(this.btnGrabber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InfoGrabber";
            this.Text = "Warzone\'s Movie Info Graber v2.3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_Search;
        private System.Windows.Forms.RichTextBox bbcode;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox movie_Id;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbl_Movie_Name;
        private System.Windows.Forms.TextBox releaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGrabber;
        private System.Windows.Forms.TextBox img1;
        private System.Windows.Forms.TextBox img2;
        private System.Windows.Forms.TextBox img4;
        private System.Windows.Forms.TextBox img3;
        private System.Windows.Forms.TextBox img6;
        private System.Windows.Forms.TextBox img5;
        private System.Windows.Forms.TextBox img8;
        private System.Windows.Forms.TextBox img7;
        private System.Windows.Forms.Label label4;
    }
}

