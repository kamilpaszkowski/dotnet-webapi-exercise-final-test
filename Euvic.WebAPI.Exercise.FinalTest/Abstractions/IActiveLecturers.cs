namespace Euvic.WebAPI.Exercise.FinalTest.Abstractions
{
    public interface IActiveLecturers
    {
        bool IsUserActive(long userId);
        void UserLoggedIn(long userId);
        void NotifyActiveUsers(string message);
    }
}
