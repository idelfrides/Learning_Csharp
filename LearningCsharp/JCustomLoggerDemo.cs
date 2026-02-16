using IJDEVLibrary;
using IJDEVLibrary.LogsHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp
{
    public class JCustomLoggerDemo
    {
        private readonly JCustomLogger _logger;

        public JCustomLoggerDemo(JCustomLogger logger)
        {
            _logger = logger;
        }

        public void DoSomething()
        {
            _logger.Info("This method is Doing something...");

            try
            {
                // Simulate some work
                throw new InvalidOperationException("Something went wrong");
            }
            catch (Exception ex)
            {
                _logger.Error("An error occurred", ex);
            }
        }

        public void RankBestCountriesWorld()
        {
            int rankNumber = 5;
            _logger.Info($"Ran of Top {rankNumber} Best counties in the world", new Dictionary<string, object>
                {
                    {"Numbr 1", "RGB"},
                    {"Numbr 2", "BRAZIL"},
                    {"Numbr 3", "JAPAN"},
                    {"Numbr 4", "CHINA"},
                    {"Numbr 5", "USA"}
                }
            );               
        }
    }

    public class WeatherService
    {
        private readonly JCustomLogger _logger;

        public WeatherService(JCustomLogger logger)
        {
            _logger = logger;
        }

        public void GetForecast(string city)
        {
            _logger.Info($"Fetching forecast for {city}", new Dictionary<string, object> { { "City", city } });
            _logger.Debug("Forecast data retrieved successfully.");
            _logger.Warn("Forecast data may be incomplete.");
        }
    }
    
    public class UserService
    {
        private readonly JCustomLogger _logger;
        public UserService(JCustomLogger logger)
        {
            _logger = logger;
        }
        public void CreateUser(string username)
        {
            _logger.Info($"Creating user {username}", new Dictionary<string, object> { { "Username", username } });
        }
    }

    public class BestFootballClubInWorld
    {
        private readonly JCustomLogger _logger;
        public BestFootballClubInWorld(JCustomLogger logger)
        {
            _logger = logger;
        }
        public void PerformAction(string clubName)
        {
            _logger.Info($"Showing the best football club in the world.", new Dictionary<string, object> { { "Best Football club", clubName } });
        }
    }
    
   

    public class JCLDemoProgram
    {
        public static void MainCLD(string[] args)
        {

            #region block ------------------ START OF APP ----------------------
            AppInputOutputManager iom = new();

            var infos = "JCustomLogger DEMO CONSOLE APP";
            char lineShape = '*';

            iom.ShowAppInfo(
                title: infos,
                summary: "This App attempts to show how we can use a custom logger class to show log during the app execution."
            );
            #endregion

            #region block ------------------ DEMO OF USING THE LOGGER ----------------------

            // Create an instance of your custom logger
            JCustomLogger logger = new("JCustomLogger");
            
            #region Demonstrate all log levels 
            logger.Info("INFO: Application starting...");
            logger.Debug("This is a DEBUG message for developers.");
            logger.Warn("This is a WARNING message about a potential issue.");
            logger.Trace("This is a TRACE message for very detailed diagnostic info.");
            logger.Error("This is an ERROR message with simulated exception.", new InvalidOperationException("Invalid operation"));
            #endregion

            var demo = new JCustomLoggerDemo(logger);
            demo.DoSomething();
            demo.RankBestCountriesWorld();
            
            var weather_service = new WeatherService(logger);
            weather_service.GetForecast("New York");            
            
            var user_service = new UserService(logger);
            user_service.CreateUser("john_doe");

            var best_football_club = new BestFootballClubInWorld(logger);
            best_football_club.PerformAction("Real Madrid");

            iom.ShowPrettyInfo("Application finished successfully.", lineShape, 60);            

            #endregion      

            #region block ------------------ Conclusion: END OF APP --------------------

            iom.ShowAppEndInfo();

            #endregion

        }
    }

}
