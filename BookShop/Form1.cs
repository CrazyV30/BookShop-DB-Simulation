using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace BookShop
{
    public partial class Form1 : Form
    {
        protected DbHandler DbHandler { get; private set; } = new DbHandler();
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DbHandler.Init(true, true);
            LoadDataManual();
        }
        private void LoadDataManual()
        {
            ShopGridView.AutoGenerateColumns = false;
            ShopGridView.AllowUserToAddRows = true;
            CreateNormalGridView();
            ShopGridView.DataSource = DbHandler.DbContext.Books.ToList();
            ShopGridView.AutoResizeColumns();
            comboBoxSeekBy.Items.AddRange(new string[] { "Title", "Author", "Genre" });
            comboBoxForTheMostPopular.Items.AddRange(new string[] { "Book", "Author", "Genre" });
            comboBox1.Items.AddRange(new string[] { "Day", "Week", "Month", "Year" });
            List<string > promotionNames = DbHandler.DbContext.Promotions.Select(p => p.Name).ToList();
            for (int i = 0; i < promotionNames.Count; i++)
                comboBoxPromotion.Items.Add(promotionNames[i].Trim()); 
            comboBoxAddGenre.Items.AddRange(new string[] { "Detetive", "Fiction", "Science-fiction", "Science", "Romcom", "Adventure", "History", "Thriller", "Fairytale", "Fantasy","Dystopian","Novel" });
            comboBoxAddPublisher.Items.AddRange(new string[] { "Nebo", "RM", "Vivat", "KSD", "BookShef", "Folio", "Ababagalamaga", "Astrolyabiya", "Ranok", "Readberry", "VSL" });
            comboBoxIsSequel.Items.AddRange(new string[] { "true", "false" });
        }
        private void CreateNormalGridView()
        {
            ShopGridView.ClearSelection();
            ShopGridView.Columns.Clear();            
            ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title", // on db label
                HeaderText = "Title", //on the grid label
                Name = "Title", //inherit name
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AuthorFullName",
                HeaderText = "Author",
                Name = "AuthorFullName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PublisherName",
                HeaderText = "Publisher",
                Name = "PublisherName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Pages",
                HeaderText = "Amount of pages",
                Name = "Pages",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Genre",
                HeaderText = "Genre",
                Name = "Genre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });
            ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PublishYear",
                HeaderText = "Year of publish",
                Name = "PublishYear",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });
            ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CostPrice",
                HeaderText = "Cost price",
                Name = "CostPrice",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });
            ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SalePrice",
                HeaderText = "Sale price",
                Name = "SalePrice",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });
            ShopGridView.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "IsSequel", // on db label
                HeaderText = "Is Sequel", //on the grid label
                Name = "IsSequel", //inherit name                
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });
            ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount", // on db label
                HeaderText = "Available Amount", //on the grid label
                Name = "Amount", //inherit name                
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });
            ShopGridView.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "IsAvailable", // on db label
                HeaderText = "Is Available", //on the grid label
                Name = "IsAvailable", //inherit name                
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });
        } 
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (GetActualBook() is Book selected)
            {
                var result = MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DbHandler.DbContext.Books.Remove(selected);
                    DbHandler.DbContext.SaveChanges();
                    ShopGridView.Refresh();
                }
            }
        }

        private void buttonWriteOff_Click(object sender, EventArgs e)
        {
            if (GetActualBook() is Book selected)
            {
                var result = MessageBox.Show("Do you really want to write off this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (!selected.IsAvailable)
                    {
                        MessageBox.Show("This book is not available for write-off.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    selected.IsAvailable = false;
                    DbHandler.DbContext.Transactions.Add(new Transactions
                    {
                        Book = selected,
                        Type = TransactionType.WriteOff,
                        Date = DateTime.Now,
                        TotalAmount = selected.CostPrice
                    });
                    DbHandler.DbContext.SaveChanges();
                    ShopGridView.Refresh();
                }
            }
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            if (GetActualBook() is Book selected)
            {
                var result = MessageBox.Show("Do you really want to sell this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (!selected.IsAvailable)
                    {
                        MessageBox.Show("This book is not available for sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (selected.PromotionBooks.Any())
                    {
                        var promotion = selected.PromotionBooks.First();
                        decimal discountAmount = Convert.ToDecimal(Convert.ToDouble(selected.SalePrice) * promotion.DiscountPercent / 100);
                        decimal discountedPrice = selected.SalePrice - discountAmount;
                        selected.SalePrice = discountedPrice; // Apply the discount to the sale price
                    }
                    selected.Amount -= 1;
                    if (selected.Amount <= 0) { 
                        selected.IsAvailable = false;
                    }
                    DbHandler.DbContext.Transactions.Add(new Transactions
                    {
                        Book = selected,
                        Type = TransactionType.Sale,
                        Date = DateTime.Now,
                        TotalAmount = selected.SalePrice
                    });
                    DbHandler.DbContext.SaveChanges();
                    ShopGridView.DataSource = DbHandler.DbContext.Books.ToList();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DbHandler.DbContext.SaveChanges();
            ShopGridView.Refresh();
        }
        private Book? GetActualBook() { if (ShopGridView.CurrentRow.DataBoundItem is Book selected) return selected; return null; }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            if (GetActualBook() is Book selected)
            {
                var result = MessageBox.Show("Do you really want to reserve this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (!selected.IsAvailable)
                    {
                        MessageBox.Show("This book is not available for reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    selected.Amount -= 1;
                    if (selected.Amount <= 0)
                    {
                        selected.IsAvailable = false;
                    }
                    DbHandler.DbContext.Transactions.Add(new Transactions
                    {
                        Book = selected,
                        Type = TransactionType.Reservation,
                        ReserverName = textBoxReservation.Text,
                        Date = DateTime.Now,
                        TotalAmount = 0
                    });
                    DbHandler.DbContext.SaveChanges();
                    ShopGridView.Refresh();
                    textBoxReservation.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) { CreateNormalGridView(); ShopGridView.DataSource = DbHandler.DbContext.Books.ToList(); }//Show all books

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var selectedxheck = comboBoxForTheMostPopular.SelectedItem as string;
            var selectedPeriod = comboBox1.SelectedItem as string;
            if (selectedxheck != null && selectedPeriod != null)
            {
                var transactions = DbHandler.DbContext.Transactions.ToList();
                DateTime periodStart = selectedPeriod switch
                {
                    "Day" => DateTime.Now.AddDays(-1),
                    "Week" => DateTime.Now.AddDays(-7),
                    "Month" => DateTime.Now.AddMonths(-1),
                    "Year" => DateTime.Now.AddYears(-1),
                    _ => DateTime.MinValue
                };
                var filteredTransactions = transactions.Where(t => t.Date >= periodStart).ToList();
                ShopGridView.ClearSelection();
                ShopGridView.Columns.Clear();
                if (selectedxheck == "Book")
                {
                    var popularBooks = filteredTransactions
                        .GroupBy(t => t.Book.Title)
                        .Select(g => new { Title = g.Key, Count = g.Count() })
                        .OrderByDescending(g => g.Count)
                        .Take(5)
                        .ToList();                    
                    ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Title", // on db label
                        HeaderText = "Title", //on the grid label
                        Name = "Title" //inherit name
                    });
                    ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Count", // on db label
                        HeaderText = "Count", //on the grid label
                        Name = "Count" //inherit name
                    });
                    ShopGridView.DataSource = popularBooks.Select(pb => new { pb.Title, pb.Count }).ToList();
                }
                else if (selectedxheck == "Author")
                {
                    var popularAuthors = filteredTransactions
                        .GroupBy(t => t.Book.AuthorFullName)
                        .Select(g => new { Author = g.Key, Count = g.Count() })
                        .OrderByDescending(g => g.Count)
                        .Take(5)
                        .ToList();
                    ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Author", // on db label
                        HeaderText = "Author", //on the grid label
                        Name = "Author" //inherit name
                    });
                    ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Count", // on db label
                        HeaderText = "Count", //on the grid label
                        Name = "Count" //inherit name
                    });
                    ShopGridView.DataSource = popularAuthors.Select(pa => new { pa.Author, pa.Count }).ToList();
                }
                else if (selectedxheck == "Genre")
                {
                    var popularGenres = filteredTransactions
                        .GroupBy(t => t.Book.Genre)
                        .Select(g => new { Genre = g.Key, Count = g.Count() })
                        .OrderByDescending(g => g.Count)
                        .Take(5)
                        .ToList();
                    ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Genre", // on db label
                        HeaderText = "Genre", //on the grid label
                        Name = "Genre" //inherit name
                    });
                    ShopGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Count", // on db label
                        HeaderText = "Count", //on the grid label
                        Name = "Count" //inherit name
                    });
                    ShopGridView.DataSource = popularGenres.Select(pg => new {pg.Genre, pg.Count }).ToList();
                }
            }
            comboBoxForTheMostPopular.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        private void buttonAddPromotion_Click(object sender, EventArgs e)
        {
            if (GetActualBook() is Book selected)
            {
                string promotionName = comboBoxPromotion.SelectedItem as string;
                Promotion promotion = DbHandler.DbContext.Promotions.FirstOrDefault(p => string.Equals(p.Name, promotionName))!;
                if (promotion != null)
                {
                    if (!selected.PromotionBooks.Any( p => string.Equals(p.Name, promotionName)))
                    {
                        selected.PromotionBooks.Add(promotion);
                        DbHandler.DbContext.SaveChanges();
                        MessageBox.Show("Promotion added to the book successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("This book is already in the selected promotion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
            comboBoxPromotion.SelectedIndex = -1;
        }
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                Title = textBoxAddTitle.Text,
                AuthorFullName = textBoxAddAuthor.Text,
                PublisherName = comboBoxAddPublisher.SelectedItem!.ToString() ?? string.Empty,
                Pages = int.Parse(textBoxAddPages.Text),
                Genre = comboBoxAddGenre.SelectedItem!.ToString() ?? string.Empty,
                PublishYear = int.Parse(textBoxAddPublishYear.Text),
                CostPrice = decimal.Parse(textBoxAddCostPrice.Text),
                SalePrice = decimal.Parse(textBoxAddSalePrice.Text),
                Amount = int.Parse(textBoxAmount.Text),
                IsAvailable = true,
                ImageURL = textBoxImageURL.Text
            };
            if (comboBoxIsSequel.SelectedItem!.ToString() == "true")
            {
                book.IsSequel = true;
                book.ParentBook = DbHandler.DbContext.Books.FirstOrDefault(b => string.Equals(b.Title, textBoxParentBook.Text));
            }
            DbHandler.DbContext.Books.Add(book);
            DbHandler.DbContext.SaveChanges();
            ShopGridView.DataSource = DbHandler.DbContext.Books.ToList();

            textBoxAddTitle.Text = "";
            textBoxAddAuthor.Text = "";
            comboBoxAddPublisher.SelectedIndex = -1;
            textBoxAddPages.Text = "";
            comboBoxAddGenre.SelectedIndex = -1;
            textBoxAddPublishYear.Text = "";
            textBoxAddCostPrice.Text = "";
            textBoxAddSalePrice.Text = "";
            comboBoxIsSequel.SelectedIndex = -1;
            textBoxAmount.Text = "";
            textBoxParentBook.Text = "";
            textBoxImageURL.Text = "";
        }


        private void ShopGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GetActualBook() is Book selected)
            {
                pictureBox1.LoadAsync(selected.ImageURL);
                if (selected.PromotionBooks.Any())
                {
                    var promotion = selected.PromotionBooks.First();
                    decimal discountAmount = Convert.ToDecimal(Convert.ToDouble(selected.SalePrice) * promotion.DiscountPercent / 100);
                    decimal discountedPrice = selected.SalePrice - discountAmount;
                    labelForInfoPromotion.Text = $"{selected.Title} has a discount\nof {promotion.DiscountPercent}%!\nDiscounted price: {discountedPrice:C}";
                }
                else if (DbHandler.DbContext.Transactions.Any(t => t.BookId == selected.Id && t.Type == TransactionType.Reservation))
                {
                    Transactions reservation = DbHandler.DbContext.Transactions.FirstOrDefault(t => t.BookId == selected.Id && t.Type == TransactionType.Reservation);
                    labelForInfoPromotion.Text = $"This book is reserved for {reservation.ReserverName}!";
                }
                else
                    labelForInfoPromotion.Text = "";
            }
        }

        private void buttonSeeking_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSeeking.Text.ToLower();
            string searchBy = comboBoxSeekBy.SelectedItem as string;
            if (searchBy == "Title")
                ShopGridView.DataSource = DbHandler.DbContext.Books.Where(b => string.Equals(b.Title.ToLower().Trim(), searchTerm.ToLower().Trim())).ToList();            
            else if (searchBy == "Author")
                ShopGridView.DataSource = DbHandler.DbContext.Books.Where(b => string.Equals(b.AuthorFullName.ToLower().Trim(), searchTerm.ToLower().Trim())).ToList();            
            else if (searchBy == "Genre")
                ShopGridView.DataSource = DbHandler.DbContext.Books.Where(b => b.Genre.ToLower().Contains(searchTerm)).ToList();            
            textBoxSeeking.Text = "";
            comboBoxSeekBy.SelectedIndex = -1;
        }
    }
}
