using UnityEngine;

public class erisim : MonoBehaviour
{
    [SerializeField] temeller temel;
    void Start()
    {

        temel.Toplama(5, 5);
        temel.Cikarma(6, 4);
        temel.Carpma(7, 4);
        temel.Bolme(8, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
