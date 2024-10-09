namespace Task101024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetMin<----******---->

            //int[] arr = { 23, 8, 85, 12, 10, 11 };
            //Console.WriteLine(GetMin(arr));

            //<-------*********------>
            Console.WriteLine("Cevrenin Sahesi");
            Console.WriteLine(GetArea(5));
            Console.WriteLine("Duzbucawlinin sahesi");
            Console.WriteLine(GetArea(5, 8));
            Console.WriteLine("Parelelipipedin sahesi");
            Console.WriteLine(GetArea(5, 6, 7));
            Console.WriteLine("Ucbucaq daxilindeki cevrenin sahesi");
            Console.WriteLine(GetArea(5, 6, 7, 8));


        }
        #region GetMin
        //public static int GetMin(int[] arr)
        //{
        //    int min = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //    }

        //    return min;
        //} 
        #endregion


        public static int GetArea(int r)
        {
            int p = 3;
            return p * r * r;
        }
        public static int GetArea(int a, int b)
        {
            return a * b;
        }
        public static int GetArea(int a, int b, int c)
        {
            return 2 * (a * b + c * b + a * c);
        }
        public static int GetArea(int a, int b, int c, int r)
        {
            return ((a + b + c) / 2) * r;
        }
    }
}

