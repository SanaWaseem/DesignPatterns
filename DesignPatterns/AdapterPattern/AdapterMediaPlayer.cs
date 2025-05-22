using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    internal class AdapterMediaPlayer : TargetAudioPlayerInterface
    {
        private AdapteeAdvancePlayer adapteePlayer;

        public void Play(string audioType)
        {
            if (audioType == "VLC")
            {
                adapteePlayer = new AdapteeAdvancePlayer();
                adapteePlayer.PlayVLC();
               
            }
            else if (audioType == "MP4")
            {
                adapteePlayer = new AdapteeAdvancePlayer();
                adapteePlayer.PlayMP4();
            }
        }
    }
}
