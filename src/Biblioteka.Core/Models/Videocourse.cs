using System;
using System.Collections.Generic;
using System.Text;
using Biblioteka.Shared;
using System.IO;


namespace Biblioteka
{
    public class Videocourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MyFileInfo> Series { get; set; }
    }
}
