namespace ErrorExeptionsLib
{
    public class ErrorExeptionsService
    {
        static string errorMessage = "Insert is wrong. Please, enter the number from 1 to 12";
        public static bool IsCorrectIntMonthValue(dynamic value)
        {
            if (value == null || value == 0)
            {
                Console.WriteLine(errorMessage);
                return false;
            }
            if (value.GetType() != typeof(int))
            {
                Console.WriteLine(errorMessage);
                return false;
            }
            if (value != null && (value < 1 || value > 12))
            {
                Console.WriteLine(errorMessage);
                return false;
            }

            return true;
        }
    }
}