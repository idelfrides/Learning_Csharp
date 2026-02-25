using IJDEVLibrary;
using IJDEVLibrary.DataTimeManager;
using IJDEVLibrary.LogsHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp;

public class DateTimeConverterDemo
{

    public static void MainDTC(string[] args)
    {

        #region block code 1 --------- START OF APP ------------------------

        // Instance section
        // In this section, you can instantiate all the classes you will use in the application.
        JCustomLogger logger = new("DateTimeConverterDemo");
        AppInputOutputManager iom = new();

        // Value definition for Constants and fields section
        var infos = "DATA TIME CONVERTER DEMO";
        char lineShape = '*';
        int lineLen = 0;
        int vspace = 2;
        int hspace = 0;
        bool useTab = false;

        // Instance member call section
        iom.ShowAppInfo(
            title: infos,
            summary: "This App attempts to show how we can use Special type - record in C#."
        );

        #endregion // --- starting app region ends here ---

        #region block code 2 --------- DataTime Converter APP logic --------

        DateTime utcNow = DateTime.UtcNow;
        DateTime localTimeNow = DateTime.Now;

        DateTimeConverter dtc = new();
        
        // Converter UTC para Brasília (UTC-3)
        var brasiliaTime = dtc.ConvertUtcToTimeZone(utcNow, "E. South America Standard Time");
        logger.Info(message: $"Brasília: {brasiliaTime}");

        // Converter UTC para local
        var utcTolocal = dtc.ConvertUtcToLocal(utcNow);
        logger.Info(message: $"UTC -> Local: {utcTolocal}");

        // Converter local para UTC
        var localToUtc = dtc.ConvertLocalToUtc(localTimeNow);
        logger.Info(message: $"Local -> UTC: {localToUtc}");

        // Converter para Unix Timestamp
        long unix = dtc.ToUnixTimestamp(localTimeNow);
        logger.Info(message: $"Unix Timestamp: {unix}");

        // Converter de Unix Timestamp
        var fromUnix = dtc.FromUnixTimestamp(unix);
        logger.Info(message: $"From Unix: {fromUnix}");

        // Adicionar 5 dias úteis
        var businessDay = dtc.AddBusinessDays(localTimeNow, 5);
        logger.Info(message: $"+5 dias úteis: {businessDay}");

        // Converter para ISO 8601
        string iso = dtc.ToIso8601(localTimeNow);
        logger.Info(message: $"ISO 8601: {iso}");

        // Converter de ISO 8601
        var parsed = dtc.ParseIso8601(iso);
        logger.Info(message: $"Parsed ISO: {parsed}");

        // Converter de ISO 8601
        var parsed2 = dtc.CompleteParseIso8601(localTimeNow);
        logger.Info(message: $"Complete Parse ISO: {parsed2}");

        #endregion // --- the logic of app region ends here ---

        #region block code 3 --------- END OF APP --------------------------

        iom.ShowAppEndInfo();

        #endregion // --- closing region ends here ---

    }
}
