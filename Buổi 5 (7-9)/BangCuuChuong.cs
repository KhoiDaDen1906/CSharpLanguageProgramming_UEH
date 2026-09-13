internal partial class BangCuuChuong
{
    private static void Main1112(string[] args)
    {
        for (int i = 1 ; i <= 10; i ++ )
       { 
            for (int j = 1; j <=9; j ++)
            {
                System.Console.Write($"{j} x {i,2} = {i*j,2}     |     "); // {i,2} giúp căn lề qua phải 2 khoảng trống, muốn căn lề trái thì -2
            }
            System.Console.WriteLine();
       }
}       
}