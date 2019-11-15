using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CsvHelper;

namespace OuterRimStudios.Utilities
{
    public static class AnalyticsUtilities
    {
        /// <summary>Writes data to a csv file.</summary>
        /// <param name="eventName">The name of the event which will be used to create the filename.</param>
        /// <param name="data">The data that you want written to the csv file."</param>
        public static void Event<T>(string eventName, List<T> data)
        {
            string savePath = "";
#if UNITY_EDITOR || UNITY_STANDALONE
            savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
#elif UNITY_ANDROID
            savePath = Application.persistentDataPath;
#endif
            //This bool controls whether or not the Write operation adds the headers for the data. If the file already exists, then it should already have the headers and this bool should remain false.
            bool createHeaders = false;
            //Adding the date to the filename so the analytics are separated based on date.
            string date = DateTime.Today.ToString("d").Replace('/', '-');
            string analyticsFolderPath = Path.Combine(savePath, "Analytics");
            if (!Directory.Exists(analyticsFolderPath))
                Directory.CreateDirectory(analyticsFolderPath);
            if (!File.Exists(analyticsFolderPath + eventName + "Analytics_" + date + ".csv"))
                createHeaders = true;

            //This section is writing the data to the csv file
            using (var writer = new StreamWriter(Path.Combine(analyticsFolderPath, eventName) + "Analytics_" + date + ".csv", append: true))
            using (var csv = new CsvWriter(writer))
            {
                csv.Configuration.HasHeaderRecord = createHeaders;
                csv.WriteRecords(data);
            }
        }
    }
}
