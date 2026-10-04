using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text;
using static System.Net.WebRequestMethods;

namespace BookShop
{
    public class DbHandler
    {
        public BookShopContext DbContext { get; private set; } = new BookShopContext();

        public DbHandler()
        {
        }

        public void Init(bool recrate = false, bool setdummydata = false)
        {
            if (recrate) DbContext.Database.EnsureDeleted();
            DbContext.Database.EnsureCreated();
            if (setdummydata) SetDummyData();       
        }
        public void SetDummyData() {
            Book book1 = new Book()
            {
                Title = "Harry Potter and the Philosopher's Stone",
                AuthorFullName = "J.K. Rowling",
                PublisherName = "Ababagalamaga",
                Pages = 320,
                Genre = "Fantasy",
                PublishYear = 2017,
                CostPrice = 180.00m,
                SalePrice = 299.00m,
                IsSequel = false,
                Amount = 10,
                IsAvailable = true,
                ImageURL = "https://res.cloudinary.com/bloomsbury-atlas/image/upload/w_360,c_scale,dpr_1.5/jackets/9781408855652.jpg"
            };
            Book book2 = new Book()
            {
                Title = "Harry Potter and the Chamber of Secrets",
                AuthorFullName = "J.K. Rowling",
                PublisherName = "Ababagalamaga",
                Pages = 352,
                Genre = "Fantasy",
                PublishYear = 2018,
                CostPrice = 190.00m,
                SalePrice = 319.00m,
                IsSequel = true,
                ParentBook = book1,
                Amount = 10,
                IsAvailable = true,
                PromotionBooks = new List<Promotion>(),
                ImageURL = "https://d3ddkgxe55ca6c.cloudfront.net/assets/t1711556476/a/2f/20/158646-ml-2252022.jpg"
            };
            Book book3 = new Book()
            {
                Title = "The Hunger Games",
                AuthorFullName = "Suzanne Collins",
                PublisherName = "BookShef",
                Pages = 352,
                Genre = "Fantasy",
                PublishYear = 2012,
                CostPrice = 300.00m,
                SalePrice = 350.00m,
                IsSequel = false,
                Amount = 10,
                IsAvailable = true,
                PromotionBooks = new List<Promotion>(),
                ImageURL = "https://www.britishbook.ua/upload/resize_cache/iblock/f1b/hcg1j8e1x874e89rny48s58yfxvugstx/1900_800_174b5ed2089e1946312e2a80dcd26f146/knyga_the_hunger_games_book_1.jpg"
            };
            List<Book> books = new List<Book> { 
                new Book() {
                    Title = "Harry Potter and the Prisoner of Azkaban",
                    AuthorFullName = "J.K. Rowling",
                    PublisherName = "Ababagalamaga",
                    Pages = 448,
                    Genre = "Fantasy",
                    PublishYear = 2019,
                    CostPrice = 200.00m,
                    SalePrice = 349.00m,
                    IsSequel = true,
                    ParentBook = book2,
                    Amount = 10,
                    IsAvailable = true,
                    PromotionBooks = new List<Promotion>(),
                    ImageURL = "https://static.yakaboo.ua/media/catalog/product/9/7/9781408855911.jpg"
                },                
                new Book() {
                    Title = "Catching fire",
                    AuthorFullName = "Suzanne Collins",
                    PublisherName = "BookShef",
                    Pages = 368,
                    Genre = "Fantasy",
                    PublishYear = 2013,
                    CostPrice = 300.00m,
                    SalePrice = 350.00m,
                    IsSequel = true,
                    ParentBook = book3,
                    Amount = 10,
                    IsAvailable = true,
                    PromotionBooks = new List<Promotion>(),
                    ImageURL = "https://www.britishbook.ua/upload/resize_cache/iblock/2e4/4o9v0e4lg7vj699zco324913l3l1hp0f/1900_800_174b5ed2089e1946312e2a80dcd26f146/knyga_catching_fire_book_2.jpg"
                },
                new Book() {
                    Title = "The Housemaid",
                    AuthorFullName = "Freida McFadden",
                    PublisherName = "Vivat",
                    Pages = 352,
                    Genre = "Thriller",
                    PublishYear = 2017,
                    CostPrice = 200.00m,
                    SalePrice = 300.00m,
                    IsSequel = false,
                    Amount = 10,
                    IsAvailable = true,
                    PromotionBooks = new List<Promotion>(),
                    ImageURL = "https://www.britishbook.ua/upload/resize_cache/iblock/0ae/d8g1t86pukuzcuzdtej2oy9dglbny4wg/1900_800_174b5ed2089e1946312e2a80dcd26f146/knyga_the_housemaid_book_1.jpg"
                }
            };
            DbContext.Books.Add(book1);
            DbContext.Books.Add(book2);
            DbContext.Books.Add(book3);
            DbContext.Books.AddRange(books);
            List<Promotion> promotions = new List<Promotion>()
            {
                new Promotion() {
                    Name = "Знижка 20% на бестселери",
                    Description = "Отримайте знижку 20% на найпопулярніші книги в нашому магазині! Акція діє з 1 по 31 січня. Не пропустіть шанс поповнити свою бібліотеку за вигідною ціною!",
                    DiscountPercent = 20,
                    StartDate = new DateTime(2026, 1, 1),
                    EndDate = new DateTime(2026, 1, 31),
                    PromotionBooks = new List<Book>() { book1, book2, book3 }
                },
                new Promotion() {
                    Name = "Весняна розпродаж",
                    Description = "Весна прийшла, а разом з нею і неймовірні знижки! Отримайте до 30% знижки на вибрані книги в період з 15 березня по 15 квітня. Не пропустіть можливість оновити свою колекцію книг за вигідною ціною!",
                    DiscountPercent = 30,
                    StartDate = new DateTime(2025, 3, 15),
                    EndDate = new DateTime(2025, 4, 15),
                    PromotionBooks = new List<Book>() { book1, book2 }
                }
             };
            DbContext.Promotions.AddRange(promotions);
            DbContext.SaveChanges();
        }
    }
    public class BookShopContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BookShop.db");
        }
    }
    [Table(nameof(BookShopContext.Books))]
    public class Book {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string AuthorFullName { get; set; } = string.Empty;
        public string PublisherName { get; set; } = string.Empty;
        public int Pages { get; set; }
        public string Genre { get; set; } = string.Empty;
        public int PublishYear { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool IsSequel { get; set; } = false;
        public int? ParentBookId { get; set; }//FK parent book
        public Book ParentBook { get; set; }
        public int Amount { get; set; }
        public bool IsAvailable { get; set; } = true;
        public List<Promotion> PromotionBooks { get; set; } = new List<Promotion>();
        public string ImageURL { get; set; } = string.Empty;
    }
    public enum TransactionType
    {
        Sale,
        WriteOff,
        Reservation
    }
    public class Transactions
    {
        public int Id { get; set; }
        public int BookId { get; set; } //FK book
        public Book Book { get; set; }
        public TransactionType Type { get; set; }
        public string? ReserverName { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public DateTime Date { get; set; }
    }
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double DiscountPercent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Book> PromotionBooks { get; set; } = new List<Book>();
    }
}
