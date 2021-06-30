using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PostgreSQLBackup
{
    public class CustomIterate
    {
        public enum getTypes
        {
            FileStructure,
            DirectoryStruct
        }
        public CustomIterate() { }
        private string[] GetDrives()
        {
            return System.Environment.GetLogicalDrives();
        }
        static void IterateDirectory(DirectoryInfo root)
        {

            FileInfo[] files = null;
            DirectoryInfo[] subFolder = null;
            try
            {
                files = root.GetFiles("*.*");

            }catch(UnauthorizedAccessException e)
            {
               Console.WriteLine(e.Message);
            }
            subFolder = root.GetDirectories();
            foreach(DirectoryInfo dir in subFolder)
            {
                IterateDirectory(dir);
                if (dir.Name != "PostgreSQL")
                {
                    IterateDirectory(dir);
                }
               
            }

        }
        private List<string> GetDirectoriesFiles(string types)
        {
            List<string> Files = new List<string>();
            List<string> Directories = new List<string>();

            foreach(string drive in GetDrives())
            {
                DriveInfo DrvInfo = new DriveInfo(drive);
                if(!DrvInfo.IsReady)
                {
                    Console.WriteLine("The drive {0} is not Ready. Cannot be read.", DrvInfo.Name);
                    continue;
                }else
                {
                    DirectoryInfo RootDirectory = DrvInfo.RootDirectory;
                    IterateDirectory(RootDirectory);

                }
            }



            if(types==getTypes.FileStructure.ToString())
            {
                return Files;
            }else
            {
                return Directories;
            }

        }




    }
}
