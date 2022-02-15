using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformScripts : MonoBehaviour
{
    #region
    //1. kısım
    Vector2 a; // 2d oyunlar x,y
    Vector3 b; // 3d oyunlar x,y,z
    Vector4 c; // peki vektör4 ne? Genellikle gölgelendirme işlerinde yani tasarımsal olarak yapılmış modelleme gölgelendirme işlemlerinde 4. boyut olarak kullanılmakta.
    //Vector2Int d;
    //Vector3Int e; // intler değeri int olarak alır normal vectorler float olarak alır.
    Quaternion q;
    Vector3 vector;
    Vector3 vector2;
    #endregion
    #region
    //2. kısım
    // Vector3 static methodlar
    public Transform hedef;
    public Transform hedef2;
    private float baslangiczamani;
    #endregion
    void Start()
    {
        baslangiczamani = Time.time;

        /*
         * Time.time:
         * Time.deltaTime:
         * Time.timeScale:
         * */
        #region
        /* 1. kısım
        Debug.Log(transform.position); // Pozisyonu alırız.

        Debug.Log(transform.rotation); // Değer döndürmez çünkü saltokunur bir değer değil.Okumak için unity'nin Quaternion sınıfı kullanılır.

        Debug.Log(transform.localScale); // Scale'i alırız.

        vector=new Vector3(1f,1f,1f);
        vector2= new Vector3(2f,2f,2f);
        */
        #endregion
        #region
        //2. kısım
        // angle methodu: iki vektör arasındaki açıyı derece cinsinden verir.
        Vector3 mesafe = hedef.position - transform.position;

        float angle = Vector3.Angle(mesafe,transform.forward);
        Debug.Log(angle);
        if(angle < 5f)
        {
            Debug.Log("açı sağlandı");
        }
        #endregion
    }

    void Update()
    {
        #region
        /*1. kısım
        if (Vector3.Equals(vector, vector2))
        {
            Debug.Log("pozisyonlar aynı");
        }
        else Debug.Log("Pozisyonlar aynı değil");  /* Equals komutu ile pozisyonları karşılaştırırız. Tabii equals komutu her zaman tam doğru sonuç veremeyebilir
                                                    * bu tür karşılaştırmalarda matematiksel operatörler yani == operatörü kullanması bize kesin sonuç sağlayabilir.*/


        // Debug.Log(transform.position.normalized); // normalized komutu bize değerleri sürekli -1 ve 1 aralığında gösterir.

        /* Bir objenin transformunu nasıl değiştirebiliriz? Bizden Vector3 sınıfından bi parametre istiyor peki Vektör3 nedir?
        transform.Translate(new Vector3(2f,5f,3f) * 5f* Time.deltaTime); /* sürekli bu kadar birimde obje hareket eder. Time.deltatime her saniyede bu işlemi yapar.
                                                                      * Yani objenin bir anda uçup gitmesini biraz daha kontrol altına alırız. 5f hızını ayarlarız.
                                                                      * Vector.one fonksiyonu tüm değerlere 1f verilir Vector.zero 0f verir.
        
        Vector3.Magnitude(transform.position); // Bu komut bize  vectorun toplam uzunluğunu verir.
        Vector3.SqrMagnitude(transform.position); // Yine vectorun uzunlugunu hesaplar ama karesini alır. Bu daha performanslı ve hızlıdır.
        */
        #endregion
        #region
        //2. kısım
        //lerp metodu: iki obje arasında görünmeyen bir çizgi çizmemizi sağlar.
        transform.position = Vector3.Lerp(hedef.position,hedef2.position,)




        // distance metodu : iki vektör arasındaki mesafeyi döndürür
        float fark = Vector3.Distance(hedef.position,transform.position);
        Debug.Log("fark şudur"+fark);
        // angle methodu: iki vektör arasındaki açıyı derece cinsinden verir.
        Vector3 mesafe = hedef.position - transform.position;

        float angle = Vector3.Angle(mesafe, transform.forward);
        Debug.Log(angle);
        if (angle < 5f)
        {
            Debug.Log("açı sağlandı");
        }
        #endregion
    }
}
