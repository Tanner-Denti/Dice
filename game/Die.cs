using System;
using System.Collections.Generic;

namespace game
{
    public class Die
    {
        public Die()
        {
        }
        public List<int> Roll()
        {
            Random rand = new Random();
            List<int> rolls = new List<int>();
            for (int i = 0;i < 5;i++)
            {
                rolls.Add(rand.Next(1,6));
            }

            return rolls;
        }
    }
}