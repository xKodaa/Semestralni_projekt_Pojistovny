using Entities;
using Semestralni_projekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int id = idEntry - 1;
            switch (log)
            {
                case Log.ENTRY_ADDED:
                    msg = "Entry ID: " + id + " added";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;
                case Log.ENTRY_ADD_FAILED:
                    msg = "Entry ID: failed to add";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;
                                  
                case Log.ENTRY_REMOVED:
                    msg = "Entry ID:" + id +" removed";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                case Log.ENTRY_MODIFIED:
                    msg = "Entry ID:" + id + " modified";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                case Log.DATA_LOADED:
                    msg = "Data loaded from file";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                case Log.DATA_SAVED:
                    msg = "Data saved into file";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;

                default:
                    msg = "Unspecified log type";
                    File.AppendAllText(filePath, msg + Environment.NewLine);
                    break;
            }
        }

    }

}
