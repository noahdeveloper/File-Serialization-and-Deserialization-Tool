using File_Serialization_and_Deserialization_Tool.Helper;
using File_Serialization_and_Deserialization_Tool.Models;
using System;
using System.Web.Mvc;

namespace File_Serialization_and_Deserialization_Tool.Controllers
{
    public class FileProcessingController : Controller
    {
        [HttpGet]
        public ActionResult Serialize()
        {
            var model = new SerializeFileModel();
            return View(model);
        }

        [HttpPost]
        public JsonResult Serialize(SerializeFileModel model)
        {
            //Serialize file in base 64 string.
            var serializedFile = GeneralHelper.EncodeFileToBase64String(model.File);

            return Json(new { data = serializedFile });
        }

        [HttpGet]
        public ActionResult Deserialize()
        {
            var model = new DeserializeFileModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Deserialize(DeserializeFileModel model)
        {
            try
            {
                //Return a file.
                return File(Convert.FromBase64String(model.SerializedFile), model.FileType, $"{model.FileName}.xlsx");
            }
            catch (Exception ex)
            {
                //Display error message on page.
                model.ErrorMessage = ex.Message;
                return View(model);
            }
        }
    }
}