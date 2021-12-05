using SRP.ExpOne.Violation;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Violation SRP
            var calorieTracker = new CalorieTracker(2000);
            calorieTracker.TrackCalories(500);
            calorieTracker.TrackCalories(700);
            calorieTracker.TrackCalories(900);
        }
    }
}
