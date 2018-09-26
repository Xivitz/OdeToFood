namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Gretter : IGreeter
    {
        public string GetMessageOfTheDay()
        {
            return "Yo bro!";
        }
    }
}