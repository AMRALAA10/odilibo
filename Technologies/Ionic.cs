using System;
using System.IO;
using System.Reflection;
using NameSpacesManager;
using odilibo.Helpers;

namespace odilibo.Technologies
{
    public class Ionic
    {
        public static void CreatePage(string pageName)
        {
            var path = Environment.CurrentDirectory;
            var pagePath = Path.Combine(path, "www/app/pages/" + pageName);
            Directory.CreateDirectory(pagePath);

            FileManager.CreateFile(pagePath, pageName + ".html", GetHtmlText(pageName));
            FileManager.CreateFile(pagePath, pageName + "Ctrl.js", GetJsText(GetAppName(path), pageName));
            
            ConsoleHelper.WriteSuccess("Created!!");
        }



        public static string GetHtmlText(string pageName)
        {
            var appLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var templateHtmlPath = Path.Combine(appLocation, "templates/Ionic/page.html");
            return NameSpaceManager.ReadText(templateHtmlPath).Replace("PageTitle", pageName);
        }


        public static string GetJsText(string appName, string pageName)
        {
            var appLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var templateJsPath = Path.Combine(appLocation, "templates/Ionic/pageCtrl.js");
            return NameSpaceManager.ReadText(templateJsPath)
                                    .Replace("PageCtrl", pageName + "Ctrl")
                                    .Replace("appName", appName);
        }


        public static string GetAppName(string dir)
        {
            return NameSpaceManager.GetDirName(dir);
        }


    }
}

/*
 string path = @"E:\AppServ\Example.txt";
if (!File.Exists(path))
{
    File.Create(path);
    TextWriter tw = new StreamWriter(path);
    tw.WriteLine("The very first line!");
    tw.Close();
}
else if (File.Exists(path))
{
    TextWriter tw = new StreamWriter(path, true);
    tw.WriteLine("The next line!");
    tw.Close(); 
}
     
     */



