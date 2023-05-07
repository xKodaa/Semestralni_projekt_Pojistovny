using System;
using System.IO;

namespace Logging
{
    public enum Log 
    {
        ENTRY_ADDED,
        ENTRY_ADD_FAILED,
        ENTRY_REMOVED,
        ENTRY_MODIFIED,

        DATA_LOADED,
        DATA_SAVED,
    }
    public static class Logger
    {
        static String filePath = "logs.txt";    
        public static void sendLog(Log log, int idEntry)
        {
            String msg;
            int id = idEntry;
            switch (log)
            {
                case Log.ENTRY_ADDED:
                    msg = "Záznam s ID: " + id + " přidán";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;
                case Log.ENTRY_ADD_FAILED:
                    msg = "Záznam s ID se nepovedlo přidat";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;
                                  
                case Log.ENTRY_REMOVED:
                    msg = "Záznam s ID: " + id + " odebrán";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                case Log.ENTRY_MODIFIED:
                    msg = "Záznam s ID: " + id + " upraven";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                case Log.DATA_LOADED:
                    msg = "Data načtena ze souboru";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                case Log.DATA_SAVED:
                    msg = "Data uložena do souboru";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                default:
                    msg = "Nespecifický záznam";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;
            }
        }

    }

}
