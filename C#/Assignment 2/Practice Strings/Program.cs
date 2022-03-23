// See https://aka.ms/new-console-template for more information

using System.Collections;
namespace PracticeString
{
    class Program
    {
        static void Main(String[] args)
        {
            //Reverse("sample");
            //reWords("C# is not C++, and PHP is not Delphi!");
            AllPalindromes();

        }
        /*1.Write a program that reads a string from the console, reverses its letters and prints the result back at the console.*/

        static void Reverse(string str)
        {
            Console.WriteLine(new string(str.Reverse().ToArray()));
            
        }



        /*2.Write a program that reverses the words in a given sentence without changing the punctuation and spaces*/
        static void reWords(string str)
        {
            Console.WriteLine(String.Join(" ", str.Split('.', ' ').Reverse()).ToString());
        }




        /*3.Write a program that extracts from a given text all  palindromes, e.g. “ABBA”, “lamal”, “exe” and prints them on the console on a single line, 
         * separated by comma and space.Print all unique palindromes (no duplicates), sorted*/

        static void AllPalindromes()
        {
            ArrayList arrayList = new ArrayList();
            string str = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
            char[] separators = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
            String[] splits = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach(string i in splits)
            {

                if (i.Equals(new string(i.Reverse().ToArray())))
                {
                    arrayList.Add(i);
                }
            }
            arrayList.Sort();
            foreach (string s in arrayList)
            {
                Console.Write($"{s} ");
            }
        }





        /*4.Write a program that parses an URL given in the following format
         [protocol]://[server]/[resource]*/
        static void ProtocolParse(String url)
        {
            String protocol = "";
            String server = url;
            String resource = "";

            if (url.Contains("://"))
            {
                String[] tmp = url.Split("://");
                protocol = tmp[0];
                server = tmp[1];
            }

            if (server.Contains("/"))
            {
                String[] tmp = server.Split("/");
                server = tmp[0];
                resource = tmp[1];
            }

            Console.WriteLine(url);
            Console.WriteLine($"[protocol] = {protocol}");
            Console.WriteLine($"[server] = {server}");
            Console.WriteLine($"[resource] = {resource}");

        }

    }
}




