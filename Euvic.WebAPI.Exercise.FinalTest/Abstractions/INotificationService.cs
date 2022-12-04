namespace Euvic.WebAPI.Exercise.FinalTest.Abstractions
{
    public interface INotificationService
    {
        void SendNotification(string message, long userId);
    }
}
