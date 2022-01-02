using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassFunction : MonoBehaviour 
{
    /*
     * namespace
            class // İşlemleri yani fonksiyonları yönetebilmemiz için ihtiyacımız var.
                 function // İşlem kümesi.

        /*
            *public  // Herkese açık
            *private // Aynı class içinde
            
            *protected // Miras alan sınıflar kullanabilir. Düz metot çağrılıyor gibi çağrılır.
            *miras alma // bir classın içinde başka bir classa ait olan fonk. ve değişkenleri kullanmak.




    
     */



    void Ahmet()
    {
        Debug.Log("Ben ahmete aitim");
    }
    void Ali()
    {

        Debug.Log("Ben aliye aitim");

    }
    void Ayse()
    {
        Debug.Log("Ben ayseye aitim");

    }
    private void Start()
    {
        Ahmet();
    }

}
