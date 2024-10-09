public interface IBook
{
    bool IsAvailable();   // Метод для проверки доступности книги
    void IssueBook();     // Метод для выдачи книги
    string GetTitle();    // Метод для получения названия книги
}