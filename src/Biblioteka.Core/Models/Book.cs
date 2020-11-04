using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Biblioteka.Shared;


namespace Biblioteka.Models
{
   public class Book 
    {
        public int Id { get; set; }
        public string Notes { get; set; }
        public string Title { get; set; }
        public AssetCategory Category { get; set; }
        public string Authors { get; set; }
        public byte[] Content { get; set; }
        public BookPublisher Publisher { get; set; }
        public int PageCount { get; set; }
    }
}
