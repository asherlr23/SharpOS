using System;

class GlobalLogger
{

    private static int openListIDs;
    public GlobalLogger(){
        List<GlobalLogger> systemLog = new List<GlobalLogger>();
        openListIDs = 0;
    }
    public static void Log(string location, string info, string listName = location + openListIDs + 1) 
    {
        if (location.ToUpper() = "SYSTEM") 
        {
            systemLog.Add("[" + location.ToUpper() + "] " + info);
        }
        else
        {
            List<GlobalLogger> listName = new List<GlobalLogger>();
            if(listName = location + openListIDs + 1) 
            {
                openListIDs++;
            }
        }
    
    }
}