using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Disk
    {
        private Node<Song> songs;
        private string date;
        private int price;
        private int total_len;
        private string name;

        public Disk(Node<Song> songs, string date, int price, string name)
        {
            this.songs = songs;
            this.date = date;
            this.price = price;
            this.total_len = 0;
            this.name = name;
            while (songs != null)
            {
                this.total_len += songs.GetValue().GetLen();
                songs = songs.GetNext();
            }
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetLen()
        {
            return this.total_len;
        }
    }
}
