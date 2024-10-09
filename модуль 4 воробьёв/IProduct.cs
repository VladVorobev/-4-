public interface IProduct
{
    // Метод для получения имени товара
    string GetName();

    // Метод для получения стоимости товара
    decimal GetPrice();

    // Метод для получения остатка товара на складе
    int GetStock();
}