namespace BookListView
{
    partial class frmBookListView
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookListView));
            this.grpView = new System.Windows.Forms.GroupBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.grpBorrow = new System.Windows.Forms.GroupBox();
            this.lstBorrow = new System.Windows.Forms.ListBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.imgS = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtKind = new System.Windows.Forms.TextBox();
            this.lblKind = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.grpView.SuspendLayout();
            this.grpBorrow.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpList.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpView
            // 
            this.grpView.BackColor = System.Drawing.Color.Honeydew;
            this.grpView.Controls.Add(this.cmbView);
            this.grpView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpView.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grpView.Location = new System.Drawing.Point(0, 0);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(285, 58);
            this.grpView.TabIndex = 0;
            this.grpView.TabStop = false;
            this.grpView.Text = "檢視方式：";
            // 
            // cmbView
            // 
            this.cmbView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(8, 23);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(266, 25);
            this.cmbView.TabIndex = 1;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // grpBorrow
            // 
            this.grpBorrow.BackColor = System.Drawing.Color.Honeydew;
            this.grpBorrow.Controls.Add(this.lstBorrow);
            this.grpBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBorrow.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBorrow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grpBorrow.Location = new System.Drawing.Point(0, 58);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Padding = new System.Windows.Forms.Padding(11);
            this.grpBorrow.Size = new System.Drawing.Size(285, 334);
            this.grpBorrow.TabIndex = 0;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "借書清單：";
            // 
            // lstBorrow
            // 
            this.lstBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.HorizontalExtent = 400;
            this.lstBorrow.HorizontalScrollbar = true;
            this.lstBorrow.ItemHeight = 17;
            this.lstBorrow.Location = new System.Drawing.Point(11, 29);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new System.Drawing.Size(263, 294);
            this.lstBorrow.TabIndex = 2;
            this.lstBorrow.DoubleClick += new System.EventHandler(this.lstBorrow_DoubleClick);
            this.lstBorrow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstBorrow_KeyDown);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.Honeydew;
            this.pnlTools.Controls.Add(this.grpBorrow);
            this.pnlTools.Controls.Add(this.grpView);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pnlTools.Location = new System.Drawing.Point(481, 8);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(285, 392);
            this.pnlTools.TabIndex = 2;
            // 
            // lvwBooks
            // 
            this.lvwBooks.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvwBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooks.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.LargeImageList = this.imgL;
            this.lvwBooks.Location = new System.Drawing.Point(11, 58);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(451, 323);
            this.lvwBooks.SmallImageList = this.imgS;
            this.lvwBooks.TabIndex = 0;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.ItemActivate += new System.EventHandler(this.lvwBooks_ItemActivate);
            // 
            // imgL
            // 
            this.imgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL.ImageStream")));
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL.Images.SetKeyName(0, "Book1.jpg");
            this.imgL.Images.SetKeyName(1, "Book2.jpg");
            this.imgL.Images.SetKeyName(2, "Book3.jpg");
            this.imgL.Images.SetKeyName(3, "Book4.jpg");
            this.imgL.Images.SetKeyName(4, "Book5.jpg");
            this.imgL.Images.SetKeyName(5, "Book6.jpg");
            this.imgL.Images.SetKeyName(6, "Book7.jpg");
            this.imgL.Images.SetKeyName(7, "Book8.jpg");
            this.imgL.Images.SetKeyName(8, "Book9.jpg");
            this.imgL.Images.SetKeyName(9, "Book10.jpg");
            this.imgL.Images.SetKeyName(10, "Book11.jpg");
            this.imgL.Images.SetKeyName(11, "Book12.jpg");
            this.imgL.Images.SetKeyName(12, "Book13.jpg");
            // 
            // imgS
            // 
            this.imgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgS.ImageStream")));
            this.imgS.TransparentColor = System.Drawing.Color.Transparent;
            this.imgS.Images.SetKeyName(0, "Book1.jpg");
            this.imgS.Images.SetKeyName(1, "Book2.jpg");
            this.imgS.Images.SetKeyName(2, "Book3.jpg");
            this.imgS.Images.SetKeyName(3, "Book4.jpg");
            this.imgS.Images.SetKeyName(4, "Book5.jpg");
            this.imgS.Images.SetKeyName(5, "Book6.jpg");
            this.imgS.Images.SetKeyName(6, "Book7.jpg");
            this.imgS.Images.SetKeyName(7, "Book8.jpg");
            this.imgS.Images.SetKeyName(8, "Book9.jpg");
            this.imgS.Images.SetKeyName(9, "Book10.jpg");
            this.imgS.Images.SetKeyName(10, "Book11.jpg");
            this.imgS.Images.SetKeyName(11, "Book12.jpg");
            this.imgS.Images.SetKeyName(12, "Book13.jpg");
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Honeydew;
            this.pnlMain.Controls.Add(this.grpList);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(8, 8);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(473, 392);
            this.pnlMain.TabIndex = 4;
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.lvwBooks);
            this.grpList.Controls.Add(this.pnlSearch);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpList.Location = new System.Drawing.Point(0, 0);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(11, 0, 11, 11);
            this.grpList.Size = new System.Drawing.Size(473, 392);
            this.grpList.TabIndex = 4;
            this.grpList.TabStop = false;
            this.grpList.Text = "書籍瀏覽";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(11, 18);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(451, 40);
            this.pnlSearch.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(226, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 25);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(29, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(202, 17);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "輸入欲查詢書籍書名/作者/類別：";
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Honeydew;
            this.pnlAdd.Controls.Add(this.grpAdd);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdd.Location = new System.Drawing.Point(8, 400);
            this.pnlAdd.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(758, 68);
            this.pnlAdd.TabIndex = 5;
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnPic);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtKind);
            this.grpAdd.Controls.Add(this.lblKind);
            this.grpAdd.Controls.Add(this.txtAuthor);
            this.grpAdd.Controls.Add(this.lblAuthor);
            this.grpAdd.Controls.Add(this.txtBookName);
            this.grpAdd.Controls.Add(this.lblBookName);
            this.grpAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAdd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpAdd.Location = new System.Drawing.Point(0, 0);
            this.grpAdd.Margin = new System.Windows.Forms.Padding(4);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Padding = new System.Windows.Forms.Padding(4);
            this.grpAdd.Size = new System.Drawing.Size(758, 68);
            this.grpAdd.TabIndex = 0;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "【管理員功能】新書上架";
            // 
            // btnPic
            // 
            this.btnPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPic.Location = new System.Drawing.Point(562, 25);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(88, 31);
            this.btnPic.TabIndex = 7;
            this.btnPic.Text = "選擇書封";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(661, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "上架";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtKind
            // 
            this.txtKind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKind.Location = new System.Drawing.Point(422, 28);
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(130, 25);
            this.txtKind.TabIndex = 6;
            // 
            // lblKind
            // 
            this.lblKind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(379, 32);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(47, 17);
            this.lblKind.TabIndex = 4;
            this.lblKind.Text = "類別：";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAuthor.Location = new System.Drawing.Point(242, 29);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(130, 25);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(199, 33);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 17);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "作者：";
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBookName.Location = new System.Drawing.Point(62, 28);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(130, 25);
            this.txtBookName.TabIndex = 4;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(19, 32);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(47, 17);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "書名：";
            // 
            // frmBookListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(774, 476);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.pnlAdd);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinimumSize = new System.Drawing.Size(760, 300);
            this.Name = "frmBookListView";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖書管理程式";
            this.Load += new System.EventHandler(this.frmBookListView_Load);
            this.grpView.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.GroupBox grpBorrow;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.ListBox lstBorrow;
        private System.Windows.Forms.ListView lvwBooks;
        private System.Windows.Forms.ImageList imgL;
        private System.Windows.Forms.ImageList imgS;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtKind;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnPic;
    }
}

