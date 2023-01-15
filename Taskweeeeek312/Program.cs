namespace Taskweeeeek312
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //    Console.Write("Ededi daxil edin:");
            //l1: int a = ReadIntTask1();
            //    int sonReqem;
            //    int cem = 0;
            //    if (a < 999 || a > 10000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l1;

            //    }
            //    while (a > 0)
            //    {
            //        sonReqem = a % 10;
            //        cem = cem + sonReqem;
            //        a = a / 10;
            //    }
            //    Console.WriteLine($"Ededin reqemlerinin cemi = {cem}");
            #endregion
            #region Task 2
            //    Console.Write("Ededi daxil edin:");
            //l1: int a = ReadIntTask2("a:");
            //    int sonReqem;
            //    int cem = 0;
            //    if (a < 99999 || a > 1000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l1;
            //    }
            //    a = a / 1000;
            //    while (a > 0)
            //    {
            //        sonReqem = a % 10;
            //        cem = cem + sonReqem;
            //        a = a / 10;
            //    }
            //    Console.WriteLine($"Ededin ilk 3 reqemlerinin cemi = {cem}");
            #endregion
            #region Task 3
            //    Console.Write("Ededi daxil edin:");
            //l1: int a = ReadIntTask3("a:");
            //    int sonReqem; int cem = 0;
            //    int count = 0;


            //    if (a < 99999999 || a > 1000000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l1;
            //    }
            //    a = a / 1000;
            //    while (count < 3)
            //    {
            //        sonReqem = a % 10;
            //        cem = cem + sonReqem;
            //        a = a / 10;
            //        count++;
            //    }
            //    Console.WriteLine(cem);
            #endregion
            #region Task 4
            //l1: int a = ReadIntTask4("a:");
            //    int lastNumber, firstNumber; 
            //    double sum;
            //    if (a < 10000 || a >= 100000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l1;
            //    }
            //    lastNumber = a % 10;
            //    firstNumber = a / 10000;
            //    sum = firstNumber + lastNumber;
            //    sum = Math.Pow(sum, 2);
            //    Console.WriteLine(sum);
            #endregion
            #region Task 5
            //l1: int a = ReadIntTask5("a:");
            //    int firstNumber;
            //    if (a < 99999 || a > 1000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l1;
            //    }
            //    firstNumber = a / 100000;
            //    a = a * 10 + firstNumber;
            //    Console.WriteLine(a);
            #endregion
            #region Task 6
            //l1: int a = ReadIntTask6("a:");
            //int firstV, secondV;
            //if (a < 9999999 || a > 100000000)
            //{
            //    Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //    goto l1;
            //}
            //firstV = a % 10000000;
            //secondV = firstV / 10;
            //Console.WriteLine(secondV);
            #endregion
            #region Task 7
            //l1: int a = ReadIntTask7("a:");
            //    int tersA=0, sonReqem;
            //    if(a<999 || a > 10000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l1;
            //    }
            //    while (a > 0)
            //    {
            //        sonReqem = a % 10;
            //        tersA = tersA * 10 + sonReqem;
            //        a = a / 10;

            //    }
            //    tersA = tersA * 10 + 8;
            //    tersA = 800000 + tersA;
            //    Console.WriteLine(tersA);
            #endregion
            #region Task 8  
            //int a = ReadIntTask8("a:");
            //int thirdNumber, lastNumber, sum;
            //lastNumber = a % 10;
            //thirdNumber = a / 100 % 10;
            //sum = lastNumber + thirdNumber;
            //Console.WriteLine(sum);
            #endregion
            #region Task 9
            //9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439
            //l1: int a = ReadIntTask9("a:");
            //    int i = 1, sonReqem, tekReqem = 0;
            //    int tersA = 0;

            //    if (a < 99999999 || a > 1000000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l1;
            //    }
            //    while (a > 0)
            //    {
            //        sonReqem = a % 10;
            //        tersA = tersA * 10 + sonReqem;
            //        a = a / 10;
            //    }
            //    a = tersA;

            //    tersA = 0;

            //    while (a > 0)
            //    {
            //        sonReqem = a % 10;
            //        a = a / 10;
            //        if (i % 2 == 1)
            //        {
            //            tekReqem = tekReqem * 10 + sonReqem;
            //        }
            //        i++;
            //    }
            //    Console.WriteLine(tekReqem);
            #endregion
            #region Task 10
            //int a = ReadIntTask10("a:");
            //int tersA = 0, sonReqem;
            //while (a > 0)
            //{
            //    sonReqem = a % 10;
            //    tersA = tersA * 10 + sonReqem;
            //    a = a / 10;
            //}
            //a = tersA;



            //int part1 = 0, part2 = 0;

            //int i = 1;


            //while (tersA > 0)
            //{
            //    sonReqem = tersA % 10;
            //    tersA = tersA / 10;

            //    if (i % 2 == 0)
            //    {
            //        part2 = part2 * 10 + sonReqem;
            //    }
            //    else
            //    {
            //        part1 = part1 * 10 + sonReqem;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"tek reqemler {part1}");
            //Console.WriteLine($"cut reqemler {part2}");
            #endregion
            #region Task 11
            //l1: int a = ReadIntTask11("a:");
            //    int birinciG, ikinciG, ucuncuG, dorduncuG;
            //    int cem, faiz, netice;
            //    if (a < 9999999 || a > 100000000)
            //    {
            //        Console.WriteLine("Daxil etdyiniz reqem dogru araliqda deil");
            //        goto l1;
            //    }
            //    birinciG = a % 100;
            //    a=a / 100;
            //    ikinciG = a % 100;
            //    a=a / 100;
            //    ucuncuG = a % 100;
            //    a=a / 100;
            //    dorduncuG= a % 100;
            //    cem = birinciG + ikinciG + ucuncuG + dorduncuG;
            //    cem = cem * 100 + 99;
            //    faiz = cem / 100 * 18;
            //    netice=cem-faiz;
            //    Console.WriteLine(netice);
            #endregion
            #region Task 12
            //l1: int a = ReadIntTask12("a:");
            //    int b = ReadIntTask12("b:");
            //    int sonReqem, cem = 0;
            //    int hasil = 1, sonReqem2;
            //    int netice, enSonReqemi;
            //    if ((a < 9999 || a > 100000) && (b < 9999 || b > 100000))
            //    {
            //        Console.WriteLine("Daxil etdiyniz reqem dogru araliqda deil");
            //            goto l1;
            //    }
            //    enSonReqemi = a % 10;
            //    while (a > 0)
            //    {
            //        sonReqem = a % 10;
            //        cem = cem + sonReqem;
            //        a = a / 10;
            //    }
            //    while (b > 0)
            //    {
            //        sonReqem2 = b % 10;
            //        hasil = hasil * sonReqem2;
            //        b = b / 10;
            //    }
            //    netice = cem + hasil;
            //    netice = netice * 10 + enSonReqemi;
            //    Console.WriteLine(netice);
            #endregion
            #region Task 13
            //l1:
            //    int a = ReadIntTask13("a:");
            //l2:
            //    int b = ReadIntTask13("b:");
            //l3:
            //    int c = ReadIntTask13("c:");
            //    int ailkReqem, asonReqem;
            //    int bilkReqem, bsonReqem;
            //    int cilkReqem, csonReqem;
            //    int a2,b2,c2;
            //    double netice, faizi;

            //    if (a < 9999 || a > 100000)
            //    {
            //        Console.WriteLine("Daxil etdiyniz reqem dogru araliqda deil");
            //        goto l1;
            //    }
            //    if (b < 9999 || b > 100000)
            //    {
            //        Console.WriteLine("Daxil etdiyniz reqem dogru araliqda deil");
            //            goto l2;
            //    }
            //    if (c < 9999 || c > 100000)
            //    {
            //        Console.WriteLine("Daxil etdiyniz reqem dogru araliqda deil");
            //            goto l3;
            //    }
            //    ailkReqem = a / 10000;
            //    asonReqem = a % 10;
            //    bilkReqem = b / 10000;
            //    bsonReqem= b % 10;
            //    cilkReqem = c / 10000;
            //    csonReqem = c % 10;
            //    a2 = ailkReqem * 10 + asonReqem;
            //    b2 = bilkReqem * 10 + bsonReqem;
            //    c2 = cilkReqem * 10 + csonReqem;
            //    netice = a2 + b2 + c2;
            //    faizi = netice / 100D * 50;
            //    netice = netice + faizi;
            //    Console.WriteLine(netice);
            #endregion
            #region Task 14
            //l1:
            //    int a = ReadIntTask14("a:");
            //l2:
            //    int b = ReadIntTask14("b:");
            //l3:
            //    int c = ReadIntTask14("c:");
            //l4:
            //    int d = ReadIntTask14("d:");
            //    int a2, b2, c2, d2, d3;
            //    int netice, sonReqemd, hasilD = 1, faizi;


            //    if (a < 99999 || a > 1000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l1;
            //    }
            //    if (b < 99999 || b > 1000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l2;
            //    }
            //    if (c < 99999 || c > 1000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l3;
            //    }
            //    if (d < 999999 || d > 10000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l4;
            //    }
            //    a2 = a / 1000;
            //    b2 = b / 1000;
            //    c2 = c / 1000;
            //    d2 = d / 1000;
            //    netice = a2+b2+c2;
            //    netice = netice + d2;
            //    d3 = d / 10000;
            //    while (d3 > 0)
            //    {
            //            sonReqemd = d3 % 10;
            //            hasilD = hasilD * sonReqemd;
            //            d3 = d3 / 10;
            //    }
            //    netice = netice - hasilD;
            //    netice = netice / 100 * 60;
            //    netice = netice * 100 + 60;
            //    faizi = netice / 100D * 18;
            //    netice = netice - faizi;
            //    Console.WriteLine($"Yekun netice = {netice}");
            #endregion
            #region Task 15

            //l1: int a = ReadIntTask15("a:");
            //l2: int b = ReadIntTask15("b:");
            //l3: int c = ReadIntTask15("c:");
            //l4: int d = ReadIntTask15("d:");
            //l5: int e = ReadIntTask15("e:");
            //    int cemab, yapismisab, sonBesReqem;
            //    int netice;
            //    int cemcd, sonReqeme, cemE = 0;
            //    int tersE = 0, sonReqeme2, e2;
            //    int tersE2 = 0, sonReqeme3;
            //    int neticeQaliqi;
            //    if (a < 99 || a > 1000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l1;
            //    }
            //    if (b < 99 || b > 1000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l2;
            //    }
            //    if (c < 99999 || c > 1000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l3;
            //    }
            //    if (d < 99999 || d > 1000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l4;
            //    }
            //    if (e < 999999 || e > 10000000)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //        goto l5;
            //    }
            //    cemab = b + a;
            //    netice = cemab % 100;
            //    netice = netice * netice;
            //    yapismisab = a * 1000 + b;
            //    netice = netice + yapismisab;
            //    sonBesReqem = e / 100;
            //    netice = netice - sonBesReqem;
            //    cemcd = c + d;
            //    cemcd = cemcd % 1000;
            //    netice = netice + cemcd;
            //    e2 = e;
            //    while (e2 > 0)
            //    {
            //        sonReqeme = e2 % 10;
            //        cemE = cemE + sonReqeme;
            //        e2 = e2 / 10;
            //    }
            //    while (cemE > 0)
            //    {
            //        sonReqeme2 = cemE % 10;
            //        tersE = tersE * 10 + sonReqeme2;
            //        cemE = cemE / 10;
            //    }
            //    netice = netice + tersE;
            //    netice = netice * 100 + 11;
            //    while (e > 0)
            //    {
            //        sonReqeme3 = e % 10;
            //        tersE2 = tersE2 * 10 + sonReqeme3;
            //        e = e / 10;
            //    }
            //    e = tersE2;
            //    int teke = 0;
            //    int i = 1;
            //    while (tersE2 > 0)
            //    {
            //        sonReqeme3 = tersE2 % 10;
            //        tersE2 = tersE2 / 10;
            //        if (i % 2 == 1)
            //        {
            //            teke = teke * 10 + sonReqeme3;
            //        }
            //        i++;
            //    }
            //    netice = netice - teke;
            //    neticeQaliqi = netice % 10;
            //    netice = netice / 10;
            //    netice = netice * 1000 + 88 * 10 + neticeQaliqi;
            //    Console.WriteLine(netice);
            #endregion






        }














































        static int ReadIntTask1()
        {
            int a;

        l1: Console.Write("a:");

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }


        static int ReadIntTask2(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }

        static int ReadIntTask3(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }

        static int ReadIntTask4(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static int ReadIntTask5(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }

        static int ReadIntTask6(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {

                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static int ReadIntTask7(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {

                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }

        static int ReadIntTask8(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {

                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }

        static int ReadIntTask9(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {

                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }


        static int ReadIntTask10(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {

                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static int ReadIntTask11(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {

                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static int ReadIntTask12(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {

                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }

        static int ReadIntTask13(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {

                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static int ReadIntTask14(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {

                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static int ReadIntTask15(string capture)
        {
            int a;

        l1: Console.Write(capture);

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {

                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static int number3()
        {
        l1: int a = ReadIntTask15("a:");
            if (a > 99 && a < 1000)
            {
                return a;
            }
            else
            {
                Console.WriteLine("daxil etdiyiniz reqem dogru araliqda deil");
                goto l1;
            }
        }
    }
    }
