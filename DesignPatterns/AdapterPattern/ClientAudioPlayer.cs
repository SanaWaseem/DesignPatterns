using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    /// <summary>
    /// Client will have the target interface implemented and will have the instance of the adapter and will call it based on the logic 
    /// Adapter will implement the interface of the Target (Client) will have the instance of the adaptee 
    ///Adapter will call the adaptee methods 
    ///Adaptee will have interface of adaptee and will have their implementations 
    /// </summary>
    internal class ClientAudioPlayer : TargetAudioPlayerInterface
    {
        private AdapterMediaPlayer media;
        public void Play(string audioType)
        {
            if (audioType == "MP3")
            {
                Console.WriteLine("Playing MP3");
                    }
            else
            {
                media = new AdapterMediaPlayer();
                media.Play(audioType);

            }
        }
    }
}
