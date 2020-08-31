using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Maquina.Models
{
    public class File
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public Nullable<int> FileType { get; set; }
        public Nullable<int> UserId { get; set; }
        public virtual User User { get; set; }
    }
}