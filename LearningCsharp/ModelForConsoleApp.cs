
/*

    MAKE THE DESCRIPTION OF YOUR CODE HERE 

*/


using IJDEVLibrary;
using IJDEVLibrary.LogsHandler;
using System;
using System.Collections.Generic;
using System.Text;


namespace LearningCsharp
{    

   public class ModelForConsoleApp
    {
        public ModelForConsoleApp() { }

        public static void MainMCA(string[] args)
        {

            #region block ------------------ START OF APP ----------------------

            // Create an instance of your custom logger
            JCustomLogger logger = new("ModelForConsoleApp");

            AppInputOutputManager iom = new();
            var infos = "TITLE OF YOU APP HERE";
            char lineShape = '*';
            int lineLen = 0;

            iom.ShowAppInfo(
                title: infos,
                summary: "This App attempts to show how we can use Special type - record in C#."
            );
            #endregion


            #region block ------------------ THE LOGIC OF APP GOES HERE ----------------------

            logger.Info("Application starting...");

            // THE LOGIC OF APP GOES HERE
            infos = "THE LOGIC OF APP GOES HERE";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, 2, 0, false);
            

            #endregion


            #region block ------------------ Conclusion: END OF APP --------------------

            iom.ShowAppEndInfo();

            #endregion

        }
    }
}
