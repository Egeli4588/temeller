using JetBrains.Annotations;
using UnityEngine;

public class temeller : MonoBehaviour
{
    [SerializeField] public int puan;
    public bool isDeath;
    [SerializeField] public int say1;
    [SerializeField] public int say2;
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
        int sayi1 = 10;
        int sayi2 = 20;
        int toplam=sayi1+ sayi2;
        Debug.Log("SAyýlarýn Toplamý :  " + toplam);

        // dinamik fakat start içinde 
        int toplam2 = say1 + say2;
        Debug.Log("girilen sayýlarýn Toplamý " + toplam2);



    }
    private void Update()
    {
        // Debug.Log("Puan : " + puan);// konsola mesaj verdiriyoruz.
        
       
    }


}
