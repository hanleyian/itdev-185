using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Assignment1oo
{
    class ui
    {

    public void intro() {

            WriteLine("Welcome to the program. I didn't have any specific ideas so I guess you can just write stuff to a text file. Very exciting.\n");
            menu();
    }

        public void menu() {
            WriteLine("A to read file, B to write to file, C to delete");
            string ab;
            ab = ReadLine();

            if (ab == "A") {
                readFile();
            }

            if (ab == "B") {
                writeFile();
            }

            if(ab == "C") {
                deleteFile();
            }


        }

    public void readFile() {

            WriteLine("Here is what is currently in the text file: \n\n");
            try {
                using (StreamReader sr = new StreamReader("TextFile1.txt"))
                {
                    String line = sr.ReadToEnd();
                    WriteLine(line);
                }
            }
            catch (IOException e) {
                WriteLine("File could not be read");
                WriteLine(e.Message);
            }


            WriteLine("\n\n");
            menu();
    
    }

        public void writeFile() {

            WriteLine("Write to the file: ");
            string append;
            append = ReadLine();

            using (StreamWriter sw = File.AppendText("TextFile1.txt") ) {
                sw.WriteLine(append);

            }

            WriteLine("Writing complete");
            menu();

        }

        public void deleteFile() {

            WriteLine("Which line to delete?");
            string num;
            num = ReadLine();

            int a;

            a = Int32.Parse(num);
            




            List<string> quotelist = File.ReadAllLines("TextFile1.txt").ToList();
            string firstItem = quotelist[0];
            quotelist.RemoveAt(a);
            File.WriteAllLines("TextFile1.txt", quotelist.ToArray());
            

            menu();
        }

        


    }
}
