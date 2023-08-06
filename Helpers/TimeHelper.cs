using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_k4.Helpers
{
    public static class DateHelper
    {
        public static string FormatTimeDifference(string dateTimeString)
        {
            DateTimeOffset postTime;

            // Try parsing the input string using the first date format
            if (DateTimeOffset.TryParseExact(dateTimeString, "yyyy-MM-ddTHH:mm:ss.FFFZ", CultureInfo.InvariantCulture, DateTimeStyles.None, out postTime))
            {
                // Logic for handling the first date format
                TimeSpan timeDifference = DateTimeOffset.UtcNow - postTime;
                if (timeDifference.TotalDays < 7)
                {
                    if (timeDifference.TotalDays >= 1)
                    {
                        return $"{(int)timeDifference.TotalDays} day{(timeDifference.TotalDays >= 2 ? "s" : "")} ago";
                    }
                    else if (timeDifference.TotalHours >= 1)
                    {
                        return $"{(int)timeDifference.TotalHours} hour{(timeDifference.TotalHours >= 2 ? "s" : "")} ago";
                    }
                    else if (timeDifference.TotalMinutes >= 1)
                    {
                        return $"{(int)timeDifference.TotalMinutes} minute{(timeDifference.TotalMinutes >= 2 ? "s" : "")} ago";
                    }
                    else
                    {
                        return "Just now";
                    }
                }
                else
                {
                    return postTime.ToString("dd/MM/yyyy, HH:mm");
                }
            }
            else if (DateTimeOffset.TryParseExact(dateTimeString, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out postTime))
            {
                // Logic for handling the second date format
                TimeSpan timeDifference = DateTimeOffset.UtcNow - postTime;
                if (timeDifference.TotalDays < 7)
                {
                    if (timeDifference.TotalDays >= 1)
                    {
                        return $"{(int)timeDifference.TotalDays} day{(timeDifference.TotalDays >= 2 ? "s" : "")} ago";
                    }
                    else if (timeDifference.TotalHours >= 1)
                    {
                        return $"{(int)timeDifference.TotalHours} hour{(timeDifference.TotalHours >= 2 ? "s" : "")} ago";
                    }
                    else if (timeDifference.TotalMinutes >= 1)
                    {
                        return $"{(int)timeDifference.TotalMinutes} minute{(timeDifference.TotalMinutes >= 2 ? "s" : "")} ago";
                    }
                    else
                    {
                        return "Just now";
                    }
                }
                else
                {
                    return postTime.ToString("dd/MM/yyyy, HH:mm");
                }
            }
            else if (DateTimeOffset.TryParse(dateTimeString, out postTime))
            {
                // Logic for handling the third date format
                TimeSpan timeDifference = DateTimeOffset.UtcNow - postTime;
                if (timeDifference.TotalDays < 7)
                {
                    if (timeDifference.TotalDays >= 1)
                    {
                        return $"{(int)timeDifference.TotalDays} day{(timeDifference.TotalDays >= 2 ? "s" : "")} ago";
                    }
                    else if (timeDifference.TotalHours >= 1)
                    {
                        return $"{(int)timeDifference.TotalHours} hour{(timeDifference.TotalHours >= 2 ? "s" : "")} ago";
                    }
                    else if (timeDifference.TotalMinutes >= 1)
                    {
                        return $"{(int)timeDifference.TotalMinutes} minute{(timeDifference.TotalMinutes >= 2 ? "s" : "")} ago";
                    }
                    else
                    {
                        return "Just now";
                    }
                }
                else
                {
                    return postTime.ToString("dd/MM/yyyy, HH:mm");
                }
            }
            else
            {
                return "Invalid DateTime";
            }
        }


    }

}
