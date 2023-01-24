 class validate
    {
        static void Main(string[] args)
        {
            string dateInput="26/02/2021";
            Console.WriteLine(IsValidDate(dateInput));
        }
        public static bool IsValidDate(string date)
        {
            DateTime tempObject;
            return DateTime.TryParse(date, out tempObject);
        }
    }
