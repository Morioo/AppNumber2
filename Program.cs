using System;




public interface IZarowka

{
    void Wlacz();//on

    void Wylacz();  // off

    void zmienStan();

    void ZmienKolor(string nowyKolor);                      //color


}


public class Zarowka : IZarowka
{ 
    private bool stan;                      // True on, flase off
    private int moc;                            // power
    private string kolor; // color



    public Zarowka()

    {

        moc = 60;
        kolor = "biały";
        stan = false;  // default off



    }

    // method on

    public void Wlacz()

    {
        stan = true;

        Console.WriteLine($"Żarówka {kolor}, {moc}W została włączona.");
    }

    //methon off
    public void Wylacz()

    {
        stan = false;

        Console.WriteLine($"Żarówka {kolor}, {moc}W została wyłączona.");


    }


    public void zmienStan()
    {

        if (stan)
        {

            Wylacz();
        }

        else

        {

            Wlacz();
        }
    }

    // change color
    public void ZmienKolor(string nowyKolor)

    {
        kolor = nowyKolor;

        Console.WriteLine($"kolor żarówki został zmieniony na {kolor}.");



    }
}


public class Zarowkazarzadzanie
{



    public void ZmienStanZarowki(IZarowka zarowka)

    {
        zarowka.zmienStan();


    }


    public void ZmienKolorZarowki(IZarowka zarowka, string nowyKolor)



    {

        zarowka.ZmienKolor(nowyKolor);//change color



    }




}


public class Program                            //start point
{

    public static void Main(string[] args)
    {

        Zarowka zarowka1 = new Zarowka();  //default first

        Zarowka zarowka2 = new Zarowka();


        Zarowkazarzadzanie zarzadzanie = new Zarowkazarzadzanie();


        Console.WriteLine("Zmieniam stan pierwszej żarówki:");
        zarzadzanie.ZmienStanZarowki(zarowka1);                                 //on first bulb


        Console.WriteLine("Zmieniam kolor pierwszej żarówki na żółty:");

        zarzadzanie.ZmienKolorZarowki(zarowka1, "żółty");


        Console.WriteLine("Zmieniam stan drugiej żarówki:");
        zarzadzanie.ZmienStanZarowki(zarowka2);             // on second bulb


        Console.WriteLine("Zmieniam stan pierwszej żarówki ponownie:");

        zarzadzanie.ZmienStanZarowki(zarowka1);                     // off first 


        Console.WriteLine("Zmieniam kolor drugiej żarówki na żółty:");
        zarzadzanie.ZmienKolorZarowki(zarowka2, "żółty");


        Console.WriteLine("Zmieniam stan drugiej żarówki ponownie:");


        zarzadzanie.ZmienStanZarowki(zarowka2); // off second
    }





}
