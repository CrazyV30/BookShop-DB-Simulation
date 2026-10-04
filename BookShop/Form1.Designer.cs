
namespace BookShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ShopGridView = new DataGridView();
            buttonSale = new Button();
            buttonWriteOff = new Button();
            buttonRemove = new Button();
            buttonSave = new Button();
            labelReservation = new Label();
            textBoxReservation = new TextBox();
            buttonReservation = new Button();
            labelSeeking = new Label();
            comboBoxSeekBy = new ComboBox();
            textBoxSeeking = new TextBox();
            buttonSeeking = new Button();
            buttonShowAllBooks = new Button();
            labelTheMostPopular = new Label();
            comboBoxForTheMostPopular = new ComboBox();
            labelBy = new Label();
            comboBox1 = new ComboBox();
            buttonShow = new Button();
            label1 = new Label();
            comboBoxPromotion = new ComboBox();
            buttonAddPromotion = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBoxAddTitle = new TextBox();
            textBoxAddAuthor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxAddPages = new TextBox();
            label5 = new Label();
            comboBoxAddPublisher = new ComboBox();
            comboBoxAddGenre = new ComboBox();
            label6 = new Label();
            textBoxAddPublishYear = new TextBox();
            label7 = new Label();
            textBoxAddCostPrice = new TextBox();
            label8 = new Label();
            textBoxAddSalePrice = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            buttonAddBook = new Button();
            textBoxImageURL = new TextBox();
            label12 = new Label();
            textBoxParentBook = new TextBox();
            comboBoxIsSequel = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            labelForInfoPromotion = new Label();
            Amount_label = new Label();
            textBoxAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ShopGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ShopGridView
            // 
            ShopGridView.AllowUserToDeleteRows = false;
            ShopGridView.AllowUserToResizeColumns = false;
            ShopGridView.AllowUserToResizeRows = false;
            ShopGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShopGridView.Location = new Point(12, 23);
            ShopGridView.Name = "ShopGridView";
            ShopGridView.RowHeadersWidth = 51;
            ShopGridView.Size = new Size(1045, 421);
            ShopGridView.TabIndex = 0;
            ShopGridView.CellClick += ShopGridView_CellClick;
            // 
            // buttonSale
            // 
            buttonSale.BackColor = Color.Salmon;
            buttonSale.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSale.Location = new Point(1071, 476);
            buttonSale.Name = "buttonSale";
            buttonSale.Size = new Size(96, 36);
            buttonSale.TabIndex = 1;
            buttonSale.Text = "Sale";
            buttonSale.UseVisualStyleBackColor = false;
            buttonSale.Click += buttonSale_Click;
            // 
            // buttonWriteOff
            // 
            buttonWriteOff.BackColor = Color.Salmon;
            buttonWriteOff.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonWriteOff.Location = new Point(1172, 476);
            buttonWriteOff.Name = "buttonWriteOff";
            buttonWriteOff.Size = new Size(96, 36);
            buttonWriteOff.TabIndex = 2;
            buttonWriteOff.Text = "Write Off";
            buttonWriteOff.UseVisualStyleBackColor = false;
            buttonWriteOff.Click += buttonWriteOff_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.Salmon;
            buttonRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRemove.Location = new Point(1274, 476);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(96, 36);
            buttonRemove.TabIndex = 24;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.PaleGreen;
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSave.Location = new Point(1274, 518);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(96, 36);
            buttonSave.TabIndex = 25;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelReservation
            // 
            labelReservation.AutoSize = true;
            labelReservation.Location = new Point(553, 476);
            labelReservation.Name = "labelReservation";
            labelReservation.Size = new Size(95, 20);
            labelReservation.TabIndex = 26;
            labelReservation.Text = "Reserved for:";
            // 
            // textBoxReservation
            // 
            textBoxReservation.Location = new Point(651, 473);
            textBoxReservation.Name = "textBoxReservation";
            textBoxReservation.Size = new Size(316, 27);
            textBoxReservation.TabIndex = 27;
            // 
            // buttonReservation
            // 
            buttonReservation.Location = new Point(973, 473);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(94, 29);
            buttonReservation.TabIndex = 28;
            buttonReservation.Text = "Reserve";
            buttonReservation.UseVisualStyleBackColor = true;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // labelSeeking
            // 
            labelSeeking.AutoSize = true;
            labelSeeking.Location = new Point(553, 520);
            labelSeeking.Name = "labelSeeking";
            labelSeeking.Size = new Size(60, 20);
            labelSeeking.TabIndex = 29;
            labelSeeking.Text = "Seek by";
            // 
            // comboBoxSeekBy
            // 
            comboBoxSeekBy.FormattingEnabled = true;
            comboBoxSeekBy.Location = new Point(619, 517);
            comboBoxSeekBy.Name = "comboBoxSeekBy";
            comboBoxSeekBy.Size = new Size(151, 28);
            comboBoxSeekBy.TabIndex = 30;
            // 
            // textBoxSeeking
            // 
            textBoxSeeking.Location = new Point(776, 517);
            textBoxSeeking.Name = "textBoxSeeking";
            textBoxSeeking.Size = new Size(191, 27);
            textBoxSeeking.TabIndex = 31;
            textBoxSeeking.Text = "<by which>";
            // 
            // buttonSeeking
            // 
            buttonSeeking.Location = new Point(973, 517);
            buttonSeeking.Name = "buttonSeeking";
            buttonSeeking.Size = new Size(94, 28);
            buttonSeeking.TabIndex = 32;
            buttonSeeking.Text = "Seek";
            buttonSeeking.UseVisualStyleBackColor = true;
            buttonSeeking.Click += buttonSeeking_Click;
            // 
            // buttonShowAllBooks
            // 
            buttonShowAllBooks.BackColor = Color.Khaki;
            buttonShowAllBooks.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonShowAllBooks.Location = new Point(1071, 518);
            buttonShowAllBooks.Name = "buttonShowAllBooks";
            buttonShowAllBooks.Size = new Size(197, 36);
            buttonShowAllBooks.TabIndex = 33;
            buttonShowAllBooks.Text = "Show all books";
            buttonShowAllBooks.UseVisualStyleBackColor = false;
            buttonShowAllBooks.Click += button1_Click;
            // 
            // labelTheMostPopular
            // 
            labelTheMostPopular.AutoSize = true;
            labelTheMostPopular.Location = new Point(553, 563);
            labelTheMostPopular.Name = "labelTheMostPopular";
            labelTheMostPopular.Size = new Size(163, 20);
            labelTheMostPopular.TabIndex = 34;
            labelTheMostPopular.Text = "Show the most popular";
            // 
            // comboBoxForTheMostPopular
            // 
            comboBoxForTheMostPopular.FormattingEnabled = true;
            comboBoxForTheMostPopular.Location = new Point(722, 560);
            comboBoxForTheMostPopular.Name = "comboBoxForTheMostPopular";
            comboBoxForTheMostPopular.Size = new Size(114, 28);
            comboBoxForTheMostPopular.TabIndex = 35;
            // 
            // labelBy
            // 
            labelBy.AutoSize = true;
            labelBy.Location = new Point(842, 563);
            labelBy.Name = "labelBy";
            labelBy.Size = new Size(25, 20);
            labelBy.TabIndex = 36;
            labelBy.Text = "By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(873, 560);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(94, 28);
            comboBox1.TabIndex = 37;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(973, 560);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(94, 29);
            buttonShow.TabIndex = 38;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(553, 602);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 39;
            label1.Text = "Add to a promotion";
            // 
            // comboBoxPromotion
            // 
            comboBoxPromotion.FormattingEnabled = true;
            comboBoxPromotion.Location = new Point(701, 599);
            comboBoxPromotion.Name = "comboBoxPromotion";
            comboBoxPromotion.Size = new Size(266, 28);
            comboBoxPromotion.TabIndex = 40;
            // 
            // buttonAddPromotion
            // 
            buttonAddPromotion.Location = new Point(973, 598);
            buttonAddPromotion.Name = "buttonAddPromotion";
            buttonAddPromotion.Size = new Size(94, 29);
            buttonAddPromotion.TabIndex = 41;
            buttonAddPromotion.Text = "Add";
            buttonAddPromotion.UseVisualStyleBackColor = true;
            buttonAddPromotion.Click += buttonAddPromotion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1063, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 306);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 43;
            label2.Text = "Title";
            // 
            // textBoxAddTitle
            // 
            textBoxAddTitle.Location = new Point(10, 33);
            textBoxAddTitle.Name = "textBoxAddTitle";
            textBoxAddTitle.Size = new Size(125, 27);
            textBoxAddTitle.TabIndex = 44;
            // 
            // textBoxAddAuthor
            // 
            textBoxAddAuthor.Location = new Point(141, 33);
            textBoxAddAuthor.Name = "textBoxAddAuthor";
            textBoxAddAuthor.Size = new Size(125, 27);
            textBoxAddAuthor.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 10);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 45;
            label3.Text = "Author FullName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 10);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 47;
            label4.Text = "Publisher";
            // 
            // textBoxAddPages
            // 
            textBoxAddPages.Location = new Point(202, 86);
            textBoxAddPages.Name = "textBoxAddPages";
            textBoxAddPages.Size = new Size(47, 27);
            textBoxAddPages.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 63);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 49;
            label5.Text = "Pages";
            // 
            // comboBoxAddPublisher
            // 
            comboBoxAddPublisher.FormattingEnabled = true;
            comboBoxAddPublisher.Location = new Point(272, 32);
            comboBoxAddPublisher.Name = "comboBoxAddPublisher";
            comboBoxAddPublisher.Size = new Size(138, 28);
            comboBoxAddPublisher.TabIndex = 51;
            // 
            // comboBoxAddGenre
            // 
            comboBoxAddGenre.FormattingEnabled = true;
            comboBoxAddGenre.Location = new Point(255, 86);
            comboBoxAddGenre.Name = "comboBoxAddGenre";
            comboBoxAddGenre.Size = new Size(153, 28);
            comboBoxAddGenre.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 63);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 52;
            label6.Text = "Genre";
            // 
            // textBoxAddPublishYear
            // 
            textBoxAddPublishYear.Location = new Point(90, 86);
            textBoxAddPublishYear.Name = "textBoxAddPublishYear";
            textBoxAddPublishYear.Size = new Size(106, 27);
            textBoxAddPublishYear.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 63);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 54;
            label7.Text = "Year of Publish";
            // 
            // textBoxAddCostPrice
            // 
            textBoxAddCostPrice.Location = new Point(10, 86);
            textBoxAddCostPrice.Name = "textBoxAddCostPrice";
            textBoxAddCostPrice.Size = new Size(74, 27);
            textBoxAddCostPrice.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 63);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 56;
            label8.Text = "Cost Price";
            // 
            // textBoxAddSalePrice
            // 
            textBoxAddSalePrice.Location = new Point(9, 135);
            textBoxAddSalePrice.Name = "textBoxAddSalePrice";
            textBoxAddSalePrice.Size = new Size(74, 27);
            textBoxAddSalePrice.TabIndex = 59;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 112);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 58;
            label9.Text = "Sale Price";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(textBoxAmount);
            panel1.Controls.Add(Amount_label);
            panel1.Controls.Add(comboBoxAddPublisher);
            panel1.Controls.Add(comboBoxAddGenre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxAddPublishYear);
            panel1.Controls.Add(textBoxAddAuthor);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxAddCostPrice);
            panel1.Controls.Add(textBoxAddTitle);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxAddPages);
            panel1.Controls.Add(textBoxAddSalePrice);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(buttonAddBook);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBoxImageURL);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBoxParentBook);
            panel1.Controls.Add(comboBoxIsSequel);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 466);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 164);
            panel1.TabIndex = 60;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(416, 119);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(114, 43);
            buttonAddBook.TabIndex = 65;
            buttonAddBook.Text = "Add";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // textBoxImageURL
            // 
            textBoxImageURL.Location = new Point(309, 135);
            textBoxImageURL.Name = "textBoxImageURL";
            textBoxImageURL.Size = new Size(101, 27);
            textBoxImageURL.TabIndex = 64;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(309, 112);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 63;
            label12.Text = "URL of image";
            // 
            // textBoxParentBook
            // 
            textBoxParentBook.Location = new Point(162, 135);
            textBoxParentBook.Name = "textBoxParentBook";
            textBoxParentBook.Size = new Size(141, 27);
            textBoxParentBook.TabIndex = 62;
            textBoxParentBook.Text = "<if yes>";
            // 
            // comboBoxIsSequel
            // 
            comboBoxIsSequel.FormattingEnabled = true;
            comboBoxIsSequel.Location = new Point(88, 135);
            comboBoxIsSequel.Name = "comboBoxIsSequel";
            comboBoxIsSequel.Size = new Size(68, 28);
            comboBoxIsSequel.TabIndex = 62;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(162, 112);
            label11.Name = "label11";
            label11.Size = new Size(141, 20);
            label11.TabIndex = 61;
            label11.Text = "Title of parent book";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(88, 112);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 61;
            label10.Text = "Is Sequel";
            // 
            // labelForInfoPromotion
            // 
            labelForInfoPromotion.AutoSize = true;
            labelForInfoPromotion.Location = new Point(1063, 344);
            labelForInfoPromotion.Name = "labelForInfoPromotion";
            labelForInfoPromotion.Size = new Size(100, 20);
            labelForInfoPromotion.TabIndex = 61;
            labelForInfoPromotion.Text = "<promotion>";
            // 
            // Amount_label
            // 
            Amount_label.AutoSize = true;
            Amount_label.Location = new Point(407, 9);
            Amount_label.Name = "Amount_label";
            Amount_label.Size = new Size(128, 20);
            Amount_label.TabIndex = 66;
            Amount_label.Text = "Available Amount";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(416, 32);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(114, 27);
            textBoxAmount.TabIndex = 67;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 641);
            Controls.Add(labelForInfoPromotion);
            Controls.Add(pictureBox1);
            Controls.Add(buttonAddPromotion);
            Controls.Add(comboBoxPromotion);
            Controls.Add(label1);
            Controls.Add(buttonShow);
            Controls.Add(comboBox1);
            Controls.Add(labelBy);
            Controls.Add(comboBoxForTheMostPopular);
            Controls.Add(labelTheMostPopular);
            Controls.Add(buttonShowAllBooks);
            Controls.Add(buttonSeeking);
            Controls.Add(textBoxSeeking);
            Controls.Add(comboBoxSeekBy);
            Controls.Add(labelSeeking);
            Controls.Add(buttonReservation);
            Controls.Add(textBoxReservation);
            Controls.Add(labelReservation);
            Controls.Add(buttonSave);
            Controls.Add(buttonRemove);
            Controls.Add(buttonWriteOff);
            Controls.Add(buttonSale);
            Controls.Add(ShopGridView);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "BookShop Regulator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ShopGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void comboBoxIsSequel_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView ShopGridView;
        private Button buttonSale;
        private Button buttonWriteOff;
        private Button buttonRemove;
        private Button buttonSave;
        private Label labelReservation;
        private TextBox textBoxReservation;
        private Button buttonReservation;
        private Label labelSeeking;
        private ComboBox comboBoxSeekBy;
        private TextBox textBoxSeeking;
        private Button buttonSeeking;
        private Button buttonShowAllBooks;
        private Label labelTheMostPopular;
        private ComboBox comboBoxForTheMostPopular;
        private Label labelBy;
        private ComboBox comboBox1;
        private Button buttonShow;
        private Label label1;
        private ComboBox comboBoxPromotion;
        private Button buttonAddPromotion;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBoxAddTitle;
        private TextBox textBoxAddAuthor;
        private Label label3;
        private Label label4;
        private TextBox textBoxAddPages;
        private Label label5;
        private ComboBox comboBoxAddPublisher;
        private ComboBox comboBoxAddGenre;
        private Label label6;
        private TextBox textBoxAddPublishYear;
        private Label label7;
        private TextBox textBoxAddCostPrice;
        private Label label8;
        private TextBox textBoxAddSalePrice;
        private Label label9;
        private Panel panel1;
        private TextBox textBoxParentBook;
        private ComboBox comboBoxIsSequel;
        private Label label11;
        private Label label10;
        private Button buttonAddBook;
        private TextBox textBoxImageURL;
        private Label label12;
        private Label labelForInfoPromotion;
        private TextBox textBoxAmount;
        private Label Amount_label;
    }
}
