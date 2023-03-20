namespace Homework2
{
public static class Program
{
    public static void Main()
    {
        Console.WriteLine ("Введите длину массива");
        var valueArray = ReadInt ();
        if (valueArray > 0) //
        {
            var array = new int [valueArray];  //память под массив
            Console.WriteLine ("Введите значения массива"); //заполнение массива
            var Max = 0;
            var secMax = 0;
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = ReadInt ();
                if (array[i] > Max)
                {
                secMax = Max;
                Max = array[i];
                }
                if (array[i] < Max && array[i]>secMax)
                {
                secMax = array[i];
                }
              }
            Console.WriteLine ("Второе масимальное число - это " + secMax );
        }
        else
        {
            Console.WriteLine ("Длина массива должна быть больше нуля");
        }
       
    }

        // считывание размера и элементов массива с консоли
        private static int ReadInt() 
        {
            var value = Console.ReadLine ();
            try
            {
                return Int32.Parse(value);
            }
            catch (System.FormatException)
            {   
                Console.WriteLine ("Для ввода используйте цифру + Enter");
                throw;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine ("Введите число в пределах от -2147483648 до 2147483648");
                throw;
            }
            
        }
    }

}
