using UnityEngine;

public class temeller : MonoBehaviour
{
    [SerializeField] public int puan;


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

        string adSoyad = "Ali UYSUN";
        string kurum = "ERTEV";
        string sehir = "BURSA";


        Debug.Log("sayýn : " + adSoyad );
        Debug.Log("Kurum : " + kurum);
        Debug.Log("Þehir : " + sehir);






    }
    private void Update()
    {
        // Debug.Log("Puan : " + puan);// konsola mesaj verdiriyoruz.
        
    }


}
