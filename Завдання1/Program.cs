using System;

class Square
{
    private double side;

    public Square()
    {
        side = 0;
    }

    public double Side
    {
        get { return side; }
        set { side = value; }
    }

    public bool Correct()
    {
        return side > 0;
    }

    public double Area()
    {
        return side * side;
    }

    public double Perimeter()
    {
        return 4 * side;
    }

    public void Print()
    {
        Console.WriteLine("╔═════════════════════╗");
        Console.WriteLine("║       Квадрат       ║");
        Console.WriteLine("╠═════════════════════╣");
        Console.WriteLine("║ Сторона:            ║");
        Console.WriteLine("║ " + side.ToString("F2").PadLeft(20) + "║");
        Console.WriteLine("╠═════════════════════╣");
        Console.WriteLine("║ Площа:              ║");
        Console.WriteLine("║ " + Area().ToString("F2").PadLeft(20) + "║");
        Console.WriteLine("╠═════════════════════╣");
        Console.WriteLine("║ Периметр:           ║");
        Console.WriteLine("║ " + Perimeter().ToString("F2").PadLeft(20) + "║");
        Console.WriteLine("╚═════════════════════╝");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Square square = new Square();

            Console.Write("Введiть довжину сторони квадрата: ");
            double side = Convert.ToDouble(Console.ReadLine());

            square.Side = side;

            Console.WriteLine("Значення квадрата у виглядi таблицi:");
            square.Print();

            if (square.Correct())
            {
                Console.WriteLine("Квадрат коректний.");
            }
            else
            {
                Console.WriteLine("Квадрат iснувати не може, бо сторона менше або дорiвнює 0.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}