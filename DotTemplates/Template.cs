using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace WebTemplate
{
    public class Template
    {
        static string path = "C:\\Users\\sasuk\\Documents\\";
        

        public static void Create(string folder, string template) 
        {
            path += folder;

            if (Directory.Exists(path))
            {
                path += "\\";
            } else
            {
                Directory.CreateDirectory(path);
                path += "\\";
            }

            switch(template)
            {
                case "web":
                    BasicWebTemplate(path, folder);
                    StartVSCode(path);
                    break;
                case "dotnet-console":
                    DotNetConsole();
                    break;
                case "java-console":
                    JavaConsole();
                    break;
            }
        }

        static void BasicWebTemplate(string p, string f)
        {
            try
            {
                //Archivos
                Directory.CreateDirectory(path + "img");
                Directory.CreateDirectory(path + "php");

                // Archivos
                File.Create(path + "style.css");
                File.Create(path + "main.js");
                File.Create(path + "php\\" + "php.php");


                // Crear y Abrir Archivo html
                FileStream fileStream = new FileStream(p + "index.html", FileMode.CreateNew, FileAccess.Write);

                fileStream.Close();

                StreamWriter sw = new StreamWriter(path + "index.html", true, Encoding.UTF8);
                // Escribir lineas
                string[] text = { "<!DOCTYPE html>", "<html lang=\"en\">", "<head>", "\t<meta charset=\"UTF-8\">", "\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">", "\t<title>" + f + "</title>", "</head>", "<body>", "\t", "\t", "\t", "</body>", "</html>" };
                
                for(int i = 0; i < text.Length; i++)
                {
                    sw.WriteLine(text[i]);
                }

                sw.Close();


            } catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
            finally
            {
                Console.WriteLine(":)");
            }
        }


        static void DotNetConsole()
        {
            Directory.CreateDirectory(path + "");
            
        }

        static void JavaConsole()
        {
            Directory.CreateDirectory(path + "lib");

            // Archivos
            File.Create(path + "program.java");
        }


        static void StartVSCode(string p)
        {
            System.Diagnostics.Process.Start("C:\\Users\\sasuk\\AppData\\Local\\Programs\\Microsoft VS Code\\Code.exe", p);
        }

    }
}