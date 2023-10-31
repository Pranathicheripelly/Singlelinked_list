using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Singlelinked_list
{
    internal class singlelist
    {

            public node Head { get; set; }

            public void Add(int data)
            {
                node newNode = new node(data);

                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    node current = Head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

            public int GetLength()
            {
                int length = 0;
                node current = Head;
                while (current != null)
                {
                    length++;
                    current = current.Next;
                }
                return length;
            }

            public void Display()
            {
                node current = Head;
                Console.WriteLine("Length of singly linked list = " + GetLength());
                Console.WriteLine("Print Single linked list:");
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }


    }

