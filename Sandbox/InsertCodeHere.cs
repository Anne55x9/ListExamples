﻿using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> aListOfInt = new List<int>();
            aListOfInt.Add(4);
            aListOfInt.Add(12);
            aListOfInt.Add(9);

            // Case 1
              Console.WriteLine("Case 1: Element with index 1 is {0}", aListOfInt[1]);

            // Case 2
             Console.WriteLine("Case 2: List contains {0} elements", aListOfInt.Count);
 
            aListOfInt.Add(5);
            aListOfInt.Add(22);

            // Case 3
             Console.WriteLine("Case 3: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.RemoveAt(0);

            // Case 4
             Console.WriteLine("Case 4: Element with index 3 is {0}", aListOfInt[3]);



            aListOfInt.Clear();
            aListOfInt.Add(14);
            aListOfInt.Add(87);
            aListOfInt.Add(62);
            aListOfInt.Add(21);
            aListOfInt.Add(40);
            aListOfInt.Add(3);

            // Case 5: Make some code that prints out 
            // all the elements in the list

            Console.WriteLine(" Case 5: The list contains {0} elements",aListOfInt.Count);



            // Case 6: Make some code that finds the 
            // sum of the elements in the list, and prints the result

            
            int totalSum = 0; 
            foreach (int Sum in aListOfInt)
            {
                totalSum = Sum + totalSum;
                Console.WriteLine(totalSum); 
            }


            // Case 7: Make some code that finds the 
            // average of the elements in the list, and prints the result
            // Tip: Think about how average is defined; then
            // you might reuse something from Case 6

            int average = 0;
            int totalsum = 0;
            foreach  (int Sum in aListOfInt)
            {
                totalsum = Sum + totalsum;
                average = totalsum / 6;
                Console.WriteLine(average);       
            }



            // [DIFFICULT]
            // Case 8: Make some code that finds the
            // smallest element in the list, and prints the result
            // Tip: Think in detail about how you would do this manually








            // The LAST line of code should be ABOVE this line
        }
    }
}
