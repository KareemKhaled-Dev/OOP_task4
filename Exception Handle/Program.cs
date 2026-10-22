namespace Exception_Handle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while(true)
            {
                Console.WriteLine("Please enter number or 0 to stop:");
                int number= Convert.ToInt32(Console.ReadLine());
                if(number == 0)
                {
                    break;
                }
                
                try
                {
                    if(numbers.Contains(number))
                    {
                        throw new Exception(" number must be no Dupicated");
                    }
                    else
                    {
                        numbers.Add(number);
                    }
                }catch(Exception e)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine(e.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.WriteLine("Finshed!");
                }

            }
        }
    }
}
