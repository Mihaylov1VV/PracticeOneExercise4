namespace Exercise4;

class Program
{
    static void Main(string[] args)
    {
        //Задание 4. Напишите программу, которая считывает из консоли фразу и сохраняет её.
        //Зачем считывает вторую фразу и выводит на экран консоли обе этих фраы 
        
        string frasa1;
        Console.WriteLine("Введите первую фразу: ");
        frasa1 = Console.ReadLine();
        
        string frasa2;
        Console.Write("Введите вторую фразу: ");
        frasa2 = Console.ReadLine();
        Console.WriteLine(frasa1 + " " + frasa2);
        // У меня не получилось сделать так, чтобы введенная первая фраза не выводилась сразу на консоль
    }
}