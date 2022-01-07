using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityTemelFunction : MonoBehaviour
{
    /* Monobehaviour unity'nin temel sınıfıdır. 
     
     
     
     
     
     */

    private void Awake()
    {
        // 1. öncelikteki ilk fonskiyondur. Dosya çalışır çalışmaz ilk çalışacak fonksiyondur.
        Debug.Log("Ben Awake ile geldim");
    }



    private void OnEnable()
    {
        //2. öncelikte çalışır. Dosyaya ait olan objenin aktif olması.Objenin durumuna göre hareket eder. Aktif ise çalışır 
        Debug.Log("Ben onEnable'dan geldim");
    }
    private void OnDisable()
    {
        //2. öncelikte çalışır onEnable'ın tersidir. Aktif degilse çalışır.(Sahnede görünmüyorsa)
    }



    void Start()
    {   //3. öncelikte çalışır.
        // Oyun çalıştığında sadece 1 kere çalışan fonksiyonlardır.
        Debug.Log("Ben Start'tan geldim");
    }





    // güncelleme func. sıraları       fixedupdate->update->lateupdate
    private void FixedUpdate()
    {
        Debug.Log("Ben Fixedupdate'ten sürekli geldim");

    }

    void Update()
    {
        Debug.Log("Ben update'ten sürekli geldim"); 
    }
    private void LateUpdate()
    {
        // Sahnedeki objelerdeki bütün update metodları çalıştırılıp bitirildikten sonra çalıştırılır.
        Debug.Log("Ben Lateupdate'ten sürekli geldim");

    }


}
