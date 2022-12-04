using System;
using System.Collections.Generic;
using Euvic.WebAPI.Exercise.FinalTest.Dto;

namespace Euvic.WebAPI.Exercise.FinalTest.Abstractions
{
    public interface ITrainingsService
    {
        IEnumerable<TrainingDto> GetTrainings(DateTime? from, DateTime? to, long? lecturerId);
    }
}
