﻿using System.Collections.Generic;

namespace OKEGui
{
    public class VideoJob : Job
    {
        public string EncoderPath;
        public string EncodeParam;
        public List<string> VspipeArgs = new List<string>();
        public bool Vfr;
        public double Fps;
        public uint FpsNum;
        public uint FpsDen;
        public int NumaNode;
        public ulong NumberOfFrames;

        public VideoJob(string codec) : base(codec)
        {
        }

        public override JobType GetJobType()
        {
            return JobType.Video;
        }
    }
}
