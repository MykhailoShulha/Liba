using System;
using System.Collections.Generic;
using System.Text;
using Biblioteka.Shared;
namespace Biblioteka
{
    public class CodeSnippet : IAsset
    {
        public int Id { get; set; }
        public string Notes { get; set; }
        public string Title { get; set; }
        public AssetCategory Category { get; set; }
        public string Authors { get; set; }
        public string Code { get; set; }
        public Uri Sourse { get; set; }
        public CodeLanguage Language { get; set; }
        public string Description { get; set; }

    }
}
