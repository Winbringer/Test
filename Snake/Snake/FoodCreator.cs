using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        private int v1;
        private int v2;
        private char v3;
        Random r = new Random();
        public FoodCreator(int v1, int v2, char v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        internal Point CreateFood()
        {
            int x = r.Next(2, v1 - 2);
            int y = r.Next(2, v2 - 2);
            return new Point(x, y, v3);
        }
    }
}
