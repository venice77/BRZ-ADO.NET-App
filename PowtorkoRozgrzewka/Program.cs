using System;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj swoje imię:");
        var name = "przemek"; //Console.ReadLine();
        Console.WriteLine("Hello " + name);

        int result1 = 5 + 9;
        Console.WriteLine(result1);
        //ZAD 1
        int number = 12; //Liczba Calkowita
        float money = 12.39F; // moni
        string text = "tekst"; // sznurek
        bool isLooged = true; //online
        char myChar = 'P';
        decimal price = 12.39M;
        Console.WriteLine(number + " " + myChar + " " + price + " " + text + " " + isLooged + " "+ money);
        
        
        //ZAD2
        string myAge = "Age: ";
        int wifeAge = 18;
        string result = myAge + wifeAge.ToString(); //tak zadziala
        Console.WriteLine(result);

        //ZAD 3
        bool isTrue = true;
        bool isFalse = false; 
        bool isReallyTrue = true;

        bool and = (isTrue && isFalse);
        bool or = (isTrue || isReallyTrue);
        bool negative = !isFalse;

        Console.WriteLine(and + " " + or + " " + negative);

        //ZAD 4
        int a = 5, b = 12;
        int add = a + b, sub = a - b, mul = a * b, mod = a % b;
        
        double div = a / b;
        Console.WriteLine(add + " " + sub + " " + div + " " + mul + " " + mod);

        //ZAD5
        string aa = "Ala ", bb = "ma ", cc = "kota.";
        string strresult = aa + bb + cc;
        Console.WriteLine(strresult); //zlaczylo stringa w calosc z 3 substringow

        //PETLE
        //ZAD1
        int n1 = 10, n2 = 20;
        if (n1 > n2)
            Console.WriteLine("n1 jest większe od n2");
        else if (n1 < n2)
            Console.WriteLine("n2 jest większe od n1");
        else
            Console.WriteLine("n1 jest równe n2");

        //ZAD2

        for (int i = 0; i < 10; i++)
            Console.WriteLine("C#");
        int g = 0;
        while (g < 10)
        {
            Console.WriteLine("C#");
            g++;
        }

        //ZAD3
        int n = 10;
        for(int i=0; i <= 10; i++)
        {
            if (i % 2==0)
                Console.WriteLine(i + " - Parzysta");
            else 
                Console.WriteLine(i + " - Nieparzysta");
        }
        Console.WriteLine();

        //ZAD4
        int y = 6;
        for(int i = 1; i < y; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write("* ");
            Console.WriteLine();
        }
        //ZAD5

        var message = Int32.Parse(Console.ReadLine()) switch
        {
            > 0 and <= 39 => "Ocena Niedostateczna",
            > 39 and <= 54 => "Ocena Dopuszczająca",
            > 54 and <= 69 => "Ocena Dostateczna",
            > 69 and <= 84 => "Ocena Dobra",
            > 84 and <= 98 => "Ocena Bardzo Dobra",
            > 98 and <= 100 => "Ocena Celująca",
            _ => "Wartość poza zakresem"
        };
        Console.WriteLine(message);

        //KOLEKCJE

        //ZAD1
        string[] colours = new string[4];
        colours[0] = "Niebieski";
        colours[1] = "Pomarancz";
        colours[2] = "Zielen";
        colours[3] = "Czerwien";
        Console.WriteLine("Mój pierwszy kolor to: " + colours[0]);
        Console.WriteLine("Moj ostatni kolor to:" + colours[3]);

        //ZAD2
        int[] liczby = new int[10];
        for (int i = 1; i <= 10; i++)
            liczby[i-1] = i;

        for(int i = 0; i < 10; i++)
            Console.WriteLine("Liczba: "+liczby[i].ToString());
        foreach (int i in liczby)
            Console.WriteLine("Liczba: " + liczby[i-1].ToString());
        int l = 0;
        while (l < liczby.Length)
        {
            Console.WriteLine("Liczba: " + liczby[l].ToString());
            l++;
        }

        //ZAD3

        List<string> fruits = new List<string>(4);
        fruits.Add("Winogrono");
        fruits.Add("Kiwi");
        fruits.Add("Mango");
        fruits.Add("Kumkwat");

        foreach (string i in fruits)
            Console.Write(i + ", ");
        Console.WriteLine();
        fruits.RemoveAt(3);
        fruits.Remove("Winogrono");
        foreach (string i in fruits)
            Console.Write(i + ", ");



    }
}