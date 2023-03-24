using System;
public class ЕnteringNumbers
{
    private int n = 0;
    public bool SetNumber(int number)
    {
        if (number == n + 1)
        {
            n = number;
            return true;
        }
        else
        {
            n = 0;
            return false;
        }
    }
    public int GetExpectedNumber()
    {
        return n + 1;
    }
}
class Program
{
    static void Main()
    {
        ЕnteringNumbers enteringnumbers = new ЕnteringNumbers();

        while (true)
        {
            Console.Write($"Ввод числа {enteringnumbers.GetExpectedNumber()}: ");
            int inputNumber;
            if (int.TryParse(Console.ReadLine(), out inputNumber))
            {
                if (enteringnumbers.SetNumber(inputNumber))
                {
                    Console.WriteLine("Замечательно, вы ввели правильно!!");
                }
                else
                {
                    Console.WriteLine("Как жаль, вы ввели не верно :( Начнинаем заново...");
                }
            }
            else
            {
                Console.WriteLine("Нужно хоть что-то вводить.");
            }
        }
    }
}