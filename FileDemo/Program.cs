namespace FileDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DriveInfo[] drives = DriveInfo.GetDrives();

             
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Drive:{0},drive.Name");
                Console.WriteLine("Type:{0}",drive.DriveType);
                Console.WriteLine($"Free space: {drive.TotalFreeSpace/(1024*1024*1024)}GB");
            }

            
            // FileInfo fileInfo = new FileInfo(@"C:\Users\nidhin.nandakumar\Desktop\LABS\CSharpLabs1\file1.txt");
            //FileInfo.

        /*    DirectoryInfo directory = new DirectoryInfo (@"C:\Users\nidhin.nandakumar\Desktop\LABS\CSharpLabs1\Demos");
            var directoryDemos = directory.CreateSubdirectory("Demos");

            if(directory.Exists)
            {
                directory.Create();
            }

            foreach (var file in directory.GetFiles())
            {
                Console.WriteLine($"Name:{file.Name}");
                Console.WriteLine($"Size:{file.Length/1024}KB");
                Console.WriteLine($"Last Updated:{file.LastWriteTime}");


            } */

        }



    }
   }

