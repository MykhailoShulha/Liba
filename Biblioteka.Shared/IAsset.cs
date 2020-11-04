using System;
using System.Collections.Generic;
using System.Text;


namespace Biblioteka.Shared
{
    public interface IAsset
    {
        public int Id { get; set; }
        public string Notes { get; set; }
        public string Title { get; set; }
        public AssetCategory Category { get; set; }
        public string Authors { get; set; }

    }
}
