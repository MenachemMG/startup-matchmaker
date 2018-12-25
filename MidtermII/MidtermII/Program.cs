using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermII
{
    class Program
    {
        static void Main(string[] args)
        {

            // FILL IN YOUR NAME BELOW
            // Menachem Greenberg

            // The class "Speeches.cs" has the following 8 public properties:
            // 1) Churchill1 - All of the words of Churchill's Address to Congress as an IEnumerable<String>
            // 2) Churchill2 - All of the words of Churchill's Fifty Years Hence speech as an IEnumerable<String>
            // 3) Churchill3 - All of the words of Churchill's Invasion of France speech as an IEnumerable<String>
            // 4) Lincoln1 - All of the words of Lincoln's House Divided speech as an IEnumerable<String>
            // 5) Lincoln2 - All of the words of Lincoln's Address at Independence Hall as an IEnumerable<String>
            // 6) Lincoln3 - All of the words of Lincoln's Second Innagural Address as an IEnumerable<String>
            // 7) ChurchillSpeeches - All of the Churchill Speeches' words as an IEnumerable<IEnumerable<String>>
            // 8) LincolnSpeeches - All of the Lincoln Speeches' words as an IEnumerable<IEnumerable<String>>
            // 
            // Fill in code as instructed to answer the questions below. Use only these 8 variables unless the
            // instructions indicate you should create a new data structure. This test is only on extension methods,
            // do not use any LINQ queries in the other format (from w in words, etc.) or other means for answering
            // the questions. All questions that ask for display must have output, some have the output statement(s)
            // already entered for you, others do not.


            // Question 1: (6 points)
            // Did Churchill's second speech contain the word "perhaps"?

            var q1 = Speeches.Churchill2.Distinct().Contains("perhaps");// FILL IN
            Console.WriteLine($"Answer 1: {q1}");

            Console.WriteLine();

            // Question 2: (6 points)
            // Did Churchill's second speech contain any words that start with "sh" and end with "p" (i.e. "sharp")?

            var q2 = Speeches.Churchill2.Any(s => s.StartsWith("sh") && s.EndsWith("p"));// FILL IN
            Console.WriteLine($"Answer 2: {q2}");

            Console.WriteLine();

            // Question 3: (8 points)
            // How many times did Lincoln use the word "united" in his third speech?

            var q3 = Speeches.Lincoln3.Where(s => s == "united").Count(); // FILL IN
            Console.WriteLine($"Answer 3: {q3}");

            Console.WriteLine();

            // Question 4: (9 points)
            // Display the lengths of all of the words in Lincoln's second speech (the answer will be a series of ints, 3, 9, 7, ...)

            var q4 = Speeches.Lincoln2.Select(s => s.Length).ToList();// FILL IN

            q4.ForEach(s2 => Console.Write(s2 + ", "));

            Console.WriteLine();

            // Question 5: (11 points)
            // Display the lengths of all of the words from all of Lincoln's speeches (series of ints like the previous question)

            var q5 = Speeches.LincolnSpeeches.SelectMany(s => s).Select(s => s.Length).ToList();// FILL IN

            q5.ForEach(s => Console.Write(s + ", "));

            Console.WriteLine();

            // Question 6: (12 points)
            // Group all of the words from Churchills's first speech by their first letter, then 
            // display the number of words that start with each letter of the alphabet. Hint: in C# you can treat a string
            // as if it were an array and just access its letters with indexes, for example myWord[3].
            // Display the answers in alphabetical order.

            var q6 = Speeches.Churchill1.GroupBy(s => s[0]).OrderBy(s2 => s2.Key);// FILL IN

            foreach (var group in q6)
            {
                Console.WriteLine($"{group.Key} : {group.Count()}");
            }

            Console.WriteLine();

            // Question 7: (6 points)
            // What is the total number of letters in all words in Lincoln's first speech?

            var q7 = Speeches.Lincoln1.SelectMany(s => s).Count();// FILL IN
            Console.WriteLine($"Answer 6: {q7}");

            Console.WriteLine();

            // Question 8: (8 points)
            // Display all of the words in Lincoln's first speech that are also in Churchill's first speech,
            // For this question, use only LINQ extension methods, no other methods, and also
            // do not use the Contains method.

            var q8 = Speeches.Lincoln1.Where(s => Speeches.Churchill1.Any(s2 => s == s2));// FILL IN
            foreach (var s in q8)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

                     // Question 9: (8 points)
                     // Display all of the words in Churchill's third speech that are NOT in his second speech
                     // For this question, use only LINQ extension methods, no other methods, and also
                     // do not use the Contains method.

                     var q9 = // FILL IN

    
                 Console.WriteLine();

                     // Question 10: (10 points)
                     // How many words in Lincoln's second speech appear more than 3 times in Churchill's first speech

                     var q10 = // FILL IN
                    Console.WriteLine($"Answer 9: {q10}");

                     Console.WriteLine();
            // Question 11: (9 points)
            // Write code that will use the ForEach extension method to display all of the words in Lincoln's
            // third speech that begin with 'w'. You may have to create a new data structure for this.
            // Remember, do NOT use a for each loop, use the ForEach extension method.

            // FILL IN
            List<String> wList = Speeches.Lincoln3.Where(s => s.StartsWith("w")).ToList();
            wList.ForEach(Console.WriteLine);
                     Console.WriteLine();

                     // Question 12: (12 points)
                     // First, create a new List<String> that has all of the words of all of Lincoln's and Churchill's speeches combined.
                     // The list should NOT contain duplicates.

                     // FILL IN
                     List<String> list = Speeches.ChurchillSpeeches.SelectMany(s => s).Union(Speeches.LincolnSpeeches.SelectMany(s => s)).Distinct().ToList();

            // Now create two separate data structures based on the list you created, one that uses
            // deferred execution so that the results will change every time it is accessed, another
            // that does NOT use deferred execution so that its results stay the same. These variables
            // should contain only the words that are 5 letters or more:

                    // FILL IN
                    var list1 = list.Where(s => s.Length >= 5).ToList();
                    var list2 = list.Where(s => s.Length >= 5);

            // Display the number of items in each collection:
            Console.WriteLine(list1.Count());
            Console.WriteLine(list2.Count());

            // FILL IN

            // Modify AllWords so that you remove any words that start with 't'
            // (BE CAREFUL TO MODIFY IT AND NOT REASSIGN IT)
            list.RemoveAll(s => s.StartsWith("t"));
            // FILL IN

            // Display the effect of this change by showing the number of items in each collection again:
            Console.WriteLine(list1.Count());
            Console.WriteLine(list2.Count());
            // FILL IN

            Console.WriteLine("Any key to exit...");
            Console.ReadKey();
        }
    }
}
