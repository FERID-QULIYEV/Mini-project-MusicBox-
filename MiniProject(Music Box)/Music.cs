using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_Music_Box_
{
    public class Music
    {
        string _name;
        string _artistName;

        //public int Deqiqe=0;
        //public int Saniye = 0;
       
        public string Name
        {
            get { return _name; }
            set 
            { 
                if (value.Trim().Length > 0 & value.Trim().Length < 20) { _name = value; }
            }
        }
        public string ArtistName
        {
            get { return _artistName; }
            set 
            { 
                if (value.Trim().Length>3&&value.Trim().Length < 20) { _artistName = value; }
            }
        }
        public int Time{ get; set; }
        public int Id { get; set; }
        //public Music(int id, string name, string artistName, int time)
        //{
        //    Id = id;
        //    Name = name;
        //    ArtistName = artistName;
        //    Time = time;
        //}
    }
}
