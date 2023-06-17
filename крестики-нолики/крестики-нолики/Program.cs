using System;

namespace крестики_нолики
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] polya = new string[3, 3];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    polya[x,y] = "*";
                }
            }
            int c;
            int d;
            int znak = 0;
            while (true)
            {
                if(znak % 2 == 0)
                    Console.WriteLine("tour a la croix");
                else
                    Console.WriteLine("tour au rond");
                Console.Write("Mettez la ligne que vous voulez changer ");
                c = int.Parse(Console.ReadLine());
                Console.Write("Metter la colomne que vouz voulez changer ");
                d = int.Parse(Console.ReadLine());
                Console.Clear();
                if (polya[c,d] == "*")
                {
                    if (znak % 2 == 0)
                        polya[c,d] = "X";
                    else
                        polya[c,d] = "O";
                }
                else
                {
                    Console.Write("\nErreur: coup impossible\n");
                    break;
                }
                for (int x = 0; x < 3; x++)
                {
                    if (polya[x,0] == polya[x,1] && polya[x,1] == polya[x,2])
                    {
                        if (polya[x,0] == "X")
                            Console.Write("Victoire des croix\n");
                        if (polya[x,0] == "O")
                        Console.Write("Victoire des ronds\n");
                    }   
                }
                for (int y = 0; y < 3; y++)
                {
                    if (polya[0,y] == polya[1,y] && polya[1,y] == polya[2,y])
                    {
                        if (polya[0,y] == "X")
                            Console.Write("Victoire des croix\n");
                        if (polya[0,y] == "O")
                            Console.Write("Victoire des ronds\n");
                    }
                }
                if (polya[0,0] == polya[1,1] && polya[1,1] == polya[2,2])
                {
                    if (polya[0,0] == "X")
                        Console.Write("Victoire des croix\n");
                    if (polya[0,0] == "O")
                        Console.Write("Victoire des ronds\n");
                }
                if (polya[0,2] == polya[1,1] && polya[1,1] == polya[2,0])
                {
                    if (polya[0,2] == "X")
                        Console.Write("Victoire des croix\n");  
                    if (polya[0,2] == "O")
                        Console.Write("Victoire des ronds\n");
                }
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        Console.Write(polya[x, y]);
                        if (y == 2)
                            Console.Write("\n");
                        else
                            Console.Write(" | ");
                    }
                }   
                znak++;
            }
        }
    }
}
