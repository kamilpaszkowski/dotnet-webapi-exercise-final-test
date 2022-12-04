using System;

namespace Euvic.WebAPI.Exercise.FinalTest.Controllers.Requests
{
    public class UpdateTrainingRequest
    {
        public DateTime StartTime { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, StartTime: {StartTime}";
        }
    }
}
