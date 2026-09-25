internal class TwoD_Arrays
{
// Create a program with following functions
// - Create an integer matrix N x M (N,M was prompted from user) randomly.
static int [,] Create_Random_NxM_Array(int row_num , int col_num) 
    {
        Random rnd = new Random();
        int[,] ma_tran_2D = new int[row_num , col_num];

        for (int i = 0 ; i < row_num ; i ++)
        {
            for (int j = 0 ; j < col_num ; j ++)
            {
                ma_tran_2D [i,j] = rnd.Next(1,100);
            }
        }
        return ma_tran_2D;
    }
    // - Print the matrix.
    static void Print_Matrix(int [,] ma_tran)
    {
        int row_num = ma_tran.GetLength(0);
        int col_num = ma_tran.GetLength(1);

        for (int i = 0 ; i < row_num ; i ++)
        {
            for (int j = 0 ; j < col_num ; j ++)
            {
                System.Console.Write(ma_tran[i,j] + "\t");
            }
            System.Console.WriteLine();
        }
    }
    // - Print the i.th row/column. (i was prompted from user).
    static void Print_Row_or_Col(int[,] ma_tran , int i)
    {
        int so_dong = ma_tran.GetLength(0);
        int so_cot = ma_tran.GetLength(1);
        if (i < so_dong)
        {
            System.Console.WriteLine($" The row {i} is: ");
            System.Console.Write("[");
            for (int j = 0 ; j < so_cot; j ++)
            {
                System.Console.Write(ma_tran[i,j] + " ");
            }
            System.Console.WriteLine("]");
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine($"The row {i} is not exist!");
            System.Console.WriteLine();
        }
        if (i < so_cot)
        {
            System.Console.WriteLine($"The column {i} is: ");
            System.Console.Write("[");
            for (int j = 0; j < so_dong; j ++)
            {
                System.Console.Write(ma_tran[j,i] + " ");
            }
            System.Console.Write("]");
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine($"The column {i} is not exist");
            System.Console.WriteLine();
        }
    }
    // Find the max value of the matrix.
    static int Max_Val_of_Matrix(int [,] ma_tran)
    {
        int so_dong = ma_tran.GetLength(0);
        int so_cot = ma_tran.GetLength(1);
        int max = ma_tran[0,0];

        for (int i = 0 ; i < so_dong; i ++ )
        {
            for (int j = 0 ; j < so_cot; j ++)
            {
                if (max < ma_tran[i,j])
                {
                    max = ma_tran[i,j];
                }
            }
        }
        return max;
    }
    // Find the min value of ith row/col of the matrix. 
    static void Find_Min_of_ith_RowandCol (int [,] ma_tran, int i)
    {
        int so_dong = ma_tran.GetLength(0);
        int so_cot = ma_tran.GetLength(1);

        if (i < so_dong)
        {
            int min_row = ma_tran[i,0];
            for (int j = 0 ; j < so_cot; j ++)
            {
                if (ma_tran[i,j] < min_row)
                {
                    min_row = ma_tran[i,j];
                }
            }
            System.Console.WriteLine($"The minimum value of the row {i} is: {min_row}");
        }
        else System.Console.WriteLine($"The row {i} is not exist!");

        if (i < so_cot)
        {
            int min_col = ma_tran[0,i];
            for (int j = 0 ; j < so_dong ; j ++)
            {
                if (ma_tran[j,i] < min_col)
                {
                    min_col = ma_tran[j,i];
                }
            }
            System.Console.WriteLine($"The minimum value of the column {i} is: {min_col}");
        }
        else System.Console.WriteLine($"The column {i} is not exist!");
        
    }

    // Transpose the matrix.
    static int [,] Tranpose_Matrix(int[,] ma_tran_goc)
    {
        int so_dong = ma_tran_goc.GetLength(0);
        int so_cot = ma_tran_goc.GetLength(1);

        int[,] ma_tran_chuyen_vi = new int[so_cot,so_dong];

        for (int i = 0 ; i < so_dong ; i ++)
        {
            for (int j = 0 ; j < so_cot ; j++)
            {
                ma_tran_chuyen_vi[j,i] = ma_tran_goc[i,j];
            }
        }
        return ma_tran_chuyen_vi;
    }
    // Print the main/secondary diagonal values of the matrix.(square maxtrix)
    static void Print_Diagonals(int[,] ma_tran)
    {
        int so_dong = ma_tran.GetLength(0);
        int so_cot = ma_tran.GetLength(1);

        if(so_dong != so_cot)
        {
            System.Console.WriteLine("This Matrix is not Square matrix!!");
            return;
        }

        System.Console.WriteLine("The main diagonal value is: ");
        System.Console.Write("[");
        for(int i = 0; i < so_dong; i ++)
        {
            System.Console.Write(ma_tran[i,i] + " ");
        }
        System.Console.WriteLine("]");

        System.Console.WriteLine("The secondary diagonal value is: ");
        System.Console.Write("[");
        for (int i = 0; i < so_dong ; i ++)
        {
            System.Console.Write(ma_tran[i,so_cot - 1 - i] + " ");
        }
        System.Console.Write("]");
    }
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of rows you want: ");
        int so_dong = int.Parse(Console.ReadLine() ?? "3");
        System.Console.WriteLine("Enter the number of columns you want: ");
        int so_cot = int.Parse(Console.ReadLine() ?? "3");


        // 1. khoi tao ma tran NxM ngau nhien
        int [,] ma_tran_ngau_nhien = Create_Random_NxM_Array(so_dong , so_cot);

        //2. In ra ma tran ngau nhien vua tao.
        Print_Matrix(ma_tran_ngau_nhien);

        // 3. in ra hang i va cot i.
        System.Console.WriteLine("Enter the index of rows and columns you want to create: ");
        int i = int.Parse(Console.ReadLine() ?? "1");
        Print_Row_or_Col(ma_tran_ngau_nhien,i);

        // 4. Tim gia tri max cua ma tran.
        int max_val = Max_Val_of_Matrix(ma_tran_ngau_nhien);
        System.Console.WriteLine($"The Maximum value of the matrix is: {max_val}");

        // 5. Tim min cua hang j va cot j.
         System.Console.WriteLine("Enter the index of the rows and columns you want to find min value: ");
        int j = int.Parse(Console.ReadLine() ?? "1");
        Find_Min_of_ith_RowandCol(ma_tran_ngau_nhien , j);

        // 6. Ma tran chuyen vi.
        int[,] ma_tran_chuyen_vi = Tranpose_Matrix(ma_tran_ngau_nhien);
        System.Console.WriteLine("Matrix after being tranposed is: ");
        Print_Matrix(ma_tran_chuyen_vi);

        // 7. In gia tri duong cheo chinh va duong cheo phu.
        Print_Diagonals(ma_tran_ngau_nhien);
    }
}