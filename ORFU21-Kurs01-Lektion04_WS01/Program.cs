using System;
using System.Globalization;

namespace ORFU21_Kurs01_Lektion04_WS01
{
    //class Matte_Ovn_1
    //    /*
    //     Deklarera två variabler av typen int och tilldela dem värderna 3 respektiv 4. Skriv
    //     ut summor av att addera de två siffrorna (Console.WriteLine)         
    //     */
    //{
    //    static void Main(string[] args)
    //    {
    //        //Enklaste sättet
    //        int talEtt = 3, talTva = 4;
    //        Console.WriteLine(talEtt + talTva);

    //        //String Composition
    //        int talSvar = talEtt + talTva;
    //        Console.WriteLine("{0} + {1} = {2}", talEtt, talTva, talSvar);

    //        //String Interpolation
    //        int talSvarTva = talEtt + talTva;
    //        Console.WriteLine($"{talEtt} + {talTva} = {talSvar}");
    //    }
    //}

    //class Matte_Ovn_2
    ///*
    // Deklarera en boolean med värdet sant och skriv ut variablen.
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //Enklaste sättet
    //        bool myBool = true;
    //        Console.WriteLine(myBool);
    //    }
    //}

    //class Matte_Ovn_3
    ///*
    // Läs in en sträng och skrivut dess längd addera med 10.
    //(Du kan få tag på en strängs längd genom att skriva mystr.Length, där "mystr" är din variabel)
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //Enklaste sättet
    //        string myString = Console.ReadLine();
    //        Console.WriteLine(myString.Length + 10);
    //    }
    //}

    //class Matte_Ovn_X1
    ///*
    //Följande uppgift kommer att ge oväntade resultat.
    //Deklarera två variabler av typen int och tilldela värderna 10 respektiv 20.
    //Skriv ut strängen "Summan är: " följt av summan av de två variablerna.
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //Enklaste sättet
    //        int myIntEtt = 10, myIntTva = 20;
    //        Console.WriteLine("Summan är: " + myIntEtt + myIntTva );
    //        //Man kan använda en till variabel att spara svaret i och sedan anropa den med en placeholder
    //        //eller en Interpolation t.ex
    //        int svar = myIntEtt + myIntTva;           
    //        Console.WriteLine("Summan är: {0}", svar); //Placeholder        
    //        Console.WriteLine($"Summan är: {svar}"); //Interpolation
    //    }
    //}

    //class Matte_Ovn_X2
    ///*
    //Deklarera två variabler av typen double och tilldela dem värderna 0,1 respektiv 0,2.
    //Skriv ut summan av de två värderna.
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //Enligt instruktionerna
    //        //            double myDoubleEtt = 0,1, myDoubleTva = 0,2;
    //        //            Console.WriteLine(myDoubleEtt + myDoubleTva);
    //        //När man ska deklarera doubles måste man använda . och inte , i siffrorna
    //        //Om man ska deklarera explicivt t.ex.
    //        double myDoubleEtt = 0.1, myDoubleTva = 0.2;
    //        Console.WriteLine(myDoubleEtt + myDoubleTva);
    //        //Svaret blir väldigt lång med många decimalplatser.
    //        //Man kan tvinga resultat att se finare ut genom att tvinga ett viss antal decimaler
    //        //att visas. Man gör det med att använda en variabel för att spara värdet på svaret,
    //        //sedan måste man konvertera det till en string och välja det specifika formatering
    //        //som ska användas = (varibalnamn.ToString(formatteringstyp)) t.ex.
    //        double svar = myDoubleEtt + myDoubleTva;
    //        Console.WriteLine(svar.ToString("N2"));
    //    }
    //}

    //class Matte_och_typecasting_ovn_1
    ///*
    //Deklarera en variabel av typen "double" med värde 12345,6789. Skriv ut värdet på
    //variablen. Skriv sen ut det igen men kasta värdet till en "float." Varför skiljer sig
    //resultaten åt?
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //enklaste sättet
    //        double myDouble = 12345.6789;
    //        float myFloat = (float)myDouble;

    //        Console.WriteLine(myDouble);
    //        Console.WriteLine(myFloat);

    //        Console.WriteLine((float)myDouble); // man kan köra en cast direkt såhär.

    //    //Resultaten blir annorlunda för att float är mindre precis än double. En del av
    //    //variablen myDouble går förlorad när den castas till en float.
    //    }
    //}

    //class Matte_och_typecasting_ovn_2
    ///*
    //Deklarera en variabel av typen "int" med värde 2_147_483_646. Skriv ut värdet.
    //Öka därefter värdet med 1 och skriv ut det igen. Öka värdet med 1 en gång till
    //och skriv ut det igen. Var resultatet förväntat
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //enklaste sättet
    //        //Att lägga ++ före talen betyder att myInt ökas med ett SEN visas.
    //        int myInt = 2_147_483_646;
    //        Console.WriteLine(myInt); //Visar variablen
    //        Console.WriteLine(++myInt); //Ökar variabeln med ett SEN visar
    //        Console.WriteLine(++myInt);

    //        //Att lägga ++ efter talen betyder att myInt visas SEN ökas med ett.
    //        int myIntTwo = 2_147_483_646;
    //        Console.WriteLine(myIntTwo); //Visar variabeln
    //        Console.WriteLine(myIntTwo++); //Visar variablen SEN ökar med ett
    //        Console.WriteLine(myIntTwo++);

    //        //Resultaten blev en overflow. myInt har gått över gränsen för vad Int variabel
    //        //typen klarar av och har loopat runt till negativa tal.
    //    }
    //}

    //class Matte_och_typecasting_ovn_3
    ///*
    //Deklarera en variabel av typen "ushort" med värde 65_535. Skriv ut värdet. Skriv
    //ut värdet igen med kasta det till en "short"
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //enklaste sättet
    //        ushort myUshort = 65_535;
    //        Console.WriteLine(myUshort);
    //        Console.WriteLine((short)myUshort); //Man kan casta direkt såhär
    //    }
    //}

    //class Konvertering_och_Formatering_ovn_1
    ///*
    //Läs in två tal och beräkna deras medelvärde. Skriv ut resultatet som en siffra med
    //3 decimaler.
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //enklaste sättet
    //        double myTalOne = Convert.ToDouble(Console.ReadLine());
    //        double myTalTwo = Convert.ToDouble(Console.ReadLine());

    //        double svar = (myTalOne + myTalTwo) / 2;

    //        Console.WriteLine(svar.ToString("N3")); //Only strings can be formatted.
    //    }
    //}

    //class Konvertering_och_Formatering_ovn_2
    ///*
    //Be användaren mata in en temperatur i Celcius. Konvertera värdet till Farenheit
    //och skriv ut det med ett decimal.
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //enklaste sättet
    //        Console.Write("Temperatur (i Celcius): ");
    //        double myCelcius = Convert.ToDouble(Console.ReadLine());

    //        double svar = (myCelcius * 1.8) + 32;

    //        Console.WriteLine("Temperatur : {0} Farenheit", svar.ToString("N1")); //Placeholder
    //        Console.WriteLine($"Temperatur : {svar.ToString("N1")} Farenheit"); //Interpolation
    //    }
    //}

    //class Konvertering_och_Formatering_ovn_3
    ///*
    //Använd string composition för att generera följande tabell:
    //Namn        Ålder
    //-----------------
    //Pelle       100
    //Olle         12
    //Molly        26
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //enklaste sättet
    //        string myFormat = "{0, -10} {1, 5}"; // formatting can be stored in string variables

    //        //call the formet first and it will be applied to the following placeholders
    //        Console.WriteLine(myFormat, "Namn", "Ålder");
    //        Console.WriteLine("----------------");
    //        Console.WriteLine(myFormat, "Pelle", "100");
    //        Console.WriteLine(myFormat, "Olle", "12");
    //        Console.WriteLine(myFormat, "Molly", "26");
    //        Console.WriteLine();

    //        //Formatting can be placed in line without using a string.
    //        Console.WriteLine("{0, -10} {1, 5}", "Namn", "Ålder");
    //        Console.WriteLine("----------------");
    //        Console.WriteLine("{0, -10} {1, 5}", "Pelle", "100");
    //        Console.WriteLine("{0, -10} {1, 5}", "Olle", "12");
    //        Console.WriteLine("{0, -10} {1, 5}", "Molly", "26");
    //    }
    //}

    //class Konvertering_och_Formatering_ovn_4
    ///*
    //Läs in ett decimaltal med svenskformattering (t.ex 1234,56) och skriv ut det med
    //brittisk valutaformatering.
    // */
    //{
    //    static void Main(string[] args)
    //    {
    //        //enklaste sättet
    //        double myPengarDouble = Convert.ToDouble(Console.ReadLine());

    //        //Default (system) culture info for currency (C)
    //        Console.WriteLine(myPengarDouble.ToString("C"));

    //        //"Using System.Globalization;" Must be placed at beginning. IMPORTANT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //        //British (en-GB) culture info for currency (C). MUST USE To.String!!!!!!!!
    //        Console.WriteLine(myPengarDouble.ToString("C", CultureInfo.GetCultureInfo("en-GB")));

    //        //INFO---- variable . converto to string ("number formatting", access CultureInfo.GetCultureInfor ("country code"))
    //    }
    //}

    //Oviktig-------------------------------------------------------------------------------------------------

    //class ForLoop_Test
    ///*
    ////Simple For-Loop
    // */

    //{
    //    static void Main(string[] args)
    //    {
    //        //Looper börjar alltid från "i". Om "i" är 0, kommer första linje att stå "0".      
    //        Console.Write("Till vilken siffra ska loopen loopa? ");
    //        int loopNum = Convert.ToInt32(Console.ReadLine());
    //        //for (int i = 0; i <= loopnum; i++) // loopen loopar medans "i" är mindre eller lika med loopnum. Total antal loopar är lika med loopNum + 1.
    //        //for (int i = 1; i <= loopNum; i++) // Här är "i" lika med 1. Total antal loopar är lika med loopNum.
    //        for (int i = 0; i < loopNum; i++) // Här kommer loopen att köra loopar tills loopNum är uppnådd, sedan avsluta. Loopen börjar på 0.
    //            {
    //            Console.WriteLine("Loop {0}", i);
    //        }
    //    }
    //}


    //class WhileLoop_Test
    ///*
    //Simple While-Loop
    // */
    //{
    //    static void Main(string[] args)
    //    {  
    //        bool isRunning = true;
    //        int i = 1;

    //        Console.Write("How many loops?: ");
    //        int myLoop = Convert.ToInt32(Console.ReadLine());

    //        while (isRunning)
    //        {

    //            if (i <= myLoop)
    //            {
    //                Console.WriteLine("Loop {0}", i++);
    //            }

    //            else if (i > myLoop)
    //            {
    //                Console.WriteLine("SLUT!!!!!");
    //                isRunning = false;
    //            }
    //        }
    //    }
    //}
}
