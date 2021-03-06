﻿using System;

namespace ProjectK.SoftwareHardware
{
    public enum HardwareType { CPU, RAM, GPU, HDD, Soundcard, Motherboard};
    public class Hardware
    {
        public String Model { get; set; }
        public int Memory { get; set; }
        public Hardware() { }
        public HardwareType Type { get; set; }
        public int Count { get; set; }
    }
}
