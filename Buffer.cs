using System;
using System.Collections.Generic;

namespace InterviewPrep
{
    // This is a class made to create a buffer for printing items in a sequence to the console
    // it contains a Handler method for handling new integers and a Printer method for writing the sequence out
    // properties: last (int), queue (queue of ints)
    public class Buffer
    {
        private int last;
        private List<int> queue = new List<int>();

        
        public static void Handler(int value)
        {
            // handle exception where first value is added
            if ( last == undefined )
            {
                Printer(value);
                last = value;
            }
            // check to see if the new value is next in sequence
            else if ( value == last + 1)
            {
                // if it is, print it and anything else in sequence in the queue
                Printer(value);
                last = value;
                while(queue[0] == last + 1)
                {
                    Printer(queue[0]);
                    last = queue[0];
                    queue.Remove(queue[0]);
                }
            }
            // otherwise, add it to the queue
            else
            {
                queue.Add(value);
                queue.Sort();
            }

            
        }

        public static void Printer(int item)
        {
            Console.WriteLine(item);
        }
    }
}