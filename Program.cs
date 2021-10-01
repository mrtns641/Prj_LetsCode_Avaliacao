using System;

namespace Prj_LetsCode_Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas-vindas ao sistema do Shopping e aeroporto - desenvolvido por Zerg");
            Menu menu = new Menu();
            menu.MenuInicial();
        }
    }
}
