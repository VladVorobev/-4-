public class FictionBook : IBook
{
    private string title;     // Название книги
    private bool available;   // Статус доступности книги

    public FictionBook(string title, bool available)
    {
        this.title = title;
        this.available = available;
    }

    public bool IsAvailable()
    {
        return available;
    }

    public void IssueBook()
    {
        if (available)
        {
            available = false;  // После выдачи книга становится недоступной
        }
    }

    public string GetTitle()
    {
        return title;
    }
}