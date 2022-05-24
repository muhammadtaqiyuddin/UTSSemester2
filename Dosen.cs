using System;
namespace Uts
{
    class Dosen
    {
        public int id;
        public string name;
        public int nik;
        public string gender;
        public string course;

        public void defaultDosen()
        {
            Console.WriteLine(
                "ID     : 1\nNAMA   : Bayu Nadya Kusuma S.T, M.Eng\nNIK    : 0505028902\nGENDER : PRIA\nCOURSE : PEMROGRAMAN \n"
            );
            Console.WriteLine(
                "ID     : 2\nNAMA   : Arif Akabarul Huda, S.Si, M.Eng\nNIK    : 0506058901\nGENDER : PRIA\nCOURSE : PEMROGRAMAN \n"
            );
            Console.WriteLine(
                "ID     : 3\nNAMA   : M. Fairul Filza, M.Kom\nNIK    : 0504098603\nGENDER : PRIA\nCOURSE : PEMROGRAMAN \n"
            );
            Console.WriteLine(
                "ID     : 4\nNAMA   : Kamarudin, M.Kom\nNIK    : 0504098603\nGENDER : PRIA\nCOURSE : PEMROGRAMAN \n"
            );
        } 
        public void attDosen()
        {
            Console.WriteLine("TAMBAHKAN NAMA DOSEN : ");
            name = (Console.ReadLine());
            Console.WriteLine("MASUKKAN GENDER DOSEN : ");
            gender = (Console.ReadLine());
        }
        public void addCourse()
        {
            Console.WriteLine("MASUKKAN COURSE DOSEN : ");
             course = (Console.ReadLine());
        }

    }
}