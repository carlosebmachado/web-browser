namespace Browser
{
    public class Settings
    {
        public static string HomePageURL;
        public static string SearchEngineURL;

        static Settings()
        {
            HomePageURL = "google.com";
            SearchEngineURL = "google.com/search?q=";
        }
    }
}
