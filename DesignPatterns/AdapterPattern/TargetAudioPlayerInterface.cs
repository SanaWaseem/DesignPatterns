﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    internal interface TargetAudioPlayerInterface
    {
        void Play(string audioType);
    }
}
