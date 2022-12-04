using System.IO;
using System.Threading.Tasks;
using Euvic.WebAPI.Exercise.FinalTest.Abstractions;
using Euvic.WebAPI.Exercise.FinalTest.Controllers.Requests;
using Euvic.WebAPI.Exercise.FinalTest.Dto;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Euvic.WebAPI.Exercise.FinalTest.Controllers
{
    [Route("api/trainings")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        private readonly ILogger<TrainingsController> _logger;
        private readonly ITrainingsService _trainingsService;
        private readonly IWebHostEnvironment _environment;

        public TrainingsController(
            ILogger<TrainingsController> logger,
            ITrainingsService trainingsService,
            IWebHostEnvironment environment)
        {
            _logger = logger;
            _trainingsService = trainingsService;
            _environment = environment;
        }

        #region Trainings

        [?]
        public IActionResult GetTrainings([?] GetTrainingsRequest request)
        {
            var trainings = _trainingsService.GetTrainings(request.From, request.To, request.LecturerId);
            return [?](trainings);
        }

        [?]
        public IActionResult CreateTraining([?] CreateTrainingRequest request)
        {
            _logger.LogInformation($"CreateTraining was executed with parameters {request}");

            // Create training code here

            return [?](new TrainingDto()
            {
                Id = 1,
                Title = request.Title,
                StartTime = request.StartTime,
                LecturerId = request.LecturerId,
            });
        }

        [?("{id}/presentation")]
        public async Task<IActionResult> UploadTrainingPresentation([?] int id, [?] UploadTrainingPresentationRequest request)
        {
            var rootPath = _environment.ContentRootPath;

            using (var stream = System.IO.File.Create(Path.Combine(rootPath, $"uploaded_{request.Presentation.FileName}")))
            {
                await request.Presentation.CopyToAsync(stream);
            }

            // Upload presentation code here

            _logger.LogInformation($"Training presentation for file {request.Presentation.FileName} was uploaded");

            return [?]();
        }

        [?]
        public IActionResult UpdateTraining([?] long id, [?] UpdateTrainingRequest request)
        {
            return NoContent();
        }

        [?("?")]
        public IActionResult ChangeTrainingLecturer([?] long id, [?] long lecturerId)
        {
            _logger.LogInformation($"Training with id {id} changed lecturer to {lecturerId}");

            // Change lecturer code here

            return ? ();
        }


        [?("{?}")]
        public IActionResult DeleteTraining([?] long id)
        {
            // Change lecturer code here

            return ? ();
        }

        #endregion Trainings

        #region Attendees

        [?("{id}/?")]
        public ? GetTrainingAttendees([?] long id)
        {
            // Get attendees code here

            return ? ();
        }

        [?("{id}/?")]
        public IActionResult AddTrainingAttendee([?] long id, [?] long attendeeId)
        {
            // Add attendee code here

            return Ok();
        }

        [?("{?}/?/{?}")]
        public IActionResult DeleteTrainingAttendees([?] long id, [?] long attendeeId)
        {
            // Add attendee code here

            return ? ();
        }



        #endregion Attendees

    }
}
