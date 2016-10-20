# LoggerApp
Simple Logging Library that can be added to any .Net project with ease
There is a pre compiled .dll file in the Release folder or you can open the project in Visual Studio and create a new build.

(Useage)

1. Add a reference to the LoggerApp.dll to your project references
2. in c# add a using directive for the dll..  i.e.. using LoggerApp;

3. initialize the Log usually in your Main()
     Log (variable name) = new Log();
     for example... Log log = new Log();
     
4. When you want to log an item to a file simply call the Write method with your message
   log.Write("this is what I want to log");

5. When you are done with your logging calls simply use the .Close() method
   log.Close();
   

It's just a simple log file generator that creates a log file using the format of YYYY_MM_DD_HHMM.txt  
