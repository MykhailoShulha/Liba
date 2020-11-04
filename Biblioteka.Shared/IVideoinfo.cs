using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Biblioteka.Shared
{
   public interface IVideoinfo
    {
        public FileInfo FileInfo { get; set; }
        public TimeSpan Duration { get; set; }
        public string Format { get; set; }
        public bool IsInSeria { get; set; }
        public ushort EpisodNumber { get; set; }
        public Dictionary<TimeSpan,string> TableOfContent { get; set; }
    }
}
