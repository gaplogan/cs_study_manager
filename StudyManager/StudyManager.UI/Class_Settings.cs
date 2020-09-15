using System;
using System.Drawing;
using System.IO;

namespace StudyManager.UI
{
    public static class Class_Settings
    {
        public static Size ParentSize { get; set; }

        public static string FolderPath { get; set; } = Environment.CurrentDirectory + @"\";

        public static void VerificarSettingsFile()
        {
            if (!File.Exists("StudyManager.Settings"))
            {
                CriarSettingsFile();
            }
            else
            {
                StreamReader sr = new StreamReader("StudyManager.Settings");
                try
                {
                    FolderPath = sr.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro StreamReader VerificarSettingsFile: \n" + ex);
                }
                finally
                {
                    sr.Dispose();
                }
            }
        }

        public static void CriarSettingsFile()
        {
            StreamWriter sw = new StreamWriter("StudyManager.Settings", false);
            try
            {
                sw.WriteLine(FolderPath);
                sw.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro StreamWriter CriarSettingsFile: \n" + ex);
            }
            finally
            {
                sw.Dispose();
            }
        }
    }
}
