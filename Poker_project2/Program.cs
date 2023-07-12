using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random();
            int playerMoney = 1000;
            int botMoney = 1000;
            int playerPoints = 0;
            int botPoints = 0;

            //pair
            int pair = 20;
            bool pairBool = false;

            // Two pairs
            int pairs2 = 40;
            var twoPairs = new List<int> { };


            // Four of a kind
            int fourK = 140;
            bool fourBool = false;

            // Three of a kind
            int threeK = 60;
            bool threeBool = false;

            // Straight
            int straight = 80;
            var straightTable = new List<int> { };

            // Flush
            int flush = 100;

            // Full House
            int fullHouse = 120;

            var pairCards = new List<int> { };
            var threeCards = new List<int> { };

            // Straight flush
            int straightFlush = 160;
            bool straightFlushBool = false;

            var names = new List<string> {
                                            "Spades 2", "Clubs 2", "Hearts 2", "Diamonds 2",
                                            "Spades 3", "Clubs 3", "Hearts 3", "Diamonds 3",
                                            "Spades 4", "Clubs 4", "Hearts 4", "Diamonds 4",
                                            "Spades 5", "Clubs 5", "Hearts 5", "Diamonds 5",
                                            "Spades 6", "Clubs 6", "Hearts 6", "Diamonds 6",
                                            "Spades 7", "Clubs 7", "Hearts 7", "Diamonds 7",
                                            "Spades 8", "Clubs 8", "Hearts 8", "Diamonds 8",
                                            "Spades 9", "Clubs 9", "Hearts 9", "Diamonds 9",
                                            "Spades 10","Clubs 10","Hearts 10","Diamonds 10",
                                            "Spades J", "Clubs J", "Hearts J", "Diamonds J",
                                            "Spades Q", "Clubs Q", "Hearts Q", "Diamonds Q",
                                            "Spades K", "Clubs K", "Hearts K", "Diamonds K",
                                            "Spades A", "Clubs A", "Hearts A", "Diamonds A"};


            int handIndex1 = randm.Next(names.Count);
            var hand1 = names[handIndex1];
            names.RemoveAt(handIndex1);
            int handIndex2 = randm.Next(names.Count);
            var hand2 = names[handIndex2];
            names.RemoveAt(handIndex2);
            System.Console.WriteLine("You have: " + hand1 + " And: " + hand2);

            System.Console.WriteLine("Press enter to continue");
            string input = Console.ReadLine();
            if (input.Equals("call", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Called");
            }

            int index1 = randm.Next(names.Count);
            var table1 = names[index1];
            System.Console.WriteLine("First card: " + table1);
            names.RemoveAt(index1);

            int index2 = randm.Next(names.Count);
            var table2 = names[index2];
            System.Console.WriteLine("Second card: " + table2);
            names.RemoveAt(index2);

            int index3 = randm.Next(names.Count);
            var table3 = names[index3];
            System.Console.WriteLine("Third card: " + table3);
            names.RemoveAt(index3);

            System.Console.WriteLine("Press enter to continue");
            System.Console.ReadLine();

            int index4 = randm.Next(names.Count);
            var table4 = names[index4];
            System.Console.WriteLine("Fourth card: " + table4);
            names.RemoveAt(index4);

            System.Console.WriteLine("Press enter to continue");
            System.Console.ReadLine();

            int index5 = randm.Next(names.Count);
            var table5 = names[index5];
            System.Console.WriteLine("Fifth card: " + table5);
            names.RemoveAt(index5);

            var table = new List<string>
            {
                hand1, hand2, table1, table2, table3, table4, table5
            };

            var tableFlushPata = new List<int> { };
            var tableFlushHertta = new List<int> { };
            var tableFlushRisti = new List<int> { };
            var tableFlushRuutu = new List<int> { };

            string num = "";

            for (int i = 2; i < 15; i++)
            {
                if (i == 14)
                {
                    num = "A";
                }
                else if (i == 11)
                {
                    num = "J";
                }
                else if (i == 12)
                {
                    num = "Q";
                }
                else if (i == 13)
                {
                    num = "K";
                }
                else
                {
                    num = "" + i;
                }
                // Flush
                if (table.Contains("Spades " + num))
                {
                    tableFlushPata.Add(i);
                    straightTable.Add(i);
                }
                if (table.Contains("Hearts " + num))
                {
                    tableFlushHertta.Add(i);
                    straightTable.Add(i);
                }
                if (table.Contains("Diamonds " + num))
                {
                    tableFlushRuutu.Add(i);
                    straightTable.Add(i);
                }
                if (table.Contains("Clubs " + num))
                {
                    tableFlushRisti.Add(i);
                    straightTable.Add(i);
                }

                // Pair

                if (table.Contains("Spades " + num) && table.Contains("Clubs " + num))
                {
                    playerPoints = i + pair;
                    pairBool = true;
                    twoPairs.Add(i);
                    pairCards.Add(i);
                }
                if (table.Contains("Spades " + num) && table.Contains("Hearts " + num))
                {
                    playerPoints = i + pair;
                    pairBool = true;
                    twoPairs.Add(i);
                    pairCards.Add(i);
                }
                if (table.Contains("Spades " + num) && table.Contains("Diamonds " + num))
                {
                    playerPoints = i + pair;
                    pairBool = true;
                    twoPairs.Add(i);
                    pairCards.Add(i);
                }
                if (table.Contains("Clubs " + num) && table.Contains("Hearts " + num))
                {
                    playerPoints = i + pair;
                    pairBool = true;
                    twoPairs.Add(i);
                    pairCards.Add(i);
                }
                if (table.Contains("Diamonds " + num) && table.Contains("Hearts " + num))
                {
                    playerPoints = i + pair;
                    pairBool = true;
                    twoPairs.Add(i);
                    pairCards.Add(i);
                }
                if (table.Contains("Clubs " + num) && table.Contains("Diamonds " + num))
                {
                    playerPoints = i + pair;
                    pairBool = true;
                    twoPairs.Add(i);
                    pairCards.Add(i);
                }
                // Three of a kind


                if (table.Contains("Spades " + num) && table.Contains("Clubs " + num) && table.Contains("Hearts " + num))
                {
                    playerPoints = i + threeK;
                    threeBool = true;
                    threeCards.Add(i);
                }
                if (table.Contains("Spades " + num) && table.Contains("Diamonds " + num) && table.Contains("Hearts " + num))
                {
                    playerPoints = i + threeK;
                    threeBool = true;
                    threeCards.Add(i);
                }
                if (table.Contains("Spades " + num) && table.Contains("Clubs " + num) && table.Contains("Diamonds " + num))
                {
                    playerPoints = i + threeK;
                    threeBool = true;
                    threeCards.Add(i);
                }
                if (table.Contains("Hearts " + num) && table.Contains("Clubs " + num) && table.Contains("Diamonds " + num))
                {
                    playerPoints = i + threeK;
                    threeBool = true;
                    threeCards.Add(i);
                }

                // Four of a kind

                if (table.Contains("Spades " + num) && table.Contains("Clubs " + num) && table.Contains("Hearts " + num) && table.Contains("Diamonds " + num))
                {
                    fourBool = true;
                    playerPoints = i + fourK;
                }

            }
            // Pair
            if (pairBool)
            {
                playerPoints = pair + pairCards.Max();
            }
            // Two pairs
            if (twoPairs.Count >= 1)
            {
                int twoPairsMax = twoPairs.Max();
                int twoPairsMin = twoPairs.Min();
                if (twoPairs.Count >= 2 && twoPairsMax != twoPairsMin)
                {
                    playerPoints = pairs2 + twoPairsMax;
                    Console.WriteLine("Two Pairs");

                }
            }
            // Three of a kind
            if (threeBool)
            {
                playerPoints = threeK + threeCards.Max();
            }

            // Straight
            foreach (int o in straightTable)
            {

                if (straightTable.Contains(o) && straightTable.Contains(o + 1) && straightTable.Contains(o + 2)
                                                        && straightTable.Contains(o + 3) && straightTable.Contains(o + 4))
                {
                    Console.WriteLine("Straight");
                    playerPoints = straight + o;
                }
                else
                {
                    // No straight, do nothing
                }
            }

            // Flush & Straight flush
            if (tableFlushPata.Count >= 1)
            {
                int flushPata = tableFlushPata.Max();
                if (tableFlushPata.Count >= 6)
                {
                    foreach (int o in tableFlushPata)
                    {
                        if (tableFlushPata.Contains(o) && tableFlushPata.Contains(o + 1) && tableFlushPata.Contains(o + 2)
                                                       && tableFlushPata.Contains(o + 3) && tableFlushPata.Contains(o + 4))
                        {
                            straightFlushBool = true;
                            Console.WriteLine("Straight Flush");
                            playerPoints = straightFlush;
                        }
                        else
                        {
                            playerPoints = flush + flushPata;
                            Console.WriteLine("Flush");
                        }
                    }

                }
            }
            if (tableFlushRisti.Count >= 1)
            {
                int flushRisti = tableFlushRisti.Max();
                if (tableFlushRisti.Count >= 6)
                {
                    foreach (int o in tableFlushRisti)
                    {
                        if (tableFlushRisti.Contains(o) && tableFlushRisti.Contains(o + 1) && tableFlushRisti.Contains(o + 2)
                                                       && tableFlushRisti.Contains(o + 3) && tableFlushRisti.Contains(o + 4))
                        {
                            straightFlushBool = true;
                            Console.WriteLine("Straight Flush");
                            playerPoints = straightFlush;
                        }
                        else
                        {
                            playerPoints = flush + flushRisti;
                            Console.WriteLine("Flush");
                        }
                    }

                }
            }
            if (tableFlushHertta.Count >= 1)
            {
                int flushHertta = tableFlushHertta.Max();
                if (tableFlushHertta.Count >= 6)
                {
                    foreach (int o in tableFlushHertta)
                    {
                        if (tableFlushHertta.Contains(o) && tableFlushHertta.Contains(o + 1) && tableFlushHertta.Contains(o + 2)
                                                       && tableFlushHertta.Contains(o + 3) && tableFlushHertta.Contains(o + 4))
                        {
                            straightFlushBool = true;
                            Console.WriteLine("Straight Flush");
                            playerPoints = straightFlush;
                        }
                        else
                        {
                            playerPoints = flush + flushHertta;
                            Console.WriteLine("Flush");
                        }
                    }

                }
            }
            if (tableFlushRuutu.Count >= 1)
            {
                int flushRuutu = tableFlushRuutu.Max();
                if (tableFlushRuutu.Count >= 6)
                {
                    foreach (int o in tableFlushRuutu)
                    {
                        if (tableFlushRuutu.Contains(o) && tableFlushRuutu.Contains(o + 1) && tableFlushRuutu.Contains(o + 2)
                                                       && tableFlushRuutu.Contains(o + 3) && tableFlushRuutu.Contains(o + 4))
                        {
                            straightFlushBool = true;
                            Console.WriteLine("Straight Flush");
                            playerPoints = straightFlush;
                        }
                        else
                        {
                            playerPoints = flush + flushRuutu;
                            Console.WriteLine("Flush");
                        }
                    }

                }
            }

            // Full house
            if (pairCards.Count >= 1 && threeCards.Count >= 1)
            {
                int threeMax = threeCards.Max();
                int pairMin = pairCards.Min();

                if (pairBool && threeBool && pairMin != threeMax)
                {
                    playerPoints = threeMax + fullHouse;
                    Console.WriteLine("Full House");
                }
            }
            // Four of a kind
            if (fourBool)
            {
                Console.WriteLine("Four of a kind");
                playerPoints = fourK;
            }
            //  Straight Flush
            if (straightFlushBool)
            {
                Console.WriteLine("Straight Flush");
                playerPoints = straightFlush;
            }

            Console.WriteLine("You have: " + playerPoints + " points");
            Console.WriteLine("Press enter to close...");
            System.Console.ReadLine();
        }
    }
}

