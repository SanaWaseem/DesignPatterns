using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.AdapterPattern
{
    internal class AdapteeAdvancePlayer : AdapteeInterfaceAdvanceMediaPlayer
    {
        public void PlayMP4()
        {
            Console.WriteLine("Playing mp4");
        }

        public void PlayVLC()
        {
            Console.WriteLine("Playing VLC");
        }
    }
}
