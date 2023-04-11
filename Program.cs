namespace Labor2;

class TestLab2
{
    static void Main(string[] args)
    {
        Complex derivedCompl = new Complex(8, -2);
        Console.WriteLine($"Для комплесного числа:{derivedCompl.X}{(derivedCompl.Y < 0?derivedCompl.Y: "+"+derivedCompl.Y)}i\tНорма:{derivedCompl.Standart()}");
        Console.WriteLine($"Для комплесного числа:{derivedCompl.X}{(derivedCompl.Y < 0?derivedCompl.Y: "+"+derivedCompl.Y)}i\tМодуль:{derivedCompl.Module()}");
        Norm baseObj = derivedCompl;
        Console.WriteLine($"Через Базовый класс Норма:\t{baseObj.Standart()}");
        Console.WriteLine($"Через Базовый класс Модуль:\t{baseObj.Module()}");
        Console.WriteLine();
        Vector derivedVect = new Vector(9, 9);
        Console.WriteLine($"Для вектора: ({derivedVect.X},{derivedVect.Y})\tНорма:{derivedVect.Standart()}");
        Console.WriteLine($"Для вектора: ({derivedVect.X},{derivedVect.Y})\tМодуль:{derivedVect.Module()}");
        baseObj = derivedVect;
        Console.WriteLine($"Через Базовый класс Норма:\t{baseObj.Standart()}");
        Console.WriteLine($"Через Базовый класс Модуль:\t{Math.Sqrt(baseObj.Module())}");
    }
}