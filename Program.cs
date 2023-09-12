class Program
{
    static void Main()
    {
        Random r = new Random();
        int k = 0, c = 0, i = 0, b = 0, a = 10;
        int[] mas = new int[a];
        for (int ii = 0; ii < a; ii++)
        {
            mas[ii] = r.Next(-2, 2);
            Console.Write("{0,3}", mas[ii]);
            if (mas[ii] == 0)
                k++;
        }
        Console.WriteLine();
        while (i < a)
        {
            for (int ii = 0; ii < a - 1; ii++)
                if (mas[ii] == 0 && mas[ii + 1] != 0)
                {
                    b = mas[ii];
                    mas[ii] = mas[ii + 1];
                    mas[ii + 1] = b;
                }
            i++;
        }
        for (int ii = 0; ii < a - k; ii++)
        {
            Console.Write("{0,3}", mas[ii]);
            c++;
        }
        Console.Write("\nПовтор?( enter - да; люб. др. клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        if (povtor == "")
            Main();
    }
}