using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class MyFileInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullPath { get; set; }
        public DateTime CreationTime { get; set; }
        public string Extension { get; set; }
        public DateTime LastAccessTime { get; set; }
        public long Length { get; set; }
        public Webinar Webinar { get; set; }
    }
}
