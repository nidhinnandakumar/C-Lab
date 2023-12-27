namespace FileStreamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string path = "C:\\Users\\nidhin.nandakumar\\Desktop\\LABS\\CSharpLabs1\\Demos\\file5.txt";
         /*   FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("Hello");
            writer.WriteLine("Welcome to Speridian");
            writer.Close();
            stream.Close(); */

            //IDisposable
            try
            {
                using (FileStream stream1=new FileStream(path,FileMode.OpenOrCreate, FileAccess.Write))
                {

                    using (StreamWriter writer1 = new StreamWriter(stream1))
                    {
            
                        writer1.WriteLine("Hello");
                        // writer1.Flush();
                        writer1.WriteLine("Welcome to Speridian");
                        //   writer1.Close();    

                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    StreamReader reader = new StreamReader(stream);
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {

                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}