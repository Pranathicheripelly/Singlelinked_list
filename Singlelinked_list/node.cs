using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlelinked_list
{
    internal class node
    {

        
            public int Data { get; set; }
            public node Next { get; set; }

            public node(int data)
            {
                Data = data;
                Next = null;
            }
        }
    }

