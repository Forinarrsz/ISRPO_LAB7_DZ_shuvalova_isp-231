using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ISRPO_LAB7_DZ
{
    internal class book
    {
        public string author;
        public string title;
        public bool IsAvailable;
        public int year;

        public book()
        {
            author = "неизвестно";
            title = "неизвестно";
            year = 0;
            IsAvailable = true;
        }

        public book(string tite, string autor, int yer, bool IsAvalable)
        {
            title = tite;
            author = autor;
            IsAvailable = IsAvalable;
            year = yer;

        }
        public void Printinfo()
        {
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.WriteLine(IsAvailable ? "yes":"no");
            Console.WriteLine(year);
            Console.WriteLine();
            
            
        }
    }
}
