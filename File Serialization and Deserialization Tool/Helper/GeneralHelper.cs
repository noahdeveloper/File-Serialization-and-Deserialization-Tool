using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace File_Serialization_and_Deserialization_Tool.Helper
{
    public static class GeneralHelper
    {
        public static string EncodeFileToBase64String(HttpPostedFileBase file)
        {
            if (file == null)
                return string.Empty;

            try
            {
                using (var reader = new BinaryReader(file.InputStream))
                {
                    return Convert.ToBase64String(reader.ReadBytes(file.ContentLength));
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}