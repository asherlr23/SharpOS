using System;

class SharpOSUtils {
      GlobalLogger Logger = new GlobalLogger();
      public char buildType;
      
      public SharpOSUtils(string build, bool debugMode = false)
      {
         buildType = Char.ToUpper(build[1]);
         bool debug_status = debugMode;
        Logger.Log("System", "Loaded SharpOS Utils, Getting time and date");
        
      }
    public int current_version {
        get { return current_version; }
        set
        {
             if (value > 5000) 
             {
                throw new ArgumentOutOfRangeException("Version Number can not be above 5000");
             }
             else
             {
                current_version = value;
                if (debug_status = true) 
                {
                  Logger.Log("SYSTEM", "Set system version to " + value);
                }
             }
        }
    }
    public string date_time {
        get { return date_time;}
        set
        {
              string str = value.Substring(0,3);
              selectedYear = Convert.ToInt32(str);
            
            if (selectedYear > 3000) {
                throw new ArgumentOutOfRangeException("Year may NOT be more than 3000");
            }
            else
            {
                date_time = value;
                Logger.Log("system", "Set Date and time to " + value);
            }
        }
    }
}