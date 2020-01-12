using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace File_Serialization_and_Deserialization_Tool.Models
{
    public class SerializeFileModel : FileModel
    {
        public string FileType { get; set; }
        public HttpPostedFileBase File { get; set; }
        public string SerializedFile { get; set; }

        public SerializeFileModel() : base() {}
    }
}