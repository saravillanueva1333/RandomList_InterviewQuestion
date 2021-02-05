using System;
using System.Collections.Generic;

namespace RandomizeListNS
{
    public class RandomList
    {
        public static void Main(string[] args)
        {
            var result = MakeRandomList(13);
            Console.WriteLine(String.Join(",",result));

        }

        public static List<int> MakeRandomList(int userInput)
        {
            //Throw exception if input is negative
            if (userInput < 0)
                throw new ArgumentException("Input must be positive");

            //Build List of unique integers
            List<int> list = new List<int>();
            for(int i = 0; i < userInput; i++ ){
                list.Add(i);
            }

            //Now shuffle the list if more than 1 item
            if (userInput > 1)
                Shuffle(list);

            return list;
        }

        public static void Shuffle (List<int> orderedlist)
        {
            for(int i = 0; i < orderedlist.Count; i++)
            {
                //Generate random number and swap it with i within the list
                int randomNum = new Random().Next(orderedlist.Count);
                int temp = orderedlist[randomNum];
                orderedlist[randomNum] = orderedlist[i];
                orderedlist[i] = temp;
            }
        }
    }
}
