using JetBrains.Annotations;
using System.Collections.Generic;
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
    string unity6 = "Unity6";
    string newText = "";


    [SerializeField] public int baslangicSayisi;
    [SerializeField] public int bitisSayisi;


    [SerializeField] public int girilenSayim;
    private void Start()
    {
        //Giri�
        // print("meraha unity ho�geldiniz");
        //  Debug.Log("bu biraz daha ileri seviye komut bunu kullanal�m");

        //de�i�ken tan�mlama
        /* int damage = 10;
         Debug.Log("verdi�iniz zarar : " + damage);
        */
        /*  double ondalikliBir = 1 / 3d;
          Debug.Log("Double sonu� : " + ondalikliBir);

          float ondalikliIki = 1 / 3f;
          Debug.Log("Float sonu� : " + ondalikliIki);
        */

        //String Tan�mlama

        /* string adSoyad = "Ali UYSUN";
         string kurum = "ERTEV";
         string sehir = "BURSA";


         Debug.Log("say�n : " + adSoyad );
         Debug.Log("Kurum : " + kurum);
         Debug.Log("�ehir : " + sehir);
        */

        // char tan�mlama

        /*  char cinsiyet = 'E';
          Debug.Log("Cinsiyetiniz : " + cinsiyet);


          // Boolean Tan�mlama


          isDeath = false;

          Debug.Log("�ld� m� ? " +isDeath);
        */

        //Aritmetik operat�rler  + , - , /,  *

        //hard code
        /* int sayi1 = 10;
         int sayi2 = 20;
         int toplam=sayi1+ sayi2;
         Debug.Log("SAy�lar�n Toplam� :  " + toplam);

         // dinamik fakat start i�inde 
         int toplam2 = say1 + say2;
         Debug.Log("girilen say�lar�n Toplam� " + toplam2);
        */

        /* int sayi1 = 15;
         int sayi2 = 5;
         int fark = sayi1 - sayi2;
         Debug.Log("say�lar�n Fark� : " + fark);

         int sayi11 = 15;
         int sayi22 = 5;

         int carpim = sayi11 * sayi22;
         Debug.Log("say�lar�n �arp�m� : " + carpim);

         int sayim1 = 15;
         int sayim2 = 5;
         float bolme = sayim1 / sayim2;
         Debug.Log("say�lar�n bol�m� : " + bolme);

         // say�n�n modu    a%b   a'n�n b'ye b�l�m�nden kalan

         int a = 15;
         int b = 10;

         int kalan = a % b;
         Debug.Log(a+" say�s�n "+b+" say�s�na b�l�m�nden kalan : " + kalan);
        */


        // Tekli Operat�rler  x++,x-- ,++x,--x

        //x++ =     x=x+1  
        //x-- =    x=x-1
        //++x    �nce 1 art�r sonra ata


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

        //Atama Operat�rleri  = , += , -= , *= , /=
        /*
        int Score;// tan�mlad�k
        Score = 10;// de�er atad�k
        Score += 10;
        Debug.Log("Skorumuz : " + Score);
        Score -= 5;
        Debug.Log("Skorumuz : " + Score);
        Score *= 2;
        Debug.Log("Skorumuz : " + Score);
        Score /= 5;
        Debug.Log("Skorumuz : " + Score);
        */

        // ili�kisel operat�rler   <, >, <=, >=, != ,==
        /*  int sayi1 = 15;
          int sayi2 = 25;
          Debug.Log(sayi1 > sayi2);
          Debug.Log(sayi1 < sayi2);
          Debug.Log(sayi1 <= sayi2);
          Debug.Log(sayi1 >= sayi2);
          Debug.Log(sayi1 != sayi2); // != E�it de�ilse 
          Debug.Log(sayi1 == sayi2); // == E�itse 
        */

        //Mant�ksal Operat�rler  && (ve)(and)  || (veya) or  !
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

        // T�r d�n���mleri (casting)

        /* float ondalikSayi = 10 / 3f;
        Debug.Log(ondalikSayi);
        Debug.Log((int)ondalikSayi);
       */

        // Karar Yap�lar�  if-else

        /* int yas = 18;
         if (yas >= 18)
         {
             Debug.Log("Yerti�kindir");

         }
         else
         {
             Debug.Log("yeti�kin de�ildir");
         }
        */

        // girilen say�n�(unity aray�z�) negatif-pozitif veya  s�f�ra e�it olma durmunu kotrom eden kodlar

        /* if (girilensayi > 0)
         {
             Debug.Log("say� poztiftir");
         }
         else if (girilensayi < 0)
         {
             Debug.Log("say� negatiftir");
         }
         else
         {
             Debug.Log("say� S�f�rd�r");
         }
        */
        /*Kullan�c�dan iki s�nav ve bir performans notu girmesini isteyiniz. Girilen 3 notun ortalamas� 50 ve daha
         b�y�kse �Ba�ar�l��; de�ilse �Ba�ar�s�z� ��kt�lar� veren kodu yaz�n�z.
         
        b) Bir ��genin i� a��lar� toplam� 180 derecedir. Kullan�c�n�n girdi�i �� a�� de�erine g�re �Bu bir ��gendir.� ya
           da �Bu bir ��gen de�ildir.� ��kt�lar� veren kodu yaz�n�z.
        
        c) Bir hava yolu firmas� en fazla 20 kilogram bagaj hakk� vermektedir. 20 kilogramdan sonraki her kilogram
           i�in 10 TL ek �cret almaktad�r. Buna g�re bagaj� 20 kg ya da daha az olan yolculara �Herhangi bir �cret
           �demeniz gerekmiyor.�; 20 kg�den fazla olanlar i�in de ne kadar ek �cret �denece�ini hesaplayarak �Fazla
           bagaj i�in �.. TL �demelisiniz.� ��kt�lar�n� veren kodu yaz�n�z.
           Not: Bu soruda kilogram hesab�nda sadece tam say�lar� dikkate al�n�z. �rne�in 28,70 kilogram olan bagaj
           i�in sadece 8 kg i�in ek �cret �denmesi yeterlidir.
        
        �) Kullan�c�n�n girdi�i iki �r�n�n toplam fiyat� 200 TL ve alt�ysa ��denecek miktar=�. TL�; 200 TL�yi ge�erse
          %25 indirim yaparak ��denecek miktar, indirimden sonra �.. TL�dir.� ��kt�lar�n� veren kodu yaz�n�z.  */

        //��z�mBir
        /* int toplam = sinav1 + sinav2+performansNotu;
         float ortalama = toplam / 3f;
         if (ortalama >= 50)
         {
             Debug.Log("Ba�ar�l�");
         }
         else
         {

             Debug.Log("Ba�ar�s�z");
         }
        */
        //��z�m2

        /* if ((aci1 + aci2 + aci3) == 180)
         {
             Debug.Log("��gendir");
         }
         else 
         {
             Debug.Log("��gen de�ildir");
         }*/

        //��z�m 3

        /* int aradakiTutar = bagajKilo - 20;
         if (bagajKilo <= 20) 
         {
             Debug.Log("herhangi bir �cret �demeniz gerekmiyor");
         }
         else
         {
             aradakiTutar *= 10;
             Debug.Log("bagaj�n�z i�in �demeniz gereken tutar: " + aradakiTutar+"TL");
         }
        */


        //��z�m 4

        /* int toplamTutar = urun1 + urun2;

         if (toplamTutar <= 200) 
         {
             Debug.Log("Toplam Tutar : " + toplamTutar + "Tl");

         }
         else
         {
             int indirim=(toplamTutar*25)/100;
             toplamTutar = toplamTutar - indirim;
             Debug.Log("indirim Tutar�n�z : " + toplamTutar);
         }*/

        // switch -case 
        //girilen iki say�y� 4 i�lemi yapt�ral�m
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
                 Debug.Log("yanl�� se�im yapt�nz");
                 break;
         }
        */

        //haftan�n g�nlerini yazd�ral�m.

        /*  switch (gun)
          {
              case 1:
                  Debug.Log("Pazartesi");
                  break;
              case 2:
                  Debug.Log("sal�");
                  break;
              case 3:
                  Debug.Log("�ar�amba");
                  break;
              case 4:
                  Debug.Log("Per�embe");
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
                  Debug.Log("b�yle bir g�n yok");
                  break;
          } */

        // string sorular�
        // hard code (start i�inde tan�mlay�n)
        // Bir string olu�turun ard�ndan bu stringin aras�nda bir bo�luk olacak �ekilde ekrana yazd�ral�m


        // Unity6 stringinin i�inden 6 ��kartal�m ve ka� harf oldu�unu yazd�ral�m

        /*  string kurum = "ERTEV";
          string sonuc = "";
          foreach (char harf in kurum)
          {
              sonuc += harf + " ";
          }
         // Debug.Log(sonuc);
        */

        //cycles D�ng�ler

        /*  for (int i = 0; i < 10; i++)
          {
              Debug.Log(i);
          }*/
        // ba�lang�� ve biti� say�s�n� unity aray�z�nden ald�m bunlar�n aras�ndaki say�lar� toplatal�m
        /*  int toplam = 0;
          int dongusayisi = 0;
          for (int i = baslangicSayisi;i <= bitisSayisi; i++) 
          {
              // ?
            //  dongusayisi++;
            //  Debug.Log(i);
            //  toplam += i;


          }
        //  Debug.Log("Aral�ktaki say�lar�n Toplam� :" + toplam);
        //  Debug.Log("Aral�ktaki say�lar�n Ortalmas� :" + toplam / dongusayisi);

          // girilen say�n�n fakt�riyelini hesapy�n�z for d�ng�s� ile
        */


        /* int mysonuc = 1;
         for (int i = 1; i <= girilenSayim; i++)
         {
             Debug.Log(i);
             mysonuc *= i;

         }
         Debug.Log("Hesaplanan say� :" + mysonuc);

         */

        /* int i = 0;
         while (i<=10) 
         {
             Debug.Log(i);
             i++;
         }
        */

        // fakt�riyel sorusunu birde while ��zelim.

        /* int result = 1;
         int j = 1;

         while (j<=girilenSayim)
         {
          result*= j;
             j++;
         }
        // Debug.Log(result);
        */

        //Diziler (Arrays)

        /* string[] isimler = new string[12];

       isimler[0] = "Hira";
       isimler[1] = "Elif";
       isimler[2] = "Buse";
       isimler[3] = "Mustafa Ate�";
       isimler[4] = "Mustafa Ay�k";
       isimler[5] = "izem";
       isimler[6] = "k�bra";
       isimler[7] = "Sudem";
       isimler[8] = "Ahmet";
       isimler[9] = "Berat";
       isimler[10] = "esma";
       isimler[11] = "neslihan";

       Debug.Log(isimler[5]);
       //
       for (int i = 0; i < isimler.Length; i++)
       { 
         //  Debug.Log(isimler[i]);
       }

         */


        /* string[] names = { "Ali", "veli", "hasan", "h�seyin" };
         //diziden rastgele bir eleman se�elim
         int randomIndex=Random.Range(0, names.Length);
         string randomName = names[randomIndex];
         //Debug.Log(randomName);
        */
        /* int[] sayilar = { 10, 20, 30, 40, 50 };

         for (int i = 0; i < sayilar.Length; i++)
         {

            // Debug.Log(sayilar[i]);
         }
        */


        // List kullan�m� 


        /* List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);
        numbers.Add(7);
        numbers.Add(8);
        numbers.Add(9);
        numbers.Add(10);
        foreach (int i in numbers) 
        {
          print(i);
        }

       List<string> isimler = new List<string>();

        isimler.Add("hira");
        isimler.Add("elif");
        isimler.Add("Ege");
        isimler.Add("m ate�");
        isimler.Add("m ay�k");
        isimler.Add("izem");
        isimler.Add("k�bra");
        isimler.Add("sudem");
        isimler.Add("berat");
        isimler.Add("ahmet");
        isimler.Add("esma");
        isimler.Add("neslihan");

        foreach (string s in isimler) 
        {
            print(s);
        
        }

        isimler.Remove("neslihan");

        foreach (string m in isimler)
        {
            print(m);

        }

        isimler.Insert(0, "neslihan");
        foreach (string n in isimler)
        {
            print(n);

        }

        if (isimler.Contains("Ali")) 
        {
            Debug.Log("Ali Bulundu");
        }
        else
        {
            Debug.Log("Ali Bulunamad�");
        }

        numbers.Clear();//listeyi temizledik.
        foreach (int n in numbers) 
        {
            Debug.Log(n);
        }

        */

        // Metodlar (Fonksiyonlar)

        /* for (int i = 0; i < 10; i++)
         {
             Ilkfonksiyonum();
         }
        */

        Ilkfonksiyonum();
        Toplama(5, 8);
        Cikarma(10, 5);
        Carpma(11, 5);
        Bolme(12, 3);
        // parametre alan de�er d�nd�rmeyen foknsiyon kullanarak 4 i�lemi ger�ekle�tiren fonksiyonlar� yaz�n�z




    }

    void Ilkfonksiyonum()
    {
        Debug.Log("merhaba bu benim ilk fonksiyonum");
    }

    public void Toplama(int a, int b)
    {

        print("say�lar�n Toplam� " + (a + b));

    }
    public void Cikarma(int a, int b)
    {
        print("say�lar�n Fark� " + (a - b));
    }

    public void Carpma(int a, int b)
    {
        print("say�lar�n �arp�m� " + (a * b));
    }
     public void Bolme(int a, int b)
    {
        print("say�lar�n B�l�m� " + (a / b));
    }

    private void Update()
    {
        // Debug.Log("Puan : " + puan);// konsola mesaj verdiriyoruz.

    }




}
