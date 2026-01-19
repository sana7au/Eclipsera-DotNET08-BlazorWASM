namespace PlanetDistanceBlazor.Services
{
    public class PlanetService
    {
        string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
        double[] radius = { 0.39, 0.72, 1.0, 1.52, 5.2, 9.58, 19.2, 30.1 };
        double[] period = { 88, 225, 365, 687, 4333, 10759, 30687, 60190 };

        public List<(string, double)> Calculate(int month, int year)
        {
            int days = (year - 2000) * 365 + (month * 30);
            var result = new List<(string, double)>();

            // Earth angle (fixed)
            double earthAngle =
                (days % period[2]) / period[2] * 2 * Math.PI;

            double earthX = radius[2] * Math.Cos(earthAngle);
            double earthY = radius[2] * Math.Sin(earthAngle);

            for (int i = 0; i < planets.Length; i++)
            {
                double planetAngle =
                    (days % period[i]) / period[i] * 2 * Math.PI;

                double x = radius[i] * Math.Cos(planetAngle);
                double y = radius[i] * Math.Sin(planetAngle);

                double distance = Math.Sqrt(
                    Math.Pow(x - earthX, 2) +
                    Math.Pow(y - earthY, 2)
                );

                result.Add((planets[i], Math.Round(distance, 3)));
            }

            // Sort closest → farthest
            return result
                .OrderBy(p => p.Item2)
                .ToList();
        }
    }
}