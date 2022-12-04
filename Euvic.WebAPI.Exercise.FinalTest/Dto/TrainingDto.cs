using System;

namespace Euvic.WebAPI.Exercise.FinalTest.Dto
{
    public class TrainingDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public long LecturerId { get; set; }
        public string LecturerFullName { get; set; }
    }
}
