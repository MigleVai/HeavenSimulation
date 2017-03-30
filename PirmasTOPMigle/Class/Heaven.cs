using PirmasTOPMigle.Enums;
using PirmasTOPMigle.Helpers;
using PirmasTOPMigle.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmasTOPMigle.Class
{
    class Heaven
    {
        HeavenDistrict<Soul> soulList = new HeavenDistrict<Soul>();
        HeavenDistrict<Angel> angelList = new HeavenDistrict<Angel>();
        private God _god = new God("Bob");
        private int _temp = 0;

        public void MainAngel()
        {
            if (_temp == 0)
            {
                Angel angel = new Angel(levelHoly: 200.2, name: "Gabriel");
                angelList.AddCitizen(angel);
                _temp = 1;
                _god.PromoteAngel(angel);
                Console.Out.WriteLine("Created");
            }
            else
            {
                Console.Out.WriteLine("Main angel has already been created");
            }
        }

        public void CreateAngel()
        {
            Console.Out.WriteLine("Name of Angel: ");
            string name = Console.ReadLine();
            Console.Out.WriteLine("Holy level of Angel: ");
            double holylvl = Convert.ToDouble(Console.ReadLine());
            Angel angel = new Angel(holylvl, name);
            _god.PromoteAngel(angel);
            angelList.AddCitizen(angel);

        }

        public void CreateSoul()
        {
            Console.Out.WriteLine("Amount of sins: ");
            int a = TryParseNumb();
            Console.Out.WriteLine("Amount of good works: ");
            int b = TryParseNumb();
            if (a != -1 && b != -1)
            {
                if (a != -2 && b != -2)
                {
                    int sin = a;
                    int good = b;
                    Console.Out.WriteLine("ID of Soul: ");
                    string id = Console.ReadLine();
                    if (id.SizeString())
                    {
                        Soul soul = new Soul(sin, good, id);
                        _god.StateOfSoul(soul);
                        soulList.AddCitizen(soul);
                    }
                    else
                    {
                        Console.Out.WriteLine("ERROR: \nID must have 6 symbols!");
                    }
                }
                else
                {
                    Console.Out.WriteLine("ERROR: \nToo small");
                }
            }
            else
            {
                Console.Out.WriteLine("ERROR: \nBad int");
            }

        }

        public void ChangeStateSoul()
        {
            if (soulList.Size() != 0 && soulList != null)
            {
                PrintListS();
                Console.Out.WriteLine("Number of Soul: ");
                int a = TryParseNumb();
                if (a <= soulList.Size())
                {
                    if (a != -1)
                    {
                        if (a != -2)
                        {
                            a--;
                            _god.ChangeStateOfSoul(soulList.Get(a));
                        }
                        else
                        {
                            Console.Out.WriteLine("ERROR: \nToo small");
                        }
                    }
                    else
                    {
                        Console.Out.WriteLine("ERROR: \nBad int");
                    }
                }
                else
                {
                    Console.Out.WriteLine("ERROR: \nToo big");
                }
            }
            else
            {
                Console.Out.WriteLine("ERROR: \nSoul list has burnt in hell");
            }
        }

        public int One()
        {
            PrintListA();
            Console.Out.WriteLine("Number of Angel: ");
            int b = TryParseNumb();
            if (b <= angelList.Size())
            {
                if (b != -1)
                {
                    if (b != -2)
                    {
                        b--;
                        return b;
                    }
                    else
                    {
                        Console.Out.WriteLine("ERROR: \nToo small");
                        return -1;
                    }
                }
                else
                {
                    Console.Out.WriteLine("ERROR: \nBad int");
                    return -1;
                }
            }
            else
            {
                Console.Out.WriteLine("ERROR: \nToo big");
                return -1;
            }

        }

        public void PunishSoul()
        {
            if (soulList.Size() != 0 && soulList != null || angelList.Size() != 0 && angelList != null)
            {
                PrintListS();
                Console.Out.WriteLine("Number of Soul: ");
                int a = TryParseNumb();
                if (a <= soulList.Size())
                {
                    if (a != -1)
                    {
                        if (a != -2)
                        {
                            a--;
                            int b = One();
                            if (b != -1)
                            {
                                Angel an = angelList.Get(b);
                                an.CheckID(soulList.Get(a));
                            }
                        }
                        else
                        {
                            Console.Out.WriteLine("ERROR: \nToo small");
                        }
                    }
                    else
                    {
                        Console.Out.WriteLine("ERROR: \nBad int");
                    }
                }
                else
                {
                    Console.Out.WriteLine("ERROR: \nToo big");
                }
            }
            else
            {
                Console.Out.WriteLine("ERROR: \nSoul list or Angel list have burnt in hell");
            }

        }

        public void PrintEachS()
        {
            if (soulList.Size() != 0 && soulList != null)
            {
                PrintListS();
                Console.Out.WriteLine("Number of Soul: ");
                int a = TryParseNumb();
                if (a <= soulList.Size())
                {
                    if (a != -1)
                    {
                        if (a != -2)
                        {

                            a--;
                            Soul s = soulList.Get(a);
                            Console.Out.WriteLine("ID: " + s.Id);
                            Console.Out.WriteLine("Sin Amount: " + s.SinAmount);
                            Console.Out.WriteLine("Good deed: " + s.GoodDeedAmount);
                            Console.Out.WriteLine("Status: " + s.Status);
                        }
                        else
                        {
                            Console.Out.WriteLine("ERROR: \nToo small");
                        }
                    }
                    else
                    {
                        Console.Out.WriteLine("ERROR: \nBad int");
                    }
                }
                else
                {
                    Console.Out.WriteLine("ERROR: \nToo big");
                }
            }
            else
            {
                Console.Out.WriteLine("ERROR: \nSoul list has burnt in hell");
            }
        }

        public void PrintEachA()
        {
            if (angelList != null && angelList.Size() != 0)
            {
                PrintListA();
                Console.Out.WriteLine("Number of Angel: ");
                int a = TryParseNumb();
                if (a <= angelList.Size())
                {
                    if (a != -1)
                    {
                        if (a != -2)
                        {
                            a--;
                            Angel ang = angelList.Get(a);
                            Console.Out.WriteLine("Name: " + ang.Name);
                            Console.Out.WriteLine("Level of holiness: " + ang.LevelHoly);
                            Console.Out.WriteLine("Power state: " + ang.Power);

                        }
                        else
                        {
                            Console.Out.WriteLine("ERROR: \nToo small");
                        }
                    }
                    else
                    {
                        Console.Out.WriteLine("ERROR: \nBad int");
                    }
                }
                else
                {
                    Console.Out.WriteLine("ERROR: \nToo big");
                }
            }
            else
            {
                Console.Out.WriteLine("ERROR: \nAngel list has burnt in hell");
            }
        }

        public void PrintListS()
        {
            int a = 1;
            for (int i = 0; i < soulList.Size(); i++)
            {
                Console.Out.WriteLine("{0} - {1}", a, soulList.Get(i).Id);
                a++;
            }
        }

        public void PrintListA()
        {
            int a = 1;
            for (int i = 0; i < angelList.Size(); i++)
            {
                Console.Out.WriteLine("{0} - {1}", a, angelList.Get(i).Name);
                a++;
            }
        }

        public void KickOutEvil()
        {
            if (angelList.Size() != 0 && angelList != null)
            {
                var evilList = (angelList.GetCitizens()).Where(a => a.Power == PowerLevel.Devil).ToList();

                if (evilList.Count() != 0)
                {
                    for (int j = 0; j < angelList.Size(); j++)
                    {
                        Angel angel = angelList.Get(j);
                        for (int i = 0; i < evilList.Count(); i++)
                        {
                            Angel evil = evilList[i];
                            if (evil.Equals(angel))
                            {
                                angelList.RemoveCitizens(evil);
                                //(angelList.GetCitizens()).Remove(angel);
                            }
                        }
                    }
                    Console.Out.WriteLine("Evil is kicked");
                }
                else
                {
                    Console.Out.WriteLine("There is no evi");
                }
            }
            else
            {
                Console.Out.WriteLine("ERROR: \nAngel list has burnt in hell");
            }

        }

        public void SendToHell()
        {
            if (soulList.Size() != 0 && soulList != null)
            {
                IEnumerable<Soul> soulQuery =
                from soul in soulList.GetCitizens()
                where soul.Status == State.Hell
                select soul;

                List<Soul> temp = new List<Soul>();
                if (soulQuery.Count() != 0)
                {
                    for (int i = 0; i < soulList.Size(); i++)
                    {
                        Soul s = soulList.Get(i);
                        foreach (Soul hell in soulQuery)
                        {
                            if (hell.Equals(s))
                            {
                                temp.Add(hell);
                            }
                        }
                    }

                    for (int i = 0; i < temp.Count(); i++)
                    {
                        soulList.RemoveCitizens(temp[i]);
                    }

                }
                else
                {
                    Console.Out.WriteLine("No bad souls");
                }
            }
            else
            {
                Console.Out.WriteLine("ERROR: \nSoul list has burnt in hell");
            }
        }

        public int TryParseNumb()
        {
            string value = Console.ReadLine();
            int number;
            if (Int32.TryParse(value, out number))
            {
                int a = Int32.Parse(value);
                if (a >= 0)
                {
                    return a;
                }
                else
                {
                    return -2;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
