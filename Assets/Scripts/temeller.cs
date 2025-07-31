using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class temeller : MonoBehaviour
{
    [SerializeField] public int puan;
    public bool isDeath;
    [SerializeField] public int say1;
    [SerializeField] public int say2;
    [SerializeField] public int girilensayi;
    [SerializeField] public int sinav1;
    [SerializeField] public int sinav2;
    [SerializeField] public int performansNotu;
    [SerializeField] public int aci1;
    [SerializeField] public int aci2;
    [SerializeField] public int aci3;
    [SerializeField] public int bagajKilo;
    [SerializeField] public int urun1;
    [SerializeField] public int urun2;

    [SerializeField] public int sayim1;
    [SerializeField] public int sayim2;
    [SerializeField] public string secim;
    int sonuc = 0;

    [SerializeField] public int gun;
    private void Start()
    {
        //Giriþ
        // print("meraha unity hoþgeldiniz");
        //  Debug.Log("bu biraz daha ileri seviye komut bunu kullanalým");

        //deðiþken tanýmlama
        /* int damage = 10;
         Debug.Log("verdiðiniz zarar : " + damage);
        */
        /*  double ondalikliBir = 1 / 3d;
          Debug.Log("Double sonuç : " + ondalikliBir);

          float ondalikliIki = 1 / 3f;
          Debug.Log("Float sonuç : " + ondalikliIki);
        */

        //String Tanýmlama

        /* string adSoyad = "Ali UYSUN";
         string kurum = "ERTEV";
         string sehir = "BURSA";


         Debug.Log("sayýn : " + adSoyad );
         Debug.Log("Kurum : " + kurum);
         Debug.Log("Þehir : " + sehir);
        */

        // char tanýmlama

        /*  char cinsiyet = 'E';
          Debug.Log("Cinsiyetiniz : " + cinsiyet);


          // Boolean Tanýmlama


          isDeath = false;

          Debug.Log("öldü mü ? " +isDeath);
        */

        //Aritmetik operatörler  + , - , /,  *

        //hard code
        /* int sayi1 = 10;
         int sayi2 = 20;
         int toplam=sayi1+ sayi2;
         Debug.Log("SAyýlarýn Toplamý :  " + toplam);

         // dinamik fakat start içinde 
         int toplam2 = say1 + say2;
         Debug.Log("girilen sayýlarýn Toplamý " + toplam2);
        */

        /* int sayi1 = 15;
         int sayi2 = 5;
         int fark = sayi1 - sayi2;
         Debug.Log("sayýlarýn Farký : " + fark);

         int sayi11 = 15;
         int sayi22 = 5;

         int carpim = sayi11 * sayi22;
         Debug.Log("sayýlarýn Çarpýmý : " + carpim);

         int sayim1 = 15;
         int sayim2 = 5;
         float bolme = sayim1 / sayim2;
         Debug.Log("sayýlarýn bolümü : " + bolme);

         // sayýnýn modu    a%b   a'nýn b'ye bölümünden kalan

         int a = 15;
         int b = 10;

         int kalan = a % b;
         Debug.Log(a+" sayýsýn "+b+" sayýsýna bölümünden kalan : " + kalan);
        */


        // Tekli Operatörler  x++,x-- ,++x,--x

        //x++ =     x=x+1  
        //x-- =    x=x-1
        //++x    önce 1 artýr sonra ata


        /* 
         * int puan = 0;
          puan++;
          puan++;
          puan++;
          puan--;
          puan--;
          ++puan;
          --puan;
          Debug.Log("Puan" + puan);
        */

        //Atama Operatörleri  = , += , -= , *= , /=
        /*
        int Score;// tanýmladýk
        Score = 10;// deðer atadýk
        Score += 10;
        Debug.Log("Skorumuz : " + Score);
        Score -= 5;
        Debug.Log("Skorumuz : " + Score);
        Score *= 2;
        Debug.Log("Skorumuz : " + Score);
        Score /= 5;
        Debug.Log("Skorumuz : " + Score);
        */

        // iliþkisel operatörler   <, >, <=, >=, != ,==
        /*  int sayi1 = 15;
          int sayi2 = 25;
          Debug.Log(sayi1 > sayi2);
          Debug.Log(sayi1 < sayi2);
          Debug.Log(sayi1 <= sayi2);
          Debug.Log(sayi1 >= sayi2);
          Debug.Log(sayi1 != sayi2); // != Eþit deðilse 
          Debug.Log(sayi1 == sayi2); // == Eþitse 
        */

        //Mantýksal Operatörler  && (ve)(and)  || (veya) or  !
        /* string kullaniciAdi = "ertev";
         string sifre = "1234";
         Debug.Log(kullaniciAdi == "ertev" && sifre == "1234");
        */
        /* string kullaniciAdi = "ertev";
        string sifre = "1234";
        Debug.Log(kullaniciAdi == "ertev1" || sifre == "1234");
        */

        /* int a = 5;
         int b = 10;
         Debug.Log(!(a == b));
        */

        // Tür dönüþümleri (casting)

        /* float ondalikSayi = 10 / 3f;
        Debug.Log(ondalikSayi);
        Debug.Log((int)ondalikSayi);
       */

        // Karar Yapýlarý  if-else

        /* int yas = 18;
         if (yas >= 18)
         {
             Debug.Log("Yertiþkindir");

         }
         else
         {
             Debug.Log("yetiþkin deðildir");
         }
        */

        // girilen sayýný(unity arayüzü) negatif-pozitif veya  sýfýra eþit olma durmunu kotrom eden kodlar

        /* if (girilensayi > 0)
         {
             Debug.Log("sayý poztiftir");
         }
         else if (girilensayi < 0)
         {
             Debug.Log("sayý negatiftir");
         }
         else
         {
             Debug.Log("sayý Sýfýrdýr");
         }
        */
        /*Kullanýcýdan iki sýnav ve bir performans notu girmesini isteyiniz. Girilen 3 notun ortalamasý 50 ve daha
         büyükse “Baþarýlý”; deðilse “Baþarýsýz” çýktýlarý veren kodu yazýnýz.
         
        b) Bir üçgenin iç açýlarý toplamý 180 derecedir. Kullanýcýnýn girdiði üç açý deðerine göre “Bu bir üçgendir.” ya
           da “Bu bir üçgen deðildir.” çýktýlarý veren kodu yazýnýz.
        
        c) Bir hava yolu firmasý en fazla 20 kilogram bagaj hakký vermektedir. 20 kilogramdan sonraki her kilogram
           için 10 TL ek ücret almaktadýr. Buna göre bagajý 20 kg ya da daha az olan yolculara “Herhangi bir ücret
           ödemeniz gerekmiyor.”; 20 kg’den fazla olanlar için de ne kadar ek ücret ödeneceðini hesaplayarak “Fazla
           bagaj için ….. TL ödemelisiniz.” çýktýlarýný veren kodu yazýnýz.
           Not: Bu soruda kilogram hesabýnda sadece tam sayýlarý dikkate alýnýz. Örneðin 28,70 kilogram olan bagaj
           için sadece 8 kg için ek ücret ödenmesi yeterlidir.
        
        ç) Kullanýcýnýn girdiði iki ürünün toplam fiyatý 200 TL ve altýysa “Ödenecek miktar=…. TL”; 200 TL’yi geçerse
          %25 indirim yaparak “Ödenecek miktar, indirimden sonra ….. TL’dir.” çýktýlarýný veren kodu yazýnýz.  */

        //ÇözümBir
        /* int toplam = sinav1 + sinav2+performansNotu;
         float ortalama = toplam / 3f;
         if (ortalama >= 50)
         {
             Debug.Log("Baþarýlý");
         }
         else
         {

             Debug.Log("Baþarýsýz");
         }
        */
        //çözüm2

        /* if ((aci1 + aci2 + aci3) == 180)
         {
             Debug.Log("üçgendir");
         }
         else 
         {
             Debug.Log("Üçgen deðildir");
         }*/

        //çözüm 3

        /* int aradakiTutar = bagajKilo - 20;
         if (bagajKilo <= 20) 
         {
             Debug.Log("herhangi bir ücret ödemeniz gerekmiyor");
         }
         else
         {
             aradakiTutar *= 10;
             Debug.Log("bagajýnýz için ödemeniz gereken tutar: " + aradakiTutar+"TL");
         }
        */


        //çözüm 4

        /* int toplamTutar = urun1 + urun2;

         if (toplamTutar <= 200) 
         {
             Debug.Log("Toplam Tutar : " + toplamTutar + "Tl");

         }
         else
         {
             int indirim=(toplamTutar*25)/100;
             toplamTutar = toplamTutar - indirim;
             Debug.Log("indirim Tutarýnýz : " + toplamTutar);
         }*/

        // switch -case 
        //girilen iki sayýyý 4 iþlemi yaptýralým
        /* switch (secim)
         {
             case "+":
                  sonuc = sayim1 + sayim2;
                // Debug.Log(sonuc);
                 break;
             case "-":
                  sonuc = sayim1 - sayim2;
               //  Debug.Log(sonuc);
                 break;
             case "*":
                  sonuc = sayim1 * sayim2;
               //  Debug.Log(sonuc);
                 break;
             case "/":
                 sonuc = sayim1 / sayim2;
                 Debug.Log(sonuc);
               break;
             default:
                 Debug.Log("yanlýþ seçim yaptýnz");
                 break;
         }
        */

        //haftanýn günlerini yazdýralým.

        switch (gun)
        {
            case 1:
                Debug.Log("Pazartesi");
                break;
            case 2:
                Debug.Log("salý");
                break;
            case 3:
                Debug.Log("Çarþamba");
                break;
            case 4:
                Debug.Log("Perþembe");
                break;
            case 5:
                Debug.Log("Cuma");
                break;
            case 6:
                Debug.Log("Cumartesi");
                break;
            case 7:
                Debug.Log("Pazar");
                break;
            default:
                Debug.Log("böyle bir gün yok");
                break;
        }


















    }
    private void Update()
    {
        // Debug.Log("Puan : " + puan);// konsola mesaj verdiriyoruz.


    }


}
