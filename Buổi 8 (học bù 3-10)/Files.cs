using System.IO;
internal class Files
{
//     Write a program in C# Sharp
// 1. to create a blank file on the disk.
static void Ex1_Create_Blank_file()
    {
        string path = "/Users/mrthanh/Desktop/first_blank_file.txt";
        File.Create(path).Close();
        System.Console.WriteLine("First blank file has been created!");
    }
// 2. to remove a file from the disk.
static void Ex2_RemoveFile_FromDisk()
    {
        string path = "/Users/mrthanh/Desktop/first_blank_file.txt";
        bool exist = File.Exists(path);

        if (exist)
        {
            File.Delete(path);
            System.Console.WriteLine("File has been removed!");
        }
        else
        {
            System.Console.WriteLine("File does not exist!");
        }
    }
// 3. to create a file and add some text.
static void Ex3_Create_file_AddText()
    {
        string path = "/Users/mrthanh/Desktop/Blanks_file_for_ex3.txt";
        File.WriteAllText(path, "Tran Dang Khoi");

        System.Console.WriteLine("File has been succesfully created with contents inside!");

    }
// 4. create a text file and read it.
static void Ex4_Create_File_And_Read()
    {
        string path = "/Users/mrthanh/Desktop/Ex4_Create_file_and_read.txt";
        File.WriteAllText(path, "My name is Tran Dang Khoi, I'm currently a surphmore of UEH, majoring in Data Science!");
        string read_text = File.ReadAllText(path);
        System.Console.WriteLine($"The content in the file is: {read_text}");
    }
// 5. to create a file and write an array of strings to the file.
static void Ex5_Write_Array_to_File()
    {
        string path = "/Users/mrthanh/Desktop/Ex5_Write_Array_to_File.txt";
        string [] mang_chuoi_subjects = {"Discrete Math", "Database", "DSA", "Based Programming"};
        File.WriteAllLines(path, mang_chuoi_subjects);
        System.Console.WriteLine("File has been succesfully created!");
    }
// 6. to append some text to an existing file.
static void Ex6_Append_text()
    {
        string path = "/Users/mrthanh/Desktop/Ex5_Write_Array_to_File.txt"; // reuse path in Ex5.
        string [] extra_subjects = {"English", "Machine Learning"};
        File.AppendAllLines(path, extra_subjects);
        System.Console.WriteLine("New subjects have been added!");
    }
// 7. to create and copy the file to another name and display the content.
// 8. create a file and move it into the same directory with another name.
static void Ex7_Ex8_Copy_And_Move()
    {
        string original_path = "/Users/mrthanh/Desktop/Ex5_Write_Array_to_File.txt"; // reuse path in Ex6.
        string copied_file = "/Users/mrthanh/Desktop/Ex7_Copied_File.txt";
        File.Copy(original_path, copied_file);
        string moved_file = "/Users/mrthanh/Desktop/Ex8_Moved_File.txt";
        File.Move(original_path, moved_file);
        System.Console.WriteLine("File has been copied and moved to another file .txt!");
    }
// 9. read the first line of a file.
static void Ex9_Read_first_Line_Of_File()
    {
        string path = "/Users/mrthanh/Desktop/Ex8_Moved_File.txt"; // file Ex5 moved ---> Ex8
        string [] arr_contents = File.ReadAllLines(path);
        System.Console.WriteLine($"First line of the file is: {arr_contents[0]}");
    }
// 10. to create and read the last line of a file.
static void Ex10_CreateAndRead_LastLine()
    {
        string path = "/Users/mrthanh/Desktop/Ex8_Moved_File.txt";
        string [] arr_contents = File.ReadAllLines(path);

        if (arr_contents.Length > 0)
        {
            string last_line = arr_contents[arr_contents.Length -1];
            System.Console.WriteLine($"The last line of the file is: {last_line}");
        }
        else System.Console.WriteLine("File is empty!");
    }
// 11. create and read the last n lines of a file.
static void Ex11_Read_n_last_lines_of_file()
    {
        System.Console.WriteLine("Enter the number of last lines you want to read: ");
        int n = int.Parse(Console.ReadLine() ?? "2");
        string path = "/Users/mrthanh/Desktop/Ex8_Moved_File.txt"; 
        string [] arr_contents = File.ReadAllLines(path);

        if (n > arr_contents.Length)
        {
            System.Console.WriteLine("Error! The number is higher than the length of the file!");
        }
        else
        {
            int index = arr_contents.Length - n;
            System.Console.WriteLine($"The last {n} lines of the file is: ");
            for (int i = index ; i < arr_contents.Length; i ++)
            {
                System.Console.WriteLine(arr_contents[i]);
            }
        }

    }
// 12. to read a specific line from a file.
static void Ex12_Read_SpecificLine_From_a_file()
    {
        System.Console.WriteLine("Enter the index of lines you want to read: ");
        int n = int.Parse(Console.ReadLine() ?? "2");
        string path = "/Users/mrthanh/Desktop/Ex8_Moved_File.txt"; 
        string [] arr_contents = File.ReadAllLines(path);

        if (n > arr_contents.Length)
        {
            System.Console.WriteLine("Error! The number is higher than the length of the file!");
        }
        else
        {
            System.Console.WriteLine($"The content of line {n} is: {arr_contents[n - 1]}");
        }
    }
// 13. to count the number of lines in a file.
static void Ex13_Count_Num_of_lines_in_file()
    {
        string path = "/Users/mrthanh/Desktop/Ex8_Moved_File.txt"; 
        string [] arr_contents = File.ReadAllLines(path);
        System.Console.WriteLine($"There is {arr_contents.Length} lines in the file");
    }
// 14. To print the structure of specific folder (include files)
static void Ex14_Print_Structure_of_folder()
    {
        string folder_path = "/Users/mrthanh/Desktop/git-journey";

        string[] sub_folders = Directory.GetDirectories(folder_path);
        System.Console.WriteLine("List of sub-folders: ");
        foreach(string folders in sub_folders)
        {
            System.Console.WriteLine(folders);
        }
        string [] files = Directory.GetFiles(folder_path);
        System.Console.WriteLine("List of files: ");
        foreach(string file in files)
        {
            System.Console.WriteLine(file);
        }
    }
// 15. Read a text file, then statistic the appearance of characters and numbers.
static void Ex15_Statistic_Characters_And_Numbers()
    {
        string path = "/Users/mrthanh/Desktop/Ex8_Moved_File.txt"; 
        string content = File.ReadAllText(path);
        int letterCount = 0;
        int numberCount = 0;

        foreach(char c in content)
        {
            if (c >= 'a' && c <= 'z')
            {
                letterCount++;
            }
            if(c >= 'A' && c <= 'Z')
            {
                letterCount++;
            }
            if (c >= '0' && c <= '9')
            {
                numberCount++;
            }
        }
        System.Console.WriteLine($"Total characters: {letterCount}");
        System.Console.WriteLine($"Total numbers: {numberCount}");
    }
    private static void Main(string[] args)
    {
        // Ex1_Create_Blank_file();
        // Ex2_RemoveFile_FromDisk();
        // Ex3_Create_file_AddText();
        // Ex4_Create_File_And_Read();
        // Ex5_Write_Array_to_File();
        // Ex6_Append_text();
        // Ex7_Ex8_Copy_And_Move();
        // Ex9_Read_first_Line_Of_File();
        // Ex10_CreateAndRead_LastLine();
        // Ex11_Read_n_last_lines_of_file();
        // Ex12_Read_SpecificLine_From_a_file();
        // Ex13_Count_Num_of_lines_in_file();
        // Ex14_Print_Structure_of_folder();
        Ex15_Statistic_Characters_And_Numbers();
    
    }
}