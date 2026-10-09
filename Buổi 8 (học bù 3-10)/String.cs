using System;
using System.Collections.Generic;
using System.Text;

internal class String
{
    // Write a program in C# Sharp
    // - to input a string and print it.
    static void InputStringAndPrintString()
    {
        Console.Write("Nhập chuỗi bất kì: ");
        string str = Console.ReadLine () ?? "My name is Khoi";
        Console.WriteLine($"Chuỗi vừa nhập: {str}");
    }
    // - to find the length of a string without using a library function.
    static void Length_of_string ()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine() ?? "Hello World";
        s = s.Trim();
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            count++;
        }
        Console.WriteLine($"Length of string: {count}");
    }
    // - to separate individual characters from a string.
    static void Seperate_char_string()
    {
        System.Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine() ?? "Hello World";
        s = s.Trim();
        string [] arr = s.Split(" ");

        System.Console.Write("String after seperated is: ");
        for (int i = 0; i < arr.Length ; i++)
        {
            foreach (char c in arr[i])
            {
                System.Console.Write(c + " ");
            }
        }
        
    }
    // - to print individual characters of the string in reverse order.
    static void Reverse_char_of_string()
    {
        System.Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine() ?? "Hello World";
        s = s.Trim();
        for (int i = s.Length -1 ; i >= 0 ; i--)
        {
            System.Console.Write(s[i]);
        }
    }
    // - to count the total number of words in a string.
    static void Count_Totalnum_of_words_instring()
    {
        System.Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine() ?? "Hello World";
        s = s.Trim();
        string[] arr = s.Split(" ");
        System.Console.WriteLine($"There are {arr.Length} words!");
    }
    // - to compare two strings without using a string library functions.
    static void Compare_2_string()
    {
        System.Console.WriteLine("Enter the first string: ");
        string s1 = Console.ReadLine() ?? "Hello World";
        System.Console.WriteLine("Enter the second string: ");
        string s2 = Console.ReadLine() ?? "Hello World";
        bool isSame = true;
        if (s1.Length != s2.Length)
        {
            isSame = false;
        }
        else
        {
        for(int i = 0; i < s1.Length ; i ++)
            {
                if (s1[i] != s2[i])
                {
                    isSame = false;
                    break;
                }
            }
        }
        if (isSame) System.Console.WriteLine("Two given strings are the same!");
        else System.Console.WriteLine("Two given strings are not the same!");
        
    }
    // - to count the number of alphabets, digits and special characters in a string.
    static void Count_NumofAlp_Dig_Spec_Chac_inString()
    {
        System.Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine() ?? "Hello World @@2007";

        int count_char = 0;
        int count_num = 0;
        int count_special = 0;
        foreach (char c in s)
        {
            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
            {
                count_char ++;
            }
            else if(c >= '0' && c <= '9')
            {
                count_num ++;
            }
            else
            {
                count_special ++;
            }
        }
        System.Console.WriteLine($"There are {count_char} characters in the string!");
        System.Console.WriteLine($"There are {count_num} numbers in the string!");
        System.Console.WriteLine($"There are {count_special} special characters in the string!");

    }
    // - to count the number of vowels or consonants in a string.
    static void Count_numofVowels_Consonants()
    {
        System.Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine() ?? "Hello World @@2007";
        int count_vowel = 0;
        int count_consonants = 0;
        s = s.Trim().ToLower();

        foreach (char c in s)
            {
                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'o' ||c == 'a'||c == 'e'||c == 'u'||c == 'i')
                    {
                        count_vowel ++;
                    }
                    else count_consonants ++;
                }    
            }
        
        System.Console.WriteLine($"There are {count_vowel} vowels in the string!");
        System.Console.WriteLine($"There are {count_consonants} consonants in the string!");
    }
    // - to check whether a given substring is present in the given string.
    static void Check_substring_in_givenString()
    {
        System.Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine() ?? "Hello World @@2007";
        s = s.ToLower();

        System.Console.WriteLine("Enter the substring you want to check: ");
        string sub_string = Console.ReadLine() ?? "Hello";
        sub_string = sub_string.ToLower();

        bool found = false;
        int index = 0;

        for (int i = 0; i < s.Length - sub_string.Length +1  ; i++)
        {
            if (sub_string[0] == s[i])
            {
                bool match = true;
                index = i;
                for (int j = 1 ; j < sub_string.Length ; j++)
                {
                    if(sub_string[j] != s[i + j])
                    {
                        match = false;
                        break;
                    }
                }
                
                if (match)
                {
                    found = true;
                    break;
                }
            }
        }
        if (found)
        {
            System.Console.WriteLine("Substring is present in the string!");
        }
        else System.Console.WriteLine("Substring is not present in the string!");
    } 
    // - to search for the position of a substring within a string.
    static void Search_position_ofSubstring()
    {
        System.Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine() ?? "Hello World @@2007";
        s = s.ToLower();

        System.Console.WriteLine("Enter the substring you want to check: ");
        string sub_string = Console.ReadLine() ?? "Hello";
        sub_string = sub_string.ToLower();

        bool found = false;
        int index = 0;

        for (int i = 0; i < s.Length - sub_string.Length +1  ; i++)
        {
            if (sub_string[0] == s[i])
            {
                bool match = true;
                index = i;
                for (int j = 1 ; j < sub_string.Length ; j++)
                {
                    if(sub_string[j] != s[i + j])
                    {
                        match = false;
                        break;
                    }
                }
                
                if (match)
                {
                    found = true;
                    break;
                }
            }
        }
        if (found)
        {
            System.Console.WriteLine($"The position of the substring is: {index}");
        }
        else System.Console.WriteLine("Substring is not present in the string!");
    }
    // - to check whether a character is an alphabet and not and if so, check for the case.
    static void Check_ifChar_theCase()
    {
        bool approved = false;
        do
        {
            System.Console.WriteLine("Enter a Character: ");
            string input = Console.ReadLine() ?? "H";
            if (input.Length != 1)
            {
                approved = false;
                System.Console.WriteLine("Error! Please try again!");
                continue;
            }
            char c = input[0];

            if (c >= 'a' && c <= 'z' )
            {
                approved = true;
                System.Console.WriteLine("The character is Lower case!");
                break;
            }
            if ( c >= 'A' && c <= 'Z')
            {
                approved = true;
                System.Console.WriteLine("The character is Upper case!");
                break;
            }
            else
            {
                System.Console.WriteLine("This is not a character!");
                approved = false;
            }
        } while(!approved);
    }
    // - to find the number of times a substring appears in a given string.
    static void Count_time_Substring_appear()
    {
            
        System.Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine() ?? "Tran Dang Khoi";
        s = s.ToLower();

        System.Console.WriteLine("Enter the substring you want to count: ");
        string sub_string = Console.ReadLine() ?? "an";
        sub_string = sub_string.ToLower();

        if (sub_string.Length == 0)
        {
            System.Console.WriteLine("Error! Substring cannot be empty!");
            return; 
        }
        string[] mang_cat = s.Split(sub_string);
        int count = mang_cat.Length - 1;

        System.Console.WriteLine($"The substring appears {count} times in the given string.");  
    }
    // - to insert a substring before the first occurrence of a string.
    static void Insert_substring()
    {
    System.Console.WriteLine("Enter the original string: ");
    string original_string = Console.ReadLine();

    System.Console.WriteLine("Enter the substring to search for: ");
    string search_string = Console.ReadLine();

    System.Console.WriteLine("Enter the substring to insert: ");
    string insert_string = Console.ReadLine();

    int index = original_string.IndexOf(search_string);

    if (index != -1) 
    {
        string final_string = original_string.Insert(index, insert_string);
        System.Console.WriteLine($"Result: {final_string}");
    }
    else
    {
        System.Console.WriteLine("Error: The search substring was not found in the original string!");
    } 
    }
    private static void Main(string[] args)
    {
        // InputStringAndPrintString();
        // Length_of_string();
        // Seperate_char_string();
        // Reverse_char_of_string();
        // Count_Totalnum_of_words_instring();
        // Compare_2_string();
        // Count_NumofAlp_Dig_Spec_Chac_inString();
        // Count_numofVowels_Consonants();
        // Check_substring_in_givenString();
        // Search_position_ofSubstring();
        // Check_ifChar_theCase();
        // Count_time_Substring_appear();
        Insert_substring();
    }
}
