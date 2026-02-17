
/*

    MAKE THE DESCRIPTION OF YOUR CODE HERE 

    :::> COPY THIS FILE AND THEN EDIT IT FOR YOU PURPOSE  <:::

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

            #region block code --------- START OF APP ----------------------

            // Instance section
            // In this section, you can instantiate all the classes you will use in the application.
            JCustomLogger logger = new("ModelForConsoleApp");
            AppInputOutputManager iom = new();

            // Value definition for Constants and fields section
            var infos = "TITLE OF YOU APP HERE";
            char lineShape = '*';
            int lineLen = 0;

            // Instance member call section
            iom.ShowAppInfo(
                title: infos,
                summary: "This App attempts to show how we can use Special type - record in C#."
            );

            #endregion // --- starting region ends here ---


            #region block code --------- THE LOGIC OF APP GOES HERE --------

            logger.Info("Application starting...");

            // THE LOGIC OF APP GOES HERE
            infos = "THE LOGIC OF APP GOES HERE";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, 2, 0, false);


            #endregion // --- the real app region ends here ---


            #region block code --------- END OF APP ------------------------

            iom.ShowAppEndInfo();

            #endregion // --- closing region ends here ---

        }
    }
}
