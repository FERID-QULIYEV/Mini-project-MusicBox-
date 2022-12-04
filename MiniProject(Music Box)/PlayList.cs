using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_Music_Box_
{
    class PlayList<Music>
    {
        Music[] _arr;
        public int Count = 0;
        public PlayList()
        {
            _arr = new Music[0];
        }
        public void AddMusic(Music id)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = id;
        }
        public void AddMusic(Music id, Music name)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = name;
        }
        public void AddMusic(Music id, Music name, Music artistname)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = artistname;
        }
        public Music this[int index]
        {
            get { return _arr[index]; }
        }
        public void Play(Music name)
        {
           
        }

    }
}
