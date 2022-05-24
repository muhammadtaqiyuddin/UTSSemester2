// See https://aka.ms/new-console-template for more information

using System;
namespace Uts
{
    class Program
    {
        static void Main(string[] args)
        {

            Dosen objDosen = new Dosen();
            Console.WriteLine("\n========== DEFAULT DOSEN ==========\n");
            objDosen.defaultDosen();
            Console.WriteLine("\n========== TAMBAHAN DOSEN ==========\n");
            objDosen.attDosen();
            objDosen.addCourse();
            Console.WriteLine("DATA DOSEN BERHASIL DITAMBAHKAN!!!");
            objDosen.defaultDosen();
            Console.WriteLine("ID     : 5\nNAMA   : " + objDosen.name +
                "\nNIK    : 524119202\nGENDER : " + objDosen.gender +
                "\nCOURSE : " + objDosen.course) ;
           
        }
    }
}
