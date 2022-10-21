using System;
 void Genereranummer(int p)
{
    {
        for (int i = 0; i < p; i++)
        {
            Random X = new Random();
            Random Y = new Random();
            int numberX = X.Next(-10, 10);
            int numberY = Y.Next(-10, 10);
            Console.WriteLine(" X = " + numberX);
            Console.WriteLine(" Y = " + numberY);
            Console.WriteLine(" - ");
        }
        
    }
}
Genereranummer(5);
//Console.WriteLine("hur många kordinater vill du ha?");
//int Variabel=Convert.ToInt32(Console.ReadLine());
//Genereranummer(Variabel);