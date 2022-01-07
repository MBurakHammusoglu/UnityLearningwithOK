using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invokeFunction : MonoBehaviour
{
    // Invoke : Belirli bir fonksiyonu belli bir sürede çalıştırır. 
    void Start()
    {
        // Invoke("yaziYaz",5f);
        InvokeRepeating("yaziYaz", 5f, 2f); // Bu fonksiyonda ilk çalısma sanıyesını ve sonradan kac sanıyede bir calısmasını istedigimizi yazıyoruz.
    }
    void yaziYaz()
    {
        Debug.Log("İnvokeeeeeeeee");
    }

    private void Update()
    {
        if (IsInvoking("yaziYaz")) // yaziYaz adında bi invoke sırada mı? Kullanılıyor mu yani
        {
            Debug.Log("Evet");
        }
        else
        {
            Debug.Log("Hayir");
        }


        if (Input.GetKeyDown("space"))
        {
            CancelInvoke(); // invoke metodunu durdurma
        }
    }
}
