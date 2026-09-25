internal class Array_Ex
{
    //Create a random integer values array, then create functions that:
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
    // 1. to calculate the average value of array elements.
    static float Average_Val_of_arrElement(int [] arr)
    {
        float sum = 0;
        float average_val;

        foreach (float v in arr)
        {
           sum += v; 
        }
        
        average_val = sum / arr.Length;
        return average_val;
    }
    static void Ex1()
    {
        System.Console.Write("Enter the length of the array you want: ");
        int n = int.Parse(Console.ReadLine() ?? "5");

        int [] arr = tao_mang_ngau_nhien(n); 
        
        in_ra_mang_ngau_nhien(arr);

        float trung_binh = Average_Val_of_arrElement(arr);

        System.Console.WriteLine($"The average of elements of the array is {trung_binh}");

    }
    // 2. to test if an array contains a specific value.
    static bool Check_Val(int [] arr ,int n)
    {
        for (int i = 0; i < arr.Length ; i ++)
        {
            if (arr[i] == n)
            {
                return true;
            }
        }
        return false;
    }
    static void Ex2()
    {
        System.Console.WriteLine("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine() ?? "10");
        System.Console.WriteLine("Enter a number you want: ");
        int n = int.Parse(Console.ReadLine() ?? "10");

        int [] arr = tao_mang_ngau_nhien(length);

        if (Check_Val(arr , n))
        {
            System.Console.WriteLine($"Yes! There is {n} in the array");
        }
        else System.Console.WriteLine($"Nah! There is not any {n} in the array");

        in_ra_mang_ngau_nhien(arr);
    }
    // 3. to find the index of an array element.
    static int Find_Index(int [] arr, int n)
    {
        for (int i = 0; i < arr.Length ; i ++)
        {
            if (arr[i] == n)
            {
                return i;
            }
        }
        return -1;
    }
    static void Ex3()
    {   
        System.Console.WriteLine("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine() ?? "10");
        System.Console.WriteLine("Enter a number to check its index in the array: ");
        int n = int.Parse(Console.ReadLine() ?? "10");

        int index;

        int [] mang = tao_mang_ngau_nhien(length);
        if (Check_Val(mang,n))
        {
            index = Find_Index(mang,n); 
            System.Console.WriteLine($"Found {n} at index {index}");
        }
        else System.Console.WriteLine($"There is no {n} in the array");
        in_ra_mang_ngau_nhien(mang);
    }
    
    // 4. to remove a specific element from an array.
    static int[] Remove_Specific_Element_FromArray(ref int [] arr , int n)
    {
        int location = Find_Index(arr, n);
        if (location == -1)
        {
            return arr;
        }

        for (int i = location ; i < arr.Length -1 ; i++)
        {
            arr[i] = arr[i+1]; 
        }
        Array.Resize(ref arr , arr.Length -1);

        return arr;
    }
    static void Ex4()
    {
        System.Console.WriteLine("Enter the length of the array you want: ");
        int length = int.Parse(Console.ReadLine() ?? "10");

        int [] mang = tao_mang_ngau_nhien(length);// tao mang moi random
        in_ra_mang_ngau_nhien(mang);

        System.Console.WriteLine("Enter the number you want to remove: ");
        int n = int.Parse(Console.ReadLine() ?? "10");

        if (Check_Val(mang,n))
        {
            mang = Remove_Specific_Element_FromArray(ref mang , n);
            System.Console.WriteLine($"Array after removing {n}: ");
            System.Console.Write("The new array is: [ ");

            foreach (int v in mang)
                {
                    System.Console.Write( v + " ");
                }
                    System.Console.WriteLine("]");
        }
        else System.Console.WriteLine($"There is no {n} in the array to remove!!!");
    }
    // 5. to find the maximum and minimum value of an array.
    static int[] Find_Min_Max_inArray(int [] arr)
    {
        int max = arr[0];
        int min = arr[0];
        for (int i = 1 ; i < arr.Length ; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return new int[]  {min, max};
    }
    static void Ex5()
    {
        System.Console.WriteLine("Enter the length of the array you want: ");
        int length = int.Parse(Console.ReadLine() ?? "10");

        int [] mang = tao_mang_ngau_nhien(length);// tao mang moi random
        in_ra_mang_ngau_nhien(mang);

        int [] min_max = Find_Min_Max_inArray(mang);
        System.Console.Write("Min and Max of the array are: [ ");

            foreach (int v in min_max)
                {
                    System.Console.Write( v + " ");
                }
                    System.Console.WriteLine("] respectively!!!");
    }
    // 6. to reverse an array of integer values.
    static int [] Reverse_Array(int [] arr)
    {
        int temp;
        for (int i = 0 ; i < arr.Length / 2 ; i++)
        {
            temp = arr[i]; 
            arr[i] = arr[arr.Length - 1 - i]; 
            arr[arr.Length - 1 - i] = temp; 
        }
        return arr;
    }
    static void Ex6()
    {
        System.Console.WriteLine("Enter the length of the array you want: ");
        int length = int.Parse(Console.ReadLine() ?? "10");

        int [] mang = tao_mang_ngau_nhien(length);// tao mang moi random
        in_ra_mang_ngau_nhien(mang);

        int [] reverse_mang = Reverse_Array(mang);
        System.Console.Write("The array after being reversed is : [ ");

            foreach (int v in reverse_mang)
                {
                    System.Console.Write( v + " ");
                }
                    System.Console.WriteLine("]");
        
    }
    // 7. to find duplicate values in an array of values.
    static void Find_Duplicate_Val(int [] arr)
    {
        int count_so_luong = 0;
        string chuoi_gia_tri = "";
        string chuoi_so_lan = "";
        for (int i = 0 ; i < arr.Length ; i ++)
        {
            bool da_tung_xuat_hien = false;
            for (int k = 0; k < i ; k++)
            {
                if (arr[k] == arr[i])
                {
                 da_tung_xuat_hien = true;
                 break;   
                }
            }
            if (da_tung_xuat_hien == true)
            {
                continue;
            }
            int so_lan_lap = 1; 
            for (int j = i + 1 ; j < arr.Length ; j ++ )
            {
                if (arr[i] == arr [j])
                {
                    so_lan_lap++;
                }
            }
            if (so_lan_lap > 1)
            {
                count_so_luong ++;
                chuoi_gia_tri += arr[i] + " ";
                chuoi_so_lan += so_lan_lap + " ";

            }
        }
        if (count_so_luong > 0)
        {
            System.Console.WriteLine($"The Array has {count_so_luong} duplicated values those are {chuoi_gia_tri} appear {chuoi_so_lan} times, respectively!");
        }
        else System.Console.WriteLine("There is no any duplicated value!");
    }
    static void Ex7()
    {
      System.Console.WriteLine("Enter the length of the array you want: ");
        int length = int.Parse(Console.ReadLine() ?? "10");

        int [] mang = tao_mang_ngau_nhien(length);// tao mang moi random
        in_ra_mang_ngau_nhien(mang);

        Find_Duplicate_Val(mang);
    }
    // 8. to remove duplicate elements from an array.
    static int [] Remove_Duplicated_Val(int [] arr)
    {
        int k = 0; //khoi tao bien goc (so luong phan tu cua mang sau khi xoa cac ptu lap).
        for (int i = 0 ; i < arr.Length ; i ++) // quet tat ca cac phan tu trong mang.
        {
            bool da_tung_xuat_hien = false;
            for (int j = 0 ; j < k; j ++) // thay vi quet tat ca ptu trong qua khu, chi can quet khi thay 1 ptu bang nhau thi ngung.
            {                               // tiet kiem thoi gian quet.
                if (arr[j] == arr [i])
                {
                    da_tung_xuat_hien = true;
                    break;
                }
            }    
                if (da_tung_xuat_hien == true)// neu thay da xuat hien roi thi bo qua luon.
                {
                    continue;
                }
                arr[k] = arr [i];// neu thay chua xuat hien thi ghi de len.
                k ++;
        }        
            int [] mang_sau_khi_loc = new int[k]; // tao mang moi dai dung k phan tu.
            for (int i = 0; i < k; i ++)
            {
                mang_sau_khi_loc[i] = arr[i]; // chep tu mang cu sang mang moi.
            }
        return mang_sau_khi_loc;
    }
    static void Ex8()
    {
        System.Console.WriteLine("Enter the length of the array you want: ");
        int length = int.Parse(Console.ReadLine() ?? "10");

        int [] mang = tao_mang_ngau_nhien(length);// tao mang moi random
        in_ra_mang_ngau_nhien(mang);

        int [] mang_loc_roi = Remove_Duplicated_Val(mang);

        System.Console.Write("The array after being removed duplicated values is : [ ");

            foreach (int v in mang_loc_roi)
                {
                    System.Console.Write( v + " ");
                }
                    System.Console.WriteLine("]");


    }
    private static void Main54321(string[] args)
    {
        // Ex1();
        // System.Console.WriteLine("Press any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex2();
        // System.Console.WriteLine("Press any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex3();
        // System.Console.WriteLine("Press any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex4();
        // System.Console.WriteLine("Press any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex5();
        // System.Console.WriteLine("Press any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex6();
        // System.Console.WriteLine("Press any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex7();
        // System.Console.WriteLine("Press any key to move to the next Ex: ");
        // Console.ReadKey();

        Ex8();
        System.Console.WriteLine("Press any key to move to the next Ex: ");
        Console.ReadKey();
    }
}