using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSync.Models
{
    [Serializable]
    public class Attachment
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
    }
}