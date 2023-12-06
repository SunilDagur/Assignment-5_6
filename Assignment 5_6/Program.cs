using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Outer try block - Start");

            
            try
            {
                Console.WriteLine("Inner try block - Start");

               
                throw new Exception("Exception in the inner try block");

                Console.WriteLine("Inner try block - End"); 
            }
            catch (Exception innerException)
            {
                
                Console.WriteLine($"Caught exception in the inner catch block: {innerException.Message}");
            }

            Console.WriteLine("Outer try block - End"); 
        }
        catch (Exception outerException)
        {
           
            Console.WriteLine($"Caught exception in the outer catch block: {outerException.Message}");
        }
    }
}
