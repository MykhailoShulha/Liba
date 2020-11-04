using System;
using System.Collections.Generic;
using System.Text;
using Biblioteka.Shared;


namespace Biblioteka
{
    public class Blog : IAsset
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public AssetCategory Category { get; set; }
        public string Authors { get; set; }
        public Uri Contact { get; set; }
        public List<Article> Articles { get; set; }
    }
}
