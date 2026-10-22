namespace Expection_Handle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StringName("Kareem"); 
                StringName("Try");//No Print in console


            } catch(Exception e)
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

        static void StringName(string input) {
            bool result = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    result = true;
                    break;
                }
            }
            if (result == false)
            {
                throw new Exception("the string must be contain vowels");
                 }
        }
    }
}