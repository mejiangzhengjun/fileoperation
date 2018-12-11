using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileoperation
{
   class DirectoryTest
    {
        public static void Main()
        {
            string path = @"C:\Test\TestDizini";
            string target = @"C:\Test\HedefDizini";
            try
            {
                //eğer klasör yoksa yeni bir klasör oluştur.
               if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("oluşturulma tarihi : " + Directory.GetCreationTime(path));
                    Console.WriteLine("son erişşim tarihi : " + Directory.GetLastAccessTime(path));
                    Console.WriteLine("son değştilime tarihi : " + Directory.GetLastWriteTime(path));
                    Console.WriteLine("bulunduğu dizinin adı: " + Directory.GetParent(path));
                    Console.ReadLine();
                }
               if(Directory.Exists(target))
                {
                    Directory.Delete(target, true);
                }
                //move ile taşıma
                Directory.Move(path, target);
                //getdirectories ile klasör seçimi
                string[] directories = Directory.GetDirectories(@"C:\Test\");
                foreach(string dir in directories)
                {
                    Console.WriteLine(dir);
                }
                //yeni bir metin belgesi oluştuma
                File.CreateText(target + @"\NewFile.txt");
                //getfiles ile dosya seçimi
                Console.WriteLine("{0} dizsindeki dosya sayısı: {1}", target, Directory.GetFiles(target));
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("işlem Başarısız : {0}", e.ToString());
            }
        }
    }
}
