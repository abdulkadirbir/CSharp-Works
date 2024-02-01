﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_ToDoApp
{
    internal class Card
    {
        private string title;
        private string content;
        private string person;
        private string size;
        private string line;

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Person { get => person; set => person = value; }
        public string Size { get => size; set => size = value; }
        public string Line { get => line; set => line = value; }

        public Card() { }

        public Card(string title, string content, string person, string size, string line)
        {
            Title = title;
            Content = content;
            Person = person;
            Size = size;
            Line = line;
        }
    }
}
