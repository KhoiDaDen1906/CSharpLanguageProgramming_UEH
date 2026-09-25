internal class Al_Sing_Dim_Arr
{
    static int [] tao_mang_ngau_nhien(int n)
    {
        Random rnd = new Random();
        int [] arr = new int [n];

        for ( int i = 0 ; i < n ; i ++)
        {
            arr[i] = rnd.Next(1,100);
        }
        return arr;
    }
    static void in_ra_mang_ngau_nhien(int [] arr)
    {
        System.Console.Write("The created random array is: [ ");

        foreach (int v in arr)
        {
            System.Console.Write( v + " ");
        }
        System.Console.WriteLine("]");
    }
    //Create a C# program that
    //1. requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
    static int [] Bubble_Sort_Algorithm(int [] arr)
    {
        for (int i = 0; i < arr.Length ; i ++)
        {
            for (int j = i + 1; j < arr.Length ; j++)
            {
                if (arr[j] < arr[i])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return arr;
    }
    static void Ex1()
    {
        System.Console.WriteLine("Enter the length of the array you want: ");
        int length = int.Parse(Console.ReadLine() ?? "10");

        int [] mang = tao_mang_ngau_nhien(length);// tao mang moi random
        in_ra_mang_ngau_nhien(mang);

        int [] mang_sap_xep = Bubble_Sort_Algorithm(mang);

        System.Console.Write("The array after being sorted is: [");

            foreach (int v in mang_sap_xep)
                {
                    System.Console.Write( v + " ");
                }
                    System.Console.WriteLine("]");
    }
    //2. Request a sentence from the user, then ask to enter a word. 
    // Search if the word appears in the phrase using the linear search algorithm.
    static void Ex2()
    {
        System.Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine() ?? " I am a student of UEH";
        System.Console.WriteLine(" Enter a word you want to check: ");
        string word_check = Console.ReadLine() ?? "student";

        word_check = word_check.ToLower(); // chuyen chu hoa ve chu thuong

        bool co_xuat_hien = false;

        string[] mang_cac_tu_trong_cau = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }); // cat ra cac ky tu dac biet

        for (int i = 0 ; i < mang_cac_tu_trong_cau.Length ; i ++)
        {
               if (word_check == mang_cac_tu_trong_cau[i])
                {
                    co_xuat_hien = true;
                    break;
                } 
        }
        if (co_xuat_hien == true)
        {
            System.Console.WriteLine($"There is '{word_check}' in the sentence!");
        }
        else System.Console.WriteLine($"There is no '{word_check}' in the sentence");
    }


    private static void Main321(string[] args)
    {
        // Ex1();
        // System.Console.WriteLine("Press any key to move to the next Ex: ");
        // Console.ReadKey();

        Ex2();
        System.Console.WriteLine("Press any key to move to the next Ex: ");
        Console.ReadKey();
    }
}