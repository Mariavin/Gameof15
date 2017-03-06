using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameof15.Data
{
    public class Game
    {
        private int[,] GameArea { get; set; }

        public Game(int[] n)
        {
            int k = 0;//счетчик

            var N = Math.Sqrt(n.Length);
            // Проверка на целое ли число 
            
            if (Math.Sqrt(n.Length) - Math.Truncate(Math.Sqrt(n.Length)) == 0) 
            {
                GameArea = new int[(int)N, (int)N];
                           
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        GameArea[i, j] = n[k];
                        k++;                 
                    }
                }
            }
        }

        private KeyValuePair<int, int>? GetLocation(int value)
        {
            for (int i = 0; i < GameArea.Length; i++)
            {
                for (int j = 0; j < GameArea.Length; j++)
                {
                    if (value == GameArea[i, j])
                    {
                        return new KeyValuePair<int, int>(i, j);                       
                    }
                }
            }
            return null;
        }

        private int? GetValue(int x, int y)
        {
            for (int i = 0; i < GameArea.Length; i++)
            {
                for (int j = 0; j < GameArea.Length; j++)
                {
                    if (x == i && y == j)
                    {
                        return GameArea[i, j];
                    }
                }
            }
            return null;
        }

        public KeyValuePair<int, int>? this[int value]
        {
            get
            {
                return (GetLocation(value));
            }
        }

        public int? this[int x, int y]
        {
            get
            {
                return (GetValue(x, y));
            }
        }
    }
}
