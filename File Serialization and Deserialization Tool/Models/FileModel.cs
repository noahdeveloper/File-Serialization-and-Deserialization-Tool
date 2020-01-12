using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace File_Serialization_and_Deserialization_Tool.Models
{
    public class FileModel
    {
        public List<SelectListItem> FileTypeList { get; set; }
        public string ErrorMessage { get; set; }

        public FileModel()
        {
            FileTypeList = new List<SelectListItem>()
            {
                new SelectListItem() { Value = "application/vnd.ms-excel", Text = "Excel (.xlsx)"}
            };
        }
    }
}