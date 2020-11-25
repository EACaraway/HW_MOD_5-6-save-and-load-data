using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_MOD_5_and_6_5_save_to_file_or_read_file
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // 2 options for a user to select.
                Console.WriteLine("1. Save to file.");
                Console.WriteLine("2. Load file.");
                Console.WriteLine("3. Exit.");
                Console.Write("Choose a number: ");
                int.TryParse(Console.ReadLine(), out int userOption);
           


                switch (userOption)
                {   // accepts information from the user and then save that data to a file on disk.
                    case 1:
                        Console.Write("Please enter file name you would like to save to: ");
                        string fileName = Console.ReadLine();
                        Console.Write($"Please type what you would like to save to {fileName}.txt: ");
                        string userData = Console.ReadLine();
                        string path = $"{fileName}.txt";

                        //FileStream stream = File.Open(path, FileMode.OpenOrCreate);
                        StreamWriter streamWriter = new StreamWriter(path, true);
                        streamWriter.Write($"{userData} ");
                        //stream.Close();
                        streamWriter.Close();

                        break;
                    // loads all data stored on that file.
                    case 2:
                        Console.Write("Please enter file name you would like to load: ");
                        string loadFile = Console.ReadLine();
                        string loadPath = $"{loadFile}.txt";
                        //FileStream stream2 = File.Open(loadPath, FileMode.Open);
                        StreamReader reader = new StreamReader(loadPath, true);
                        string userInfo = reader.ReadToEnd();
                        Console.WriteLine(userInfo);
                        //stream2.Close();
                        reader.Close();


                        break;

                    case 3:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }
            }
        }
    }
}
