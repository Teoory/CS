using System;

class HelloWorld
{
    public static int deger;
    static int[] n = new int[deger];

    static int largest()
    {
        int i;
        int max = n[0];

        for (i = 1; i < n.Length; i++)
        {
            if (n[i] > max)
            {
                max = n[i];
            }
        }
        return max;
    }

    public static void Main()
    {
        Console.Write("Kac deger girilecek: ");
        deger = Convert.ToInt32(Console.ReadLine());
        n = new int[deger];
        
        Console.WriteLine($"{deger} tane deger girin!");
        for (int i = 0; i < deger; i++)
        {
            Console.Write($"Deger {i + 1}: ");
            string input = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(input))
            {
                n[i] = Convert.ToInt32(input);
            }
            else
            {
                deger = 0;
                Console.WriteLine("Sonuc = " + largest());
            }
            
            if(i == deger)
            {
                Console.WriteLine("Max 10 tane deger girebilirsiniz!");
                Console.WriteLine("Sonuc = " + largest());
            }
        }
        Console.WriteLine("En buyuk deger = " + largest());
    }
}