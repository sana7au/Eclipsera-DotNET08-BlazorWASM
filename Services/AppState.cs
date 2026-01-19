namespace PlanetDistanceBlazor.Services
{
    public class AppState
    {
        public string Username { get; set; } = "";
        public string Role { get; set; } = "";

        public bool IsAdminAuthenticated { get; set; } = false;

        public List<string> Logs { get; set; } = new();

        // Persist user inputs
        public int? SavedMonth { get; set; }
        public int? SavedYear { get; set; }

        // Persist calculation results
        public List<(string Planet, double Distance)> PlanetResults { get; set; } = new();
    }
}
