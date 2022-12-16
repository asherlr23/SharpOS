// See https://aka.ms/new-console-template for more information\

using System;

namespace SharpOSMain 
{
    class mainScript 
    {
            public static void Main()
            {
                SharpOSUtils os = new SharpOSUtils("B20221215.1", true);
                GlobalLogger localLog = new GlobalLogger();

                Console.Write(os.logger.systemLog);

               if (os.debug_status = true) 
               {
                 Console.ReadKey();
               }

            }
    }

    
}

