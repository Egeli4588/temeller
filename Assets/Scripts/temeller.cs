using JetBrains.Annotations;
using UnityEngine;

public class temeller : MonoBehaviour
{
    [SerializeField] public int puan;
    public bool isDeath;
    [SerializeField] public int say1;
    [SerializeField] public int say2;
    [SerializeField] public int girilensayi;
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

        if (girilensayi > 0) 
        {
            Debug.Log("say� poztiftir");
        } else if (girilensayi < 0) 
        {
            Debug.Log("say� negatiftir");
        }
        else
        {
            Debug.Log("say� S�f�rd�r");
        }


















    }
    private void Update()
    {
        // Debug.Log("Puan : " + puan);// konsola mesaj verdiriyoruz.


    }


}
