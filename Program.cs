internal class Program
{
    private static void Main(string[] args)
    {
        /* string myName = "Aaqib Ali";
         Console.WriteLine(myName[3]);
         Console.WriteLine(myName.IndexOf("a"));
         Console.WriteLine(myName.Length);*/



        /*var names=new List<string> { "<name>", "Ana", "Felipe" };
        foreach (string name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }*/


        /*var names = new List<string> { "<names>", "Ana", "Felipe" };
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"Hello {names[i].ToUpper()}!");
        }*/

        /* var names = new List<string> { "<names>", "Scott", "kendra" };
         names.Add("Maria");
         names.Add("Bill");
         names.Remove("Scott");
         foreach(var name in names)
         {
             Console.WriteLine(name);
         }
         Console.WriteLine(names[1]);*/


        // Sort, Searrch And Index Lists

        /* var names = new List<string> { "Weird", "Scott", "Kendra" };
         names.Add("Maria");
         names.Add("Bill");
         names.Remove("Scott");
         foreach(var name in names)
         {
             Console.WriteLine(name);
         }

         var index = names.IndexOf("Scott");
         if (index == -1)
         {
             Console.WriteLine($"When an atom is not found, index of returns {index} ");
         }
         else
         {
             Console.WriteLine($"The name {names[index]} is at index {index}");
         }*/





        // List of other Types
        // Fibonacci Numbers = Algorthm ---(1,1,2,3,5,8,13)
        var fibonacciNumbers = new List<int> { 1, 1 };
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
        fibonacciNumbers.Add(previous + previous2);
        foreach(var item in fibonacciNumbers)
        {
            Console.WriteLine(item);
        }




    }
}