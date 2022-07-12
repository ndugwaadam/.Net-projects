using System;

using System.Threading;

namespace first_game_snake_
{
    class snake
    {
        int h1 = 30; // writeboard
        int w1 = 40; // writeboard

        int[] x = new int[50];
        int[] y = new int[50];

        int fruitx;
        int fruity;

        int parts = 3;

        Random rnd = new Random();

        snake()
        {
            x[0] = 5;
            y[0] = 5;
            Console.CursorVisible = false;
            fruitx = rnd.Next(2, (w1 - 2));
            fruity = rnd.Next(2, (h1 - 2));
        }

        ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
        char key = '#';

        public void Writeboard() //Here we are creating the bounderies for the snake
        {
           
            Console.Clear();

            Console.WriteLine("\t Benna.A Snake Game");

            for (int i = 1; i <= (w1 + 2); i++)
            {
               
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }

            for (int i = 1; i <= (w1 + 2); i++)
            {
                Console.SetCursorPosition(i, (h1+2));
                Console.Write("-");
            }

            for (int i = 1; i <= (h1 + 2); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("l");
            }

            for (int i = 1; i <= (h1 + 2); i++)
            {
                Console.SetCursorPosition((w1+2), i);
                Console.Write("l");
            }

        }

        public void input()
        {
            if (Console.KeyAvailable)
            {
                keyinfo = Console.ReadKey(true);
                key = keyinfo.KeyChar;
            }

        }

        public void writepoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("#");
        }

        public void logic()
        {
            if (x[0] == fruitx)
            {
                if (y[0] == fruity)
                {
                    parts++;
                    fruitx = rnd.Next(2, (w1-2));
                    fruity = rnd.Next(2, (h1-2));
                }
            }
            for (int i = parts;i>1;i--)
            {
                x[i - 1] = x[i - 2];
                y[i - 1] = y[i - 2];
            }
            switch(key) //snake navigations
            {
                case 'w':
                    y[0]--;
                    break;
                case 'z':
                    y[0]++;
                    break;
                case 'd':
                    x[0]++;
                    break;
                case 'a':
                    x[0]--;
                    break;

            }
            for(int i = 0; i <= (parts - 1); i++)
            {
                writepoint(x[i], y[i]);
                writepoint(fruitx, fruity);
            }
            Thread.Sleep(100);

        }

        static void Main(string[] args)
        {
            
            snake snake = new snake();
            while (true)
            {
                snake.Writeboard();
                snake.input();
                snake.logic();
            }
                Console.ReadKey();
            
        }
    }
}
