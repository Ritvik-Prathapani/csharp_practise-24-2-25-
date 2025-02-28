using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    interface IPlayable
    {
        void play();
    }
    class MusicPlayer : IPlayable
    {
        public void play()
        {
            Console.WriteLine("playing music");
        }
    }
    class videoPlayer: IPlayable
    {
        public void play()
        {
            Console.WriteLine("playing video");
        }
    }
}
