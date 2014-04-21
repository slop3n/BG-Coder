using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CardWars
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger playerOneGlobalScore = 0;
        BigInteger playerTwoGlobalScore = 0;
        BigInteger playerOneWins = 0;
        BigInteger playerTwoWins = 0;
        bool playerOneCardX = false;
        bool playerTwoCardX = false;

        for (int i = 0; i < n; i++)
        {
            BigInteger playerOneScore = 0;
            BigInteger playerTwoScore = 0;
            string playerOneCardA = Console.ReadLine();
            string playerOneCardB = Console.ReadLine();
            string playerOneCardC = Console.ReadLine();

            // CARD A
            switch (playerOneCardA)
            {
                case "K": playerOneScore += 13; break;
                case "Q": playerOneScore += 12; break;
                case "J": playerOneScore += 11; break;
                case "2": playerOneScore += 10; break;
                case "3": playerOneScore += 9; break;
                case "4": playerOneScore += 8; break;
                case "5": playerOneScore += 7; break;
                case "6": playerOneScore += 6; break;
                case "7": playerOneScore += 5; break;
                case "8": playerOneScore += 4; break;
                case "9": playerOneScore += 3; break;
                case "10": playerOneScore += 2; break;
                case "A": playerOneScore += 1; break;
                case "Z": playerOneScore *= 2; break;
                case "Y": playerOneScore -= 200; break;
                case "X": playerOneCardX = true; break;
            }
           
            // CARD B
            switch (playerOneCardB)
            {
                case "K": playerOneScore += 13; break;
                case "Q": playerOneScore += 12; break;
                case "J": playerOneScore += 11; break;
                case "2": playerOneScore += 10; break;
                case "3": playerOneScore += 9; break;
                case "4": playerOneScore += 8; break;
                case "5": playerOneScore += 7; break;
                case "6": playerOneScore += 6; break;
                case "7": playerOneScore += 5; break;
                case "8": playerOneScore += 4; break;
                case "9": playerOneScore += 3; break;
                case "10": playerOneScore += 2; break;
                case "A": playerOneScore += 1; break;
                case "Z": playerOneScore *= 2; break;
                case "Y": playerOneScore -= 200; break;
                case "X": playerOneCardX = true; break;
            }
           

            // CARD C
            switch (playerOneCardC)
            {
                case "K": playerOneScore += 13; break;
                case "Q": playerOneScore += 12; break;
                case "J": playerOneScore += 11; break;
                case "2": playerOneScore += 10; break;
                case "3": playerOneScore += 9; break;
                case "4": playerOneScore += 8; break;
                case "5": playerOneScore += 7; break;
                case "6": playerOneScore += 6; break;
                case "7": playerOneScore += 5; break;
                case "8": playerOneScore += 4; break;
                case "9": playerOneScore += 3; break;
                case "10": playerOneScore += 2; break;
                case "A": playerOneScore += 1; break;
                case "Z": playerOneScore *= 2; break;
                case "Y": playerOneScore -= 200; break;
                case "X": playerOneCardX = true; break;
            }

            string playerTwoCardA = Console.ReadLine();
            string playerTwoCardB = Console.ReadLine();
            string playerTwoCardC = Console.ReadLine();

            // CARD A
            switch (playerTwoCardA)
            {
                case "K": playerTwoScore += 13; break;
                case "Q": playerTwoScore += 12; break;
                case "J": playerTwoScore += 11; break;
                case "2": playerTwoScore += 10; break;
                case "3": playerTwoScore += 9; break;
                case "4": playerTwoScore += 8; break;
                case "5": playerTwoScore += 7; break;
                case "6": playerTwoScore += 6; break;
                case "7": playerTwoScore += 5; break;
                case "8": playerTwoScore += 4; break;
                case "9": playerTwoScore += 3; break;
                case "10": playerTwoScore += 2; break;
                case "A": playerTwoScore += 1; break;
                case "Z": playerTwoScore *= 2; break;
                case "Y": playerTwoScore -= 200; break;
                case "X": playerTwoCardX = true; break;
            }

            // CARD B
            switch (playerTwoCardB)
            {
                case "K": playerTwoScore += 13; break;
                case "Q": playerTwoScore += 12; break;
                case "J": playerTwoScore += 11; break;
                case "2": playerTwoScore += 10; break;
                case "3": playerTwoScore += 9; break;
                case "4": playerTwoScore += 8; break;
                case "5": playerTwoScore += 7; break;
                case "6": playerTwoScore += 6; break;
                case "7": playerTwoScore += 5; break;
                case "8": playerTwoScore += 4; break;
                case "9": playerTwoScore += 3; break;
                case "10": playerTwoScore += 2; break;
                case "A": playerTwoScore += 1; break;
                case "Z": playerTwoScore *= 2; break;
                case "Y": playerTwoScore -= 200; break;
                case "X": playerTwoCardX = true; break;
            }

            // CARD C
            switch (playerTwoCardC)
            {
                case "K": playerTwoScore += 13; break;
                case "Q": playerTwoScore += 12; break;
                case "J": playerTwoScore += 11; break;
                case "2": playerTwoScore += 10; break;
                case "3": playerTwoScore += 9; break;
                case "4": playerTwoScore += 8; break;
                case "5": playerTwoScore += 7; break;
                case "6": playerTwoScore += 6; break;
                case "7": playerTwoScore += 5; break;
                case "8": playerTwoScore += 4; break;
                case "9": playerTwoScore += 3; break;
                case "10": playerTwoScore += 2; break;
                case "A": playerTwoScore += 1; break;
                case "Z": playerTwoScore *= 2; break;
                case "Y": playerTwoScore -= 200; break;
                case "X": playerTwoCardX = true; break;
            }

            if (playerOneCardX)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (playerTwoCardX)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }

            else if (playerOneCardX && playerTwoCardX)
            {
                playerOneGlobalScore += 50;
                playerTwoGlobalScore += 50;
                playerOneCardX = false;
                playerTwoCardX = false;
            }

            if (playerOneScore > playerTwoScore)
            {
                playerOneGlobalScore += playerOneScore;
                playerOneWins++;
            }
            else if (playerOneScore < playerTwoScore)
            {
                playerTwoGlobalScore += playerTwoScore;
                playerTwoWins++;
            }
            
        }

        if (playerOneGlobalScore>playerTwoGlobalScore)
        {
            Console.WriteLine("First player wins!\nScore: {0}\nGames won: {1}", playerOneGlobalScore, playerOneWins);
        }
        else if (playerTwoGlobalScore > playerOneGlobalScore)
        {
            Console.WriteLine("Second player wins!\nScore: {0}\nGames won: {1}", playerTwoGlobalScore, playerTwoWins);
        }
        else 
        {
            Console.WriteLine("It's a tie!\nScore: {0}", playerOneGlobalScore);
        }

    }
}