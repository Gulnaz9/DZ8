using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    internal class Song
    {
        string name; //название песни
        string author; //автор песни
        Song prev; //связь с предыдущей песней в списке

        public Song(string name, string author, Song prev = null)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }

        public Song(string name, string author, string prevName, string prevAuthor)
                : this(name, author)
        {
            prev = new Song(prevName, prevAuthor);
        }

        public Song() { }//конструктор для создания объекта без аргументов

        /// <summary>
        ///метод для заполнения поля name
        /// </summary>
        /// <param name="name"></param>
        public void GetName(string name)
        {
            this.name = name;
        }
        /// <summary>
        ///метод для заполнения поля author
        /// </summary>
        /// <param name="author"></param>
        public void GetAuthor(string author)
        {
            this.author = author;
        }
        /// <summary>
        ///метод для заполнения поля prev
        /// </summary>
        /// <param name="prev"></param>
        public void GetPrev(Song prev)
        {
            this.prev = prev;
        }
        /// <summary>
        /// метод для печати названия песни и ее исполнителя
        /// </summary>
        /// <returns></returns>
        public string Title()
        {
            return $"{name} - {author}";
        }
        ///метод, который сравнивает между собой два объекта-песни
        public override bool Equals(object d)
        {
            Song otherSong = d as Song;
            if (d != null)
            {
                if (name == otherSong.name && author == otherSong.author)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
