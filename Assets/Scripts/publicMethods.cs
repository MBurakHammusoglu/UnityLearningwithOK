using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class publicMethods : MonoBehaviour
{
    // Coroutine : İstenildiği zaman durdurulabilir ve belirli zaman aralıklarıyla çalışmasına karar verebiliriz. Update her karede çalışır. Coroutineler istediğimiz
    // zaman çalıştırıp durdurabiliriz. Yönetilebilir tekrarlık.Coroutine'lerin çağrılması başlatılması gerekir.

    private IEnumerator birinciCont;

    void Start()
    {
        float giris = 5.0f;
        
        StartCoroutine(Denemem()); // Coroutine çağırdık/başlattık.
        StartCoroutine(Deneme2());
        StartCoroutine(Deneme3());
        StartCoroutine(Deneme4(giris));
        StartCoroutine(Deneme5());
        birinciCont = Deneme6(10);
        StartCoroutine(birinciCont);


        
    }



    // 1 frame bekleyen coroutine
   IEnumerator Denemem()
    {
        Debug.Log("1. yazdirma");
        yield return null; // bir frame bekle demek.
        Debug.Log("2. yazdirma");
        // kodlar
        // bekleme zamanı
        // diğer kodlar
    }

    // 1 saniye bekleyen coroutine
    IEnumerator Deneme2()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("1 saniye beklerim");
    }
    // 10 saniye bekleyen coroutine
    IEnumerator Deneme3()
    {
        yield return new WaitForSeconds(10);
        Debug.Log("10 Saniye beklerim");
    }
    // Bekleme süresini dısardan alan coroutine
    IEnumerator Deneme4(float giris)
    {
        yield return new WaitForSeconds(giris);
        Debug.Log("Kaç sanıye beklememi dısardan veren coroutine");
    }
    // kendini sürekli çağıran ama 2 saniye bekleyen coroutine
    IEnumerator Deneme5()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Debug.Log("Her 5 saniyede 1 çalışan coroutine");
        }
    }
    // Coroutine'i istediğimiz zaman durdurmak
    IEnumerator Deneme6(float giris2)
    {
        while (true)
        {
            yield return new WaitForSeconds(giris2);
            Debug.Log("Coroutine durdur beniiiii");
        }
    }
    IEnumerator Deneme7()
    {
        yield return new WaitForFixedUpdate(); // bu komut bütün scriptlerdeki fixedupdate komutlarının bitmesini bekler
        yield return StartCoroutine(Deneme8()); // bir coroutine bittiğinde diğer coroutini başlatabiliyoruz.
        Debug.Log("Kaç sanıye beklememi dısardan veren coroutine");
    }
    IEnumerator Deneme8( )
    {
        Debug.Log("Ben sonradam oldum");
        yield return null;
    }







    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StopCoroutine(birinciCont);
            // bütün coroutinleri tek tek yukarıdaki gibi kapatmamak için
            StopAllCoroutines(); // metodunu kullanabiliriz.
        }
    }
    





}
