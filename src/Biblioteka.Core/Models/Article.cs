using System;
using System.Collections.Generic;
using System.Text;
using Biblioteka.Shared;

namespace Biblioteka
{
  public  class Article:IAsset
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public AssetCategory Category { get; set; }
        public string Authors { get; set; }
        public Uri Sourse { get; set; }
        public  Blog  Blog { get; set; }

    }
}
