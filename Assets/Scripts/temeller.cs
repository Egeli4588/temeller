using UnityEngine;

public class temeller : MonoBehaviour
{
    [SerializeField] public int puan;


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

        string adSoyad = "Ali UYSUN";
        string kurum = "ERTEV";
        string sehir = "BURSA";


        Debug.Log("say�n : " + adSoyad );
        Debug.Log("Kurum : " + kurum);
        Debug.Log("�ehir : " + sehir);






    }
    private void Update()
    {
        // Debug.Log("Puan : " + puan);// konsola mesaj verdiriyoruz.
        
    }


}
