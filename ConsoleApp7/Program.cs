using System;

public class Square
{
    private double side;

    public Square(double side)
    //Конструктор з параметром дозволяє створювати об'єкти класу Square з встановленою стороною. У нашому випадку конструктор буде використовувати значення сторони квадрата і присвоювати його до закритого поля класу.
    {
        this.side = side;
    }

    public bool Correct()
    //Метод Correct перевіряє, чи можна існувати об'єкт класу Square з даною стороною. У випадку наш метод буде перевіряти, чи є значення сторони додатковим числом. Якщо так, то метод поверне true, інакше - false.
    {
        return side > 0;
    }

    public double Area()
    //Метод Area обчислює площу квадрата. У нашому випадку для збільшення площі квадрата потрібно помножити значення сторони на самому собі. 
    {
        return side * side;
    }

    public double Perimeter()
    //Метод Периметр обчислює периметр квадрата. У нашому випадку для обчислення периметра квадрата потрібно помножити значення сторони на 4.
    {
        return side * 4;
    }

    public void Print()
    //Метод друку виводить значення сторони квадрата на екран. У нашому випадку для виведення значення сторони на екрані можна використовувати функцію Console.WriteLine. 
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Значення сторони: " + side);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть значення сторони квадрата:");
        double side = Convert.ToDouble(Console.ReadLine());

        Square square = new Square(side);

        square.Print();

        if (square.Correct())
        {
            Console.WriteLine("Площа квадрата: " + square.Area());
            Console.WriteLine("Периметр квадрата: " + square.Perimeter());
        }
        else
        {
            Console.WriteLine("Некоректне значення сторони квадрата.");
        }
    }
}

