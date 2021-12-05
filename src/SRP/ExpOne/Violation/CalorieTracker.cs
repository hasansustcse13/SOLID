using System;

namespace SRP.ExpOne.Violation
{
    public class CalorieTracker
    {
        private int _currentCalories;
        private int _maxCalories;

        public CalorieTracker(int maxCalories)
        {
            _maxCalories = maxCalories;
            _currentCalories = 0;
        }

        public void TrackCalories(int caloriesCount)
        {
            _currentCalories += caloriesCount;

            if (_currentCalories > _maxCalories)
            {
                LogCaloriesSurplus();
            }
        }

        public void LogCaloriesSurplus()
        {
            Console.WriteLine("Max calories exceeded");
        }
    }
}
