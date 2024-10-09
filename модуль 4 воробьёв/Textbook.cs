public class Textbook : IBook
{
    private string title;     // Название учебника
    private bool available;   // Статус доступности учебника

    public Textbook(string title, bool available)
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
            available = false;  // После выдачи учебник становится недоступным
        }
    }

    public string GetTitle()
    {
        return title;
    }
}