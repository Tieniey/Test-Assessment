using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _2C2PTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        protected string ContentRootPath { get; set; }
        public UploadController(IWebHostEnvironment hostingEnvironment)
        {
            ContentRootPath = hostingEnvironment.ContentRootPath;
        }        

        [HttpPost]
        [Route("UploadTransaction")]
        public ActionResult UploadTransaction(IFormFile myFile)
        {
            try
            {
                string[] fileExtensions = { ".csv", ".xml" };
                var fileName = myFile.FileName.ToLower();
                var isValidExtenstion = fileExtensions.Any(ext => {
                    return fileName.LastIndexOf(ext) > -1;
                });
                if (isValidExtenstion)
                {
                    var path = GetOrCreateUploadFolder();
                    using (var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName)))
                    {
                        myFile.CopyTo(fileStream);
                    }

                    return Ok(myFile);
                }
                else
                {
                    return NotFound("Unknown format"); //Unknown format
                }
            }
            catch
            {
                return BadRequest(myFile); 
            }
            //return new EmptyResult(); 
        }

        public string GetOrCreateUploadFolder()
        {
            var path = Path.Combine(ContentRootPath, "uploads");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }
    }    
}
