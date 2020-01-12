using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace File_Serialization_and_Deserialization_Tool.Models
{
    public class DeserializeFileModel : FileModel
    {
        public string FileType { get; set; }
        public string SerializedFile { get; set; }
        public string FileName { get; set; }

        public DeserializeFileModel() : base()
        {
            FileName = $"{ConfigurationManager.AppSettings["AppName"]} {DateTime.Now.ToString()}";
        }
    }
}