using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookListView
{
    public partial class frmBookListView : Form
    {
        /*string[] b_name = { "三國演義", "西遊記", "唐詩三百首", "楚辭", "西廂記", "水滸傳", "紅樓夢", "牡丹亭", "解憂雜貨店", "奶奶的紅鉛筆", "小王子", "不便利的便利店", "失物之國" }; //書名
        string[] author = { "羅貫中", "吳承恩", "孫洙", "劉向", "王實甫", "施耐庵", "曹雪芹", "湯顯祖", "東野圭吾", "盧多維克‧勒孔特", "安東尼‧聖修伯里", "金浩然", " 約翰．康納利" }; //作者
        string[] kind = { "章回小說", "章回小說", "詩選", "詩歌", "戲曲", "章回小說", "章回小說", "戲曲", "小說", "繪本", "小說", "小說", "小說" }; //類別*/
        List<Book> bookList = new List<Book>();
        string selectedImagePath = "";

        public frmBookListView()
        {
            InitializeComponent();
            bookList.Add(new Book("三國演義", "羅貫中", "章回小說"));
            bookList.Add(new Book("西遊記", "吳承恩", "章回小說"));
            bookList.Add(new Book("唐詩三百首", "孫洙", "詩選"));
            bookList.Add(new Book("楚辭", "劉向", "詩歌"));
            bookList.Add(new Book("西廂記", "王實甫", "戲曲"));
            bookList.Add(new Book("水滸傳", "施耐庵", "章回小說"));
            bookList.Add(new Book("紅樓夢", "曹雪芹", "章回小說"));
            bookList.Add(new Book("牡丹亭", "湯顯祖", "戲曲"));
            bookList.Add(new Book("解憂雜貨店", "東野圭吾", "小說"));
            bookList.Add(new Book("奶奶的紅鉛筆", "盧多維克‧勒孔特", "繪本"));
            bookList.Add(new Book("小王子", "安東尼‧聖修伯里", "小說"));
            bookList.Add(new Book("不便利的便利店", "金浩然", "小說"));
            bookList.Add(new Book("失物之國", "約翰．康納利", "小說"));
        }

        private void frmBookListView_Load(object sender, EventArgs e)
        {
            cmbView.Items.Add("大圖示");
            cmbView.Items.Add("詳細資料");
            cmbView.Items.Add("小圖示");
            cmbView.Items.Add("清單");
            cmbView.Items.Add("大圖示加詳細資料");
            cmbView.SelectedIndex = 0; //預設選取第一個項目

            lvwBooks.Columns.Add("書名", 120); //新增書名欄位，寬度為120
            lvwBooks.Columns.Add("作者", 120); //新增作者欄位，寬度為120
            lvwBooks.Columns.Add("類別", 120); //新增類別欄位
            /*for (int i = 0; i < b_name.Length; i++)
            { //宣告一個ListViewItem物件
                ListViewItem lvi = new ListViewItem(b_name[i]);
                lvi.SubItems.Add(author[i].ToString()); //新增作者欄位資料
                lvi.SubItems.Add(kind[i]); //新增類別欄位資料
                lvwBooks.Items.Add(lvi); //新增項目
                lvwBooks.Items[i].ImageIndex = i; //指定影像的索引值
            }*/
            RefreshBookListView();
        }

        private void RefreshBookListView()
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            lvwBooks.BeginUpdate();
            lvwBooks.Items.Clear();

            foreach (Book book in bookList)
            {
                // 檢查是否符合關鍵字（若搜尋框為空，Contains("") 永遠為 true，即顯示全部）
                if (book.Name.ToLower().Contains(keyword) || book.Author.ToLower().Contains(keyword) || book.Kind.ToLower().Contains(keyword))
                {
                    ListViewItem lvi = new ListViewItem(book.Name);
                    lvi.SubItems.Add(book.Author);
                    lvi.SubItems.Add(book.Kind);
                    lvwBooks.Items.Add(lvi);

                    lvi.ImageIndex = bookList.IndexOf(book);
                }
            }
            lvwBooks.EndUpdate();
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根據cmbView的SelectedIndex屬性值，設定檢視方式
            switch (cmbView.SelectedIndex)
            {
                case 0: //大圖示
                    lvwBooks.View = View.LargeIcon;
                    break;
                case 1: //詳細資料
                    lvwBooks.View = View.Details;
                    break;
                case 2: //小圖示
                    lvwBooks.View = View.SmallIcon;
                    break;
                case 3: //清單
                    lvwBooks.View = View.List;
                    break;
                case 4: //大圖示加詳細資料
                    lvwBooks.View = View.Tile;
                    break;
            }
        }

        private void lvwBooks_ItemActivate(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedIndices.Count == 0) return;
            string strBookname = lvwBooks.SelectedItems[0].Text;
            bool exist = false;
            foreach (var item in lstBorrow.Items)
            {
                if (item.ToString().Contains($"《{strBookname}》"))
                {
                    exist = true;
                    break; // 找到了就跳出迴圈
                }
            }

            if (exist != true) // 若選取的書名不存在借書清單中
            {
                DialogResult dr = MessageBox.Show($"確定要借閱《{strBookname}》嗎?", "借閱確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // 取得當前的系統時間，並格式化為 "年/月/日 時:分"
                    string currentTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm");

                    // 將書名與時間組合，格式例如：《三國演義》 (借閱: 2026/05/17 17:45)
                    string displayString = $"《{strBookname}》 - 借閱時間: {currentTime}";

                    // 新增項目到借書清單
                    lstBorrow.Items.Add(displayString);
                }
            }
            else
            {
                // 跳出重複借閱的警告提示
                MessageBox.Show($"《{strBookname}》已經在您的借書清單中囉！", "重複借閱提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstBorrow_DoubleClick(object sender, EventArgs e)
        {
            if (lstBorrow.SelectedItem != null)
            {
                string fullText = lstBorrow.SelectedItem.ToString();
                string[] parts = fullText.Split(new string[] { " - 借閱時間" }, StringSplitOptions.None);
                string bookName = parts[0];
                DialogResult dr = MessageBox.Show($"確定要歸還{bookName}嗎？", "還書確認", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    lstBorrow.Items.Remove(lstBorrow.SelectedItem);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookName.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(txtKind.Text) || string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("請填妥所有書籍欄位，並且一定要選取書封圖片 !", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book newBook = new Book(txtBookName.Text, txtAuthor.Text, txtKind.Text);
            bookList.Add(newBook); // 加入清單

            Image img = Image.FromFile(selectedImagePath);
            imgL.Images.Add(img);
            imgS.Images.Add(img);

            RefreshBookListView();

            // 清空輸入框與圖片狀態
            txtBookName.Clear();
            txtAuthor.Clear();
            txtKind.Clear();
            selectedImagePath = "";

            MessageBox.Show($"《{newBook.Name}》上架成功！");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshBookListView();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "圖片檔案(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
            }
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Kind { get; set; }
        public Book(string name, string author, string kind)
        {
            Name = name;
            Author = author;
            Kind = kind;
        }
    }
}
