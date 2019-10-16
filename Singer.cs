using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Singer
    {
        private Node<Song> songs;
        private Node<Disk> disks;

        public Singer(Node<Song> songs, Node<Disk> disks)
        {
            this.songs = songs;
            this.disks = disks;
        }

        
    }


}
