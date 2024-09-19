using bookdemo.Models;
using bookdemo.Controllers;
namespace bookdemo.Data;

public static class ApplicationContext
{
    public static List<Book> Books { get; set; }

    static ApplicationContext()
    {
        new Book() { Id = 1, Title = "Karagoz Ve Hacivat", Price = 75 };
        new Book() { Id = 2, Title = "Nexus", Price = 85 };
        new Book() { Id = 3, Title = "Dede Korkut", Price = 90 };
    }

}