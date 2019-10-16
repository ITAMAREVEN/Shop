using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Song
    {
        private string words;
        private int len;
        private string date;
        private Node<Singer> singers;
        private string name;
        
        public Song(string words, int len, string date, string name)
        {
            this.words = words;
            this.len = len;
            this.date = date;
            this.name = name;
        }
        public void AddSinger(Node<Singer> singers)
        {
            this.singers.SetValue(singers.GetValue());
            this.singers = this.singers.GetNext();


                
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetLen()
        {
            return this.len;
        }
        public string GetWords()
        {
            return this.words;
        }
    }
}
