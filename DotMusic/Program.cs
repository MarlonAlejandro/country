using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotMusic
{
    class Program
    {
        static string path = "C:\\Users\\sasuk\\Music\\";
        static List<string> list = new List<string>();
        static SoundPlayer s = new SoundPlayer();
        

        public static void Main(string[] args)
        {

            

            while (true)
            {
                UpdateList();
                string option = Console.ReadLine();
                if (option == "show list")
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    ShowList();
                }
                else
                {
                    Play(option);
                }
            }
        }



        static void UpdateList()
        {

            foreach (string l in Directory.GetFiles(path))
            {
                string name = "";
                for (int i = 21; true; i++)
                {
                    if (i == l.Length)
                    {
                        list.Add(name);
                        break;
                    }
                    else
                    {
                        name += l[i];
                    }
                }

            }
        }

        static void ShowList()
        {
            foreach (string l in list)
            {
                Console.WriteLine(l);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
        }


        static void Play(string name)
        {
            s.SoundLocation = path + name;
            s.Load();
            s.Play();

            string o = Console.ReadLine();
            if (o == "stop")
            {
                s.Stop();
            }
        }
    }
}
