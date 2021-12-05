namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Violation SRP
            var calorieTracker = new ExpOne.Violation.CalorieTracker(2000);
            calorieTracker.TrackCalories(500);
            calorieTracker.TrackCalories(700);
            calorieTracker.TrackCalories(900);

            // Fixed Violation of SRP
            var newCalorieTracker = new ExpOne.FixedViolation.CalorieTracker(2000);
            newCalorieTracker.TrackCalories(500);
            newCalorieTracker.TrackCalories(700);
            newCalorieTracker.TrackCalories(900);
        }
    }
}
