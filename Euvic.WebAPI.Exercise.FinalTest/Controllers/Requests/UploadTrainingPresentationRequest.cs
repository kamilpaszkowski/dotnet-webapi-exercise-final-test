using Microsoft.AspNetCore.Http;

namespace Euvic.WebAPI.Exercise.FinalTest.Controllers.Requests
{
    public class UploadTrainingPresentationRequest
    {
        public IFormFile Presentation { get; set; }
    }
}
