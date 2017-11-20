using System.Collections.Generic;
using System.Data.Entity;

namespace BookShop.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Children"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Finance"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Non-fiction"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Technical"
                },
            };

            return categories;
        }

        private static List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book
                {
                    ISBN = "9781484746424",
                    BookTitle = "The Trials of Apollo Book Two The Dark Prophecy",
                    Author = "Rick Riordan",
                    ImagePath="9781484746424.jpg",
                    UnitPrice = 19.99,
                    CategoryID = 1
               },
                new Book
                {
                    ISBN = "9780385376716",
                    BookTitle = "The Wonderful Things You Will Be",
                    Author = "Emily Winfield Martin",
                    ImagePath="9780385376716.jpg",
                    UnitPrice = 17.99,
                    CategoryID = 1
               },
                new Book
                {
                    ISBN = "9781619634480",
                    BookTitle = "A Court of Wings and Ruin",
                    Author = "Sarah J. Maas",
                    ImagePath="9781619634480.jpg",
                    UnitPrice = 18.99,
                    CategoryID = 1
                },
                new Book
                {
                    ISBN = "9781442468405",
                    BookTitle = "Lord of Shadows (The Dark Artifices)",
                    Author = "Cassandra Clare",
                    ImagePath="9781442468405.jpg",
                    UnitPrice = 24.99,
                    CategoryID = 1
                },
                new Book
                {
                    ISBN = "9780399255373",
                    BookTitle = "The Day the Crayons Quit",
                    Author = "Drew Daywalt and Oliver Jeffers",
                    ImagePath="9780399255373.jpg",
                    UnitPrice = 17.99,
                    CategoryID = 2
                },
                new Book
                {
                    ISBN = "9780374300210",
                    BookTitle = "If Animals Kissed Good Night",
                    Author = "Ann Whitford Paul and David Walker",
                    ImagePath="9780374300210.jpg",
                    UnitPrice = 7.99,
                    CategoryID = 4
                },
                new Book
                {
                    ISBN = "9780803741713",
                    BookTitle = "The Book with No Pictures",
                    Author = "B. J. Novak",
                    ImagePath="9780803741713.jpg",
                    UnitPrice = 17.99,
                    CategoryID = 3
                },
                new Book
                {
                    ISBN = "9780062498533",
                    BookTitle = "The Hate U Give",
                    Author = "Angie Thomas",
                    ImagePath="9780062498533.jpg",
                    UnitPrice = 17.99,
                    CategoryID = 4
                },
                new Book
                {
                    ISBN = "9781484732748",
                    BookTitle = "The Trials of Apollo, Book 1: The Hidden Oracle",
                    Author = "Rick Riordan",
                    ImagePath="9781484732748.jpg",
                    UnitPrice = 19.99,
                    CategoryID = 1
                },
                new Book
                {
                    ISBN = "9781616205676",
                    BookTitle = "The Girl Who Drank the Moon",
                    Author = "Kelly Barnhill",
                    ImagePath="9781616205676.jpg",
                    UnitPrice = 16.95,
                    CategoryID = 2
                },
                new Book
                {
                    ISBN = "9781524766498",
                    BookTitle = "We're All Wonders",
                    Author = "R. J. Palacio",
                    ImagePath="9781524766498.jpg",
                    UnitPrice = 18.99,
                    CategoryID = 3
                },
                new Book
                {
                    ISBN = "9780060555665",
                    BookTitle = "The Intelligent Investor",
                    Author = "R. J. Palacio",
                    ImagePath="9780060555665.jpg",
                    UnitPrice = 22.99,
                    CategoryID = 2
                }
            };

            return books;
        }
    }
    //    PM> enable-migrations -contexttypename ProductContext
    //PM> add-migration InitialCreate
    //PM> update-database
}