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

        ALL_CLEARED
    }
    public static class Logger
    {
        private static String filePath = "logs.txt";  
        private static String timestamp = "["+DateTime.Now.ToString()+"] | ";
        public static void sendLog(Log log, int idEntry)
        {
            String msg;
            int id = idEntry;
            switch (log)
            {
                case Log.ENTRY_ADDED:
                    msg = timestamp + "Záznam s ID: " + id + " přidán";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;
                case Log.ENTRY_ADD_FAILED:
                    msg = timestamp + "Záznam s ID se nepovedlo přidat";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;
                                  
                case Log.ENTRY_REMOVED:
                    msg = timestamp + "Záznam s ID: " + id + " odebrán";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                case Log.ENTRY_MODIFIED:
                    msg = timestamp + "Záznam s ID: " + id + " upraven";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                case Log.DATA_LOADED:
                    msg = timestamp + "Data načtena ze souboru";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                case Log.DATA_SAVED:
                    msg = timestamp + "Data uložena do souboru";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;
                                    
                case Log.ALL_CLEARED:
                    msg = timestamp + "Všechna data byla smazána";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                default:
                    msg = timestamp + "Nespecifický záznam";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;
            }
        }

    }

}
