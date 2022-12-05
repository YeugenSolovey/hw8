using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/





/*
 * Тут використовуємо
 * принцип розділення інтерфейсу (ISP)
 * (The Interface Segregation Principle)
*/
interface IItem
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}

interface IItemDesign
{
    void SetColor(byte color);
    void SetSize(byte size);
}

interface IItemPrice
{
    void SetPrice(double price);
}

class Book : IItem, IItemPrice
{
    private double _price;
    private string _discount;
    private string _promocode;

    public void ApplyDiscount(String discount)
    {
        _discount = discount;
    }
    public void ApplyPromocode(String promocode)
    {
        _promocode = promocode;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }

    public void showInfo()
    {
        Console.WriteLine("Book price: {0}; Book discpunt: {1}; Book promocode: {2}", _price, _discount, _promocode);
    }
}

class Clothes : IItem, IItemPrice, IItemDesign
{
    private double _price;
    private string _discount;
    private string _promocode;
    private byte _color;
    private byte _size;

    public void ApplyDiscount(String discount)
    {
        _discount = discount;
    }
    public void ApplyPromocode(String promocode)
    {
        _promocode = promocode;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public void SetColor(byte color)
    {
        _color = color;
    }
    public void SetSize(byte size)
    {
        _size = size;
    }
    public void showInfo()
    {
        Console.WriteLine("Clothes price: {0}; Clothes discpunt: {1}; Clothes promocode: {2}; Clothes color: {3}; Clothes size: {4}", 
            _price, _discount, _promocode, _color, _size);
    }
}



class Program
{
    static void Main(string[] args)
    {
        //book info
        Book book = new Book();
        book.ApplyDiscount("book discount");
        book.ApplyPromocode("book promocode");
        book.SetPrice(123);
        book.showInfo();

        //clothes info
        Clothes clothes = new Clothes();
        clothes.ApplyDiscount("book discount");
        clothes.ApplyPromocode("book promocode");
        clothes.SetPrice(123);
        clothes.SetSize(2);
        clothes.SetColor(3);
        clothes.showInfo();

        Console.ReadKey();
    }
}