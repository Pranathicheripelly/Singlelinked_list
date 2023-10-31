using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlelinked_list
{
    internal class Program
    {
      
            static void Main(string[] args)
            {
                runApp();
            }

            static void runApp()
            {
                singlelist list = new singlelist();
                int i = 0;
                while (i <= 10)
                {
                    list.Add(i);
                    i++;
                }

                // Get and print the length of the linked list

                list.Display();
            Console.ReadLine();


            }
        }
    }

