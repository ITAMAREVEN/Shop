using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Song song1 = new Song("bla bla", 7, "22.02.2002", "h");
            Node<Song> songs = new Node<Song>(song1);
            Node<Song> song2 = new Node<Song>(new Song("Elections 2019", 14, "17.09.2019", "q"));
            songs.SetNext(song2);
            Disk disk1 = new Disk(songs, "1.1.2002", 10000, "l");
            Node<Disk> disks = new Node<Disk>(disk1);
            Singer singer1 = new Singer(songs, disks);

            Console.WriteLine("commends are: 1. check_len, then a space, if you want a song, write s and then a name of a song, if you want a disk, write the name of the disk.\n2. buy_disk and the the name of the disk.\n3. search, then a space and words, and the result will be a song that contains  these words.\n 4. buy, a space and the name of the disk\n5. search, a space, and words in the song");
            string commend = Console.ReadLine();
            string[] commend_and_params = commend.Split();
            if (commend_and_params[0] == "check_len")
            {
                if (commend_and_params[1] == "s")
                {
                    Node<Song> song = songs;
                    while (song != null)
                    {
                        if (commend_and_params[2] == song.GetValue().GetName())
                        {
                            Console.WriteLine("len is " + song.GetValue().GetLen());

                        }
                        song = song.GetNext();
                    }
                }
                else
                {
                    Node<Disk> disk = disks;
                    while (disk != null)
                    {
                        if (commend_and_params[1] == disk.GetValue().GetName())
                        {
                            Console.WriteLine("len is " + disk.GetValue().GetLen());

                        }
                        disk = disk.GetNext();
                    }
                }
                
            }
            else if (commend_and_params[0] == "buy")
            {
                Console.WriteLine("bought successfully");
            }
            else
            {
                Node<Song> song = songs;
                while (song != null)
                {
                    if (song.GetValue().GetWords().Contains(commend_and_params[1]))
                    {
                        Console.WriteLine("song is " + song.GetValue().GetName());

                    }
                    song = song.GetNext();
                }
            }
            
        }

    }
}
