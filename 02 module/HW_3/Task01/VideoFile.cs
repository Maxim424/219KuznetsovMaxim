using System;
namespace Task01
{
    public class VideoFile
    {
        private string name;
        private int duration;
        private int quality;

        public int Size
        {
            get
            {
                return duration * quality;
            }
        }

        public VideoFile()
        {
        }

        public VideoFile(string name, int duration, int quality)
        {
            this.name = name;
            this.duration = duration;
            this.quality = quality;
        }

        public override string ToString()
        {
            return "name: " + name + "\n"
                + "duration: " + duration + "\n"
                + "quality: " + quality + "\n";
        }
    }
}
