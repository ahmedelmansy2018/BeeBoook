using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeBook.Models
{
    public class MockBookRepository: IBookRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Book> AllBooks =>
            new List<Book>
            {
                new Book {BookId = 1, Name="Strawberry Book", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Book chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Book muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Book cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryBook.jpg", InStock=true, IsBookOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryBooksmall.jpg"},
                new Book {BookId = 2, Name="Cheese cake", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Book chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Book muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Book cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, IsBookOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                new Book {BookId = 3, Name="Rhubarb Book", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Book chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Book muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Book cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbBook.jpg", InStock=true, IsBookOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbBooksmall.jpg"},
                new Book {BookId = 4, Name="Pumpkin Book", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Book chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Book muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Book cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinBook.jpg", InStock=true, IsBookOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinBooksmall.jpg"}
            };

        public IEnumerable<Book> BooksOfTheWeek { get; }

        public Book GetBookById(int BookId)
        {
            return AllBooks.FirstOrDefault(p => p.BookId == BookId);
        }
    }
}
