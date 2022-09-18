﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsertDelete
{
    class LinkedListInsertDeleteProgram
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert("1");
            list.Insert("2");
            list.Insert("3");
            list.Insert("4");
            list.Insert("5");
            Console.WriteLine("List: " + list);

            while (!list.IsEmpty)
            {
                Link deletedLink = list.Delete();
                Console.Write("Removed: " + deletedLink);
                Console.WriteLine("");
            }

            Console.WriteLine("List: " + list);
            Console.Read();
        }

        public class Link
        {
            public string Title { get; set; }
            public Link NextLink { get; set; }

            public Link(string title)
            {
                Title = title;
            }

            public override string ToString()
            {
                return Title;
            }
        }

        public class LinkedList
        {
            private Link _first;
            public bool IsEmpty
            {
                get
                {
                    return _first == null;
                }
            }

            public LinkedList()
            {
                _first = null;
            }

            public Link Insert(string title)
            {
                // Creates a link, sets its link to the first item and then makes this the first item in the list.
                Link link = new Link(title);
                link.NextLink = _first;
                _first = link;

                return link;
            }

            public Link Delete()
            {
                // Gets the first item, and then this to be the one it is linked forward to
                Link temp = _first;
                if (_first != null)
                    _first = _first.NextLink;

                return temp;
            }

            public override string ToString()
            {
                Link currentLink = _first;
                StringBuilder builder = new StringBuilder();
                while (currentLink != null)
                {
                    builder.Append(currentLink);
                    currentLink = currentLink.NextLink;
                }
                return builder.ToString();
            }
        }
    }
}