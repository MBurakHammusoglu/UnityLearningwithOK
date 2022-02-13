using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilkscript : MonoBehaviour
{
    public int yol;
    BoxCollider kup;
    [SerializeField] int maas;
    public int yas;

    void Start()
    {
        #region
        /* getcomponent kullanımı
        // Bu şekilde componenetleri değiştirmek önerilmez ve performansı çok etkiler(19,20,21). Yapmamız gereken değişken tanımlarız ve işlem yapacaksak o değişkeni kullanırız.
        // Unity'nin kullanmış oldugu her nesneyi tanımlayabiliriz. BoxCollider kup;(7) gibi. Daha sonra kup'u componentte eşitleriz(13). Boxcollider tipinde ürettiğimiz
        // nesne ile componentin özelliklerine erişiriz(15). 
        kup= GetComponent<BoxCollider>();
        kup.enabled= true;
        kup.isTrigger = true;
        kup.size = new Vector3(2, 2, 2);

        //GetComponent<BoxCollider>().enabled = false;
        //GetComponent<BoxCollider>().isTrigger = true;
        //GetComponent<BoxCollider>().size = new Vector3(2, 2, 2);

        //GetComponents<> bu komut; aynı obje içinde birden fazla aynı component varsa (örnek ses) hepsine toplu bir şekilde işlem yapabilmemizi sağlar.
        //Peki bu componenti nasıl tanımlarız(26), dizi olarak tanımlarız. Peki buna nasıl müdahele ederiz for döngüsü açarız(28) ve normal dizi işlemleri gibi müdahele ederiz.
        // En üstteki component 0. eleman

        BoxCollider[] kuplerim = GetComponents<BoxCollider>();
        for(int i =0; i<kuplerim.Length; i++)
        {
            kuplerim[i].isTrigger = false; // bütün componentlerin triggerını false yaptık
        }
        */
        #endregion
        // Hiyerarşik yani Parent-Child objelerde getcomponent kullanımı
        GetComponentInParent<AudioSource>().mute = true;
        GetComponentInParent<Rigidbody>().mass = 10f;     //InParent kullanımı üstteki aile elemanlarını yakalar. Yani scripti ortachild'ta calıstırdıgımız zaman
        GetComponentInParent<CapsuleCollider>().isTrigger = true;//(Çalışmayacaktır) 
        //ortachild'ın alt elemanı olan mostchild'ın elemanlarını yakalayamayız.Bunu yakalamak için alt eleman
        //component yakalama metodunu kullanırız aşağıdaki gibi

        GetComponentInChildren<CapsuleCollider>().isTrigger = true; // Alt eleman componenti yakalama

        //Parent-Child objelerde birden çok component yakalamak için bu metodları kullanabiliriz yine;
        // GetComponentsInChildren<>
        //GetComponentsInParent<>


    }






    void Update()
    {
        
    }
}
