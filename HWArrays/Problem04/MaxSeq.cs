using System;


namespace Problem04
{
    class MaxSeq
    {
        static void Main(string[] args)
        {
            Start:
            try
            {
                //Console.WriteLine("Enter size of arrays");
                string input = Console.ReadLine();

                string[] inputS = input.Split(',');

                int[] data = new int[inputS.Length];
                
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = int.Parse(inputS[i]);
                }
                int count=1;
                int countM=0; //max count
                int index=0; //index of last element of max count
                for(int i=1; i<data.Length; i++)
                {
                    if (data[i] == data[i - 1])
                    {
                        count++;
                        
                        if (count > countM)
                        {
                            countM = count;
                            index = i; //change the index
                        }
                    }
                    else
                    {
                        count = 1;  //reset the count
                    }
                }
                Console.WriteLine("C:"+countM);
                for(int i=0; i<countM; i++)
                {
                    Console.WriteLine(data[index -i]); //work back from last element in sequence
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }

            Console.WriteLine("If you wish to continue press [y].");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
