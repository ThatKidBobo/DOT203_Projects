using System;

class SayiKontrol
{
    private int _sayi;
    private bool _islemTamam;

    public int Sayi
    {
        get { return _sayi; }
        set { _sayi = value; }
    }

    public bool IslemTamam
    {
        get { return _islemTamam; }
        set { _islemTamam = value; }
    }

    static void Main(string[] args)
    {
        SayiKontrol kontrol = new SayiKontrol();
        kontrol.Calistir();
    }

    public void Calistir()
    {
        string deger = "";
        int sayi;
        bool islemtamam = false;

        Console.WriteLine("Hoşgeldiniz, bir sayı girin veya N tuşu ile çıkın.");

        while (islemtamam == false)
        {
            Console.WriteLine("");
            Console.WriteLine("Sayı gir: ");
            deger = Console.ReadLine();

            if (deger.ToUpper() == "N")
            {
                Console.WriteLine("İşlem sonlandırılıyor...");
                Environment.Exit(0);
            }
            else if (int.TryParse(deger, out sayi))
            {
                islemtamam = CiftTekKontrol(sayi);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Lütfen sayı girin.");
            }
        }
    }

    public bool CiftTekKontrol(int girileceksayi)
    {
        Sayi = girileceksayi;

        Console.WriteLine("");
        if (Sayi % 2 == 0)
        {
            Console.WriteLine("Sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Sayı tektir.");
        }

        IslemTamam = true;
        return IslemTamam;
    }
}