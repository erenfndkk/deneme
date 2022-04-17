
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_Programming_Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SayacBuyukharf = 0;
            int SayacKucukHarf = 0;
            int SayacRakam = 0;
            int SayacSembol = 0;
            int SayacBosluk = 0;
            int puan = 0;

            Console.Write(" Lütfen şifrenizi giriniz : ");
            string password = Console.ReadLine();
            

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsWhiteSpace(password, i))
                    SayacBosluk++;
            }
            // sifrede bosluk Kontrolu icin
            if (SayacBosluk == 0)
            {
                //sifrenin karakter uzunluğunun kontrolu icin
                if (password.Length < 9)
                { Console.WriteLine("Şifrenizin en az dokuz karakter uzunluğunda olmalıdır. "); }
                else
                {
                    PasswordKontrol.PasswordAl(password);
                    SayacBuyukharf = PasswordKontrol.BuyukHarf();
                    SayacKucukHarf = PasswordKontrol.KucukHarf();
                    SayacRakam = PasswordKontrol.Rakam();
                    SayacSembol = PasswordKontrol.Sembol();

                if (SayacSembol == 0 || SayacRakam == 0 || SayacKucukHarf == 0 || SayacBuyukharf == 0)
                { Console.WriteLine("şifrenizde en az bir büyük harf, bir küçük harf, bir rakam ve bir sembol kullanmalısınız."); }
                else
                {
                    Console.WriteLine("******************************");
                    Console.WriteLine("Büyük harf sayısı : " + SayacBuyukharf);
                    Console.WriteLine("Kücük harf sayısı : " + SayacKucukHarf);
                    Console.WriteLine("Rakam sayısı : " + SayacRakam);
                    Console.WriteLine("Sembol sayısı : " + SayacSembol);
                    Console.WriteLine("******************************");

                    // puan hesaplamak için
                    if (SayacBuyukharf <= 2)
                    { puan += SayacBuyukharf * 10; }
                    else
                    { puan += 20; }
                    if (SayacKucukHarf <= 2)
                    { puan += SayacKucukHarf * 10; }
                    else
                    { puan += 20; }
                    if (SayacRakam <= 2)
                    { puan += SayacRakam * 10; }
                    else
                    { puan += 20; }

                    puan += SayacSembol * 10;

                    if (SayacSembol + SayacRakam + SayacKucukHarf + SayacBuyukharf == 9)
                    { puan += 10; }
                    if (puan >= 100)
                        { puan = 100; }

                    // puanı derecelendirmek icin
                    if (puan >= 90)
                    {
                        Console.WriteLine("Puanınız : " + puan + " , şifreniz güçlü ve kabul edilebilir. ");
                    }
                    else if (puan >= 70 && puan < 90)
                    {
                        Console.WriteLine("Puanınız : " + puan + " , şifreniz kabul edilebiir.");
                    }
                    else if (puan < 70)
                    {
                        Console.WriteLine("Puanınız : " + puan + ", şifreniz yeterince güvenli değil. Kabul edilemez.");
                    }
                }
            }
            }
            else
            { Console.WriteLine("Lütfen şifrenizi girerken boşluk kullanmayınız..."); }


            Console.ReadLine();
        }
    }
    static class PasswordKontrol
    {

        static int BuyukHarfSayisi = 0;
        static int KucukHarfSayisi = 0;
        static int RakamSayisi = 0;
        static int SembolSayisi = 0;
        static string password;

        public static void PasswordAl(string password1)
        {
            password = password1;
        }
        //buyuk harf sayisini hesaplamak için
        public static int BuyukHarf()
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    BuyukHarfSayisi++;
                }
            }
            return BuyukHarfSayisi;
        }
        //kucuk harf sayisini hesaplamak için
        public static int KucukHarf()
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z')
                {
                    KucukHarfSayisi++;
                }
            }
            return KucukHarfSayisi;

        }
        // rakam sayısını hesalamak için
        public static int Rakam()
        {
            for (int i = 0; i < password.Length; i++)
            {
                if ((Convert.ToInt32(password[i]) >= 48) && (Convert.ToInt32(password[i]) <= 57))
                {
                    RakamSayisi++;
                }
            }
            return RakamSayisi;
        }
        // sembol sayısını hesaplamak için
        public static int Sembol()
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (! ((Convert.ToInt32(password[i]) >= 48) && (Convert.ToInt32(password[i]) <= 57) ||
                    (Convert.ToInt32(password[i]) >= 97) && (Convert.ToInt32(password[i]) <= 122) ||
                    (Convert.ToInt32(password[i]) >= 65) && (Convert.ToInt32(password[i]) <= 90)))
                {
                    SembolSayisi++;
                }
            }
            return SembolSayisi;
        }

    }

}
