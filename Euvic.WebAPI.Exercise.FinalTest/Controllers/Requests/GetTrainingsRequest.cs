using System;

namespace Euvic.WebAPI.Exercise.FinalTest.Controllers.Requests
{
    public class GetTrainingsRequest
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public long? LecturerId { get; set; }
    }
}
