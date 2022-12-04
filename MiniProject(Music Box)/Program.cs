using System;
using System.Diagnostics;

namespace MiniProject_Music_Box_
{
    class Program
    {
        static List<Music> AllMusic{ get; set; }
        static void Main(string[] args)
        {
            List<AllMusic> allmusic = new List<AllMusic>();
            List<Music> playList = new List<Music>();
            int count = 1;
            string MusicName = " ";
            int MusicTime = 0;
            int MusicId=1;
            yeniden:
            Console.WriteLine("Istediyiz emeliyyati secin:\n1)Mahni yarat\n2)Mahnilar siyahisina bax\n3)Playliste Mahni elave et\n4)Mahni qos\n5)Son dinlenen mahni");
            string secimler = Console.ReadLine();
            if (secimler == "1")
            {
                Console.WriteLine("Mahni melumatlarini daxil et:\nArdicilliq:\n1)Mahni adi\n2)Ifaci \n3)Musiqinin muddeti saniye ile");
                playList.Add(new Music { Id = count /* Id= Convert.ToInt32(Console.ReadLine()) */ , Name = Console.ReadLine(), ArtistName = Console.ReadLine(), Time = Convert.ToInt32(Console.ReadLine()), });
                goto yeniden;
            }
            else if (secimler == "2")
            {
                if (playList.Count > 0)
                {
                    Console.WriteLine("-----------------------------------------------");
                    foreach (Music music in playList)
                    {
                        Console.WriteLine("Id" + "    Name" + "     Artistname" + "    Time");
                        Console.WriteLine(music.Id + "     " + music.Name + "     " + music.ArtistName + "     " + music.Time + "\n");
                        MusicName = music.Name;
                        MusicTime = music.Time;
                        MusicId = music.Id;
                    }
                    Console.WriteLine("-----------------------------------------------");
                    goto yeniden;
                }
                else
                {
                    Console.WriteLine("Mahni listiniz bosdur");
                    goto yeniden;
                }
            }

            else if (secimler == "3")
            {
            yeniden1:
                Console.WriteLine("Mahnini elave etmek isteyirsinizmi?\n1)He ucun <H> duymesini basin \n2)Yox ucun <Y> duymesini basin");
                string tesdiq = Console.ReadLine();
                if (tesdiq == "H")
                {
                    count++;
                    Console.WriteLine("Mahni elave olundu:");
                    //playList.Add(new Music { Id = count /* Id= Convert.ToInt32(Console.ReadLine()) */ , Name = Console.ReadLine(), ArtistName = Console.ReadLine(), Time = Convert.ToInt32(Console.ReadLine()), });
                    goto yeniden;
                }
                else if (tesdiq == "Y")
                {
                    Console.WriteLine("Mahni elave olunmadi");
                    goto yeniden;
                }
                else
                {
                    Console.WriteLine("bele emeliyyat yoxdur:");
                    goto yeniden1;
                }
            }
            else if (secimler == "4")
            {
                //Console.WriteLine("Qosacaginiz mahninin sirasini secin:");
                //MusicId = Console.ReadLine();
                //for(int i=0;MusicId>i;i++)
                //{
                //    MusicId = 
                //}
                //if (mahnisecimi)
                //{

                //}
                sonrakimahni:
                Stopwatch st = new Stopwatch();
                st.Start();

                while (1 == 1)
                {
                    TimeSpan ts = st.Elapsed;
                    string time = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
                    Console.Write(MusicName + "\r{0}     ", time);
                    //if (MusicTime == ts.Minutes * 60 + ts.Seconds)
                    //{
                    //    Console.WriteLine(MusicTime + "Mahni bitdi");
                    //    goto sonrakimahni;
                    //}
                }
            }
            if (secimler == "5")
            {
                Console.WriteLine($"Son baxilan mahni{MusicId}");
            }
            else
            {
                Console.WriteLine("Bele emeliyyet yoxdur");
                goto yeniden;
            }
            
        }
        

    }
}