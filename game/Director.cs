using System;
using System.Collections.Generic;

namespace game
{
    public class Director // this class represents the game itself
    {
        
        public Director()
        {
        }
        public void StartGame()
        {
            List<int> rolls = new List<int>();
            
            int check = 1;
            int score = 0;
            string play = "y";
            while (play == "y" && check == 1)
            {
                play = GetInputs();

                if (play == "y")
                {
                    rolls = GetUpdates();
            
                    score = GetOutputs(rolls) + score;
                    Console.Write($"\nYour score is: {score}\n");
                    check = checkRolls(rolls);
                }
            }   
            Console.WriteLine("\nNo dice!");
        }
        public string GetInputs()
        {
            Console.Write("\nRoll dice? [y/n] ");
            string userAns = Console.ReadLine();
            return userAns;
        }
        public List<int> GetUpdates()
        {
            Die die = new Die();
            List<int> rolls = new List<int>();
            rolls = die.Roll();

            Console.Write("You rolled: ");
            for (int i = 0; i < rolls.Count; i++)
            {
                Console.Write($"{rolls[i]} ");
            }
            return rolls;
        }
        public int GetOutputs(List<int> rolls)
        {
            int score = 0;
            foreach (int roll in rolls)
            {
                if (roll == 1)
                {
                    score = score + 100;
                }
                else if (roll == 5)
                {
                    score = score + 50;
                }
            }

            return score;
        
        }
        public int checkRolls(List<int> rolls)
        {
            int check = 0;
            foreach (int roll in rolls)
            {
                if (roll == 1)
                {
                    check = 1;
                }
                else if (roll == 5)
                {
                    check = 1;
                }
            }
            return check;
        }
    }
}