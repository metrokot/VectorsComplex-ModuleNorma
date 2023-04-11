namespace Labor2;

abstract class Norm
{
    public abstract double Standart();
    public double Module()=> Math.Pow(X, 2)+Math.Pow(Y, 2);
    public int X { get;}
    public int Y { get;}
    public Norm(int number1, int number2) {X = number1; Y = number2;} 
}

class Complex : Norm
{
    public override double Standart() => Double.Sqrt(base.Module());
    public double Module() => base.Module();
    public Complex(int number1,int number2):base(number1, number2){}
}

class Vector : Norm
{
    public double Module()=>Double.Sqrt(base.Module());
    public override double Standart()=>(Math.Abs(X) > Math.Abs(Y) ? Math.Abs(X) : Math.Abs(Y));
    public Vector(int number1,int number2):base(number1, number2){}
}

//нормаль комплексного числа - корень из суммы квадратов
//модуль комплексного числа - нормаль в квадрате

//нормаль вектора - максимальное из чисел по модулю
//модуль вектора - корень из суммы квадратов