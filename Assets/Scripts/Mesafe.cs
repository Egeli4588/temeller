using UnityEngine;

public class Mesafe : MonoBehaviour
{

    public Transform Kapi;
    public Transform Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float mesafe= HesaplaMesafe(Player.position,Kapi.position);
        Debug.Log("Oyuncu ile kapý arasýndaki mesafe: " + mesafe + "birim");
        
    }

    float HesaplaMesafe(Vector3 noktaA, Vector3 noktaB) 
    {
        return Vector3.Distance(noktaA, noktaB);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
