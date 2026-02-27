
/*

    MAKE THE DESCRIPTION OF YOUR CODE HERE 

    :::> COPY THIS FILE AND THEN CHANGE IT NAME AND EDIT IT CONTENT FOR YOU PURPOSE <:::

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

            #region block code 1 --------- START OF APP ----------------------

            // Instance section
            // In this section, you can instantiate all the classes you will use in the application.
            JCustomLogger logger = new("YOUR MAIN CLASS NAME HERE");
            AppInputOutputManager iom = new();

            // Value definition for Constants and fields section
            var infos = "TITLE OF YOU APP HERE";
            var summary = "This App attempts to show how we can use Special type - record in C#.";
            char lineShape = '*';
            int lineLen = 0;
            int vspace = 2;
            int hspace = 0;
            bool useTab = false;

            // Instance member call section
            iom.ShowAppInfo(title: infos, summary: summary);

            #endregion // --- starting app region ends here ---


            #region block code 2 --------- THE LOGIC OF APP GOES HERE --------

            logger.Info("Application starting...");

            // THE LOGIC OF APP GOES HERE
            infos = "THE LOGIC OF APP GOES HERE";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);


            #endregion // --- the logic of app region ends here ---


            #region block code 3 --------- END OF APP ------------------------

            iom.ShowAppEndInfo();

            #endregion // --- closing region ends here ---

        }
    }
}
    