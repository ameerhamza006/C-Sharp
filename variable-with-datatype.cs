 class Program
    {
        static void Main(string[] args)
        {
            // String for chracter this data type store only 1.50 mbs data
            String name = "Ameer Hamza";
            // int for numaric value this data type store only 2 bytes data
            int mobile = 0312345666;
            // float for short points value this data type store only 4 bytes data
            float marks = 12;
            // double for long points value this data type store only 8 bytes data
            double percent = 1243.6545;
            // var for all data type 
            var all = name + " = " + mobile + " = " + marks + " = " + percent; // + means concatinate

            //for print with line brack
            Console.WriteLine(name);
            Console.WriteLine(mobile);
            Console.WriteLine(marks);
            Console.WriteLine(percent);
            Console.WriteLine(all);

            //for all value in one line
            Console.Write(name);
            Console.Write(mobile);
            Console.Write(marks);
            Console.Write(percent);
           


            //for holding Console
            Console.ReadKey();

            

        }
    }
