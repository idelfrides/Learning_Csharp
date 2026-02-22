using System;
using System.Collections.Generic;
using System.Text;

namespace IJDEVLibrary.DataTimeManager;


public class DateTimeConverter
{
    // 1. Converter UTC para um fuso horário específico
    public DateTime ConvertUtcToTimeZone(DateTime utcDateTime, string timeZoneId)
    {
        TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, tz);
    }

    // 2. Converter horário local para UTC
    public DateTime ConvertLocalToUtc(DateTime localDateTime)
    {
        return localDateTime.ToUniversalTime();
    }

    // 3. Converter UTC para horário local do sistema
    public DateTime ConvertUtcToLocal(DateTime utcDateTime)
    {
        return utcDateTime.ToLocalTime();
    }

    // 4. Converter para Unix Timestamp (segundos desde 1970-01-01 UTC)
    public long ToUnixTimestamp(DateTime dateTime)
    {
        DateTimeOffset dto = new DateTimeOffset(dateTime.ToUniversalTime());
        return dto.ToUnixTimeSeconds();
    }

    // 5. Converter de Unix Timestamp para DateTime
    public DateTime FromUnixTimestamp(long unixTimestamp)
    {
        return DateTimeOffset.FromUnixTimeSeconds(unixTimestamp).UtcDateTime;
    }

    // 6. Adicionar dias úteis (ignora sábados e domingos)
    public DateTime AddBusinessDays(DateTime startDate, int businessDays)
    {
        DateTime current = startDate;
        int addedDays = 0;

        while (addedDays < businessDays)
        {
            current = current.AddDays(1);
            if (current.DayOfWeek != DayOfWeek.Saturday && current.DayOfWeek != DayOfWeek.Sunday)
                addedDays++;
        }

        return current;
    }

    // 7. Converter para string formatada (ISO 8601)
    public string ToIso8601(DateTime dateTime)
    {
        return dateTime.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
    }

    // 8. Converter string para DateTime (com cultura invariável)
    public DateTime ParseIso8601(string isoDate)
    {
        return DateTime.Parse(isoDate, null, System.Globalization.DateTimeStyles.RoundtripKind);
    }

    // 9. Realiza o processo completo de converter string para DateTime (com cultura invariável) 
    public  DateTime CompleteParseIso8601(DateTime dateTime)
    {
        string isoDate = ToIso8601(dateTime);
        return DateTime.Parse(isoDate, null, System.Globalization.DateTimeStyles.RoundtripKind);
    }
}