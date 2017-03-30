using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PirmasTOPMigle.Class;
using PirmasTOPMigle.Enums;

namespace PirmasTOPMigle
{
    class Program
    {
        static void Main(string[] args)
        {
            Heaven heaven = new Heaven();
            int choise;
            do
            {
                Console.Out.WriteLine("   -------------------------------------------------------  ");
                Console.Out.WriteLine("1 - Create angel \n2 - Create soul \n3 - Create MAIN angel");
                Console.Out.WriteLine("4 - Change state of soul \n5 - Check ID of soul");
                Console.Out.WriteLine("6 - Info of Soul list \n7 - Info of Angel list");
                Console.Out.WriteLine("8 - Kick all devil \n9 - Send souls to Hell");
                Console.Out.WriteLine("0 - Exit");
                Console.Out.WriteLine("   -------------------------------------------------------  ");

                choise = Int32.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        heaven.CreateAngel();
                        break;
                    case 2:
                        heaven.CreateSoul();
                        break;
                    case 3:
                        heaven.MainAngel();
                        break;
                    case 4:
                        heaven.ChangeStateSoul(); //by GOD
                        break;
                    case 5:
                        heaven.PunishSoul();  // by Angel
                        break;
                    case 6:
                        heaven.PrintEachS();
                        break;
                    case 7:
                        heaven.PrintEachA();
                        break;
                    case 8:
                        heaven.KickOutEvil();
                        break;
                    case 9:
                        heaven.SendToHell();
                        break;
                    case 0:
                        Console.Out.WriteLine("Goodbye from heaven");
                        break;
                }
            } while (choise != 0);
           
            //Angel tom = new Angel(80, "BoB");

            //tom.HolyWhat();
            //Soul ben = new Soul(20, 80, "asd666");

            //Console.Out.WriteLine(tom.CheckID(ben));
            //heaven.CreateSoul(80, 10, "bob000");
            //heaven.CreateSoul(80, 10, "bob600");
            //heaven.CreateSoul(80, 10, "boa000");
            //heaven.CreateSoul(80, 10, "baa000");
            //heaven.PrintListS();
            //heaven.SetStateSoul(2);
            //heaven.PrintEachS(2);
            //Console.ReadLine();
        }
    }
}
