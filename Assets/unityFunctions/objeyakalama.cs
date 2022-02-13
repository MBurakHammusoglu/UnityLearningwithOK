using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeyakalama : MonoBehaviour
{
    GameObject benim;
    GameObject[] cokluObjeYakalama;
    public GameObject disaridan;
    void Start()
    {
        #region
        // Find metodu oyundaki bütün sahnelerde arama yapar dolayısıyla performansı düşürür(12-13).Update metodu içinde kullanılması tavsiye edilmez.
        // çünkü update fonksiyonu her kare çalışır ve find metoduda her karede çalışacağı için sistemi çok yorar.Değişkene tanımlayarak kullanılması tavsiye edilir(7,18,19).
        //GameObject.Find("Parent").GetComponent<ilkscript>().yas = 25; // Objenin isminden yakalama
        //GameObject.Find("Parent/child").GetComponent<ilkscript>().yas = 15; // Hiyerarşik yakalama

        /*
        // Tavsiye edilen kullanım şekli
        benim = GameObject.Find("Parent");
        benim.GetComponent<ilkscript>().yas = 25;
        benim.GetComponent <ilkscript>().yas = 15;
        */
        // Tag'e göre yakalama
        //benim = GameObject.FindWithTag("Player");

        //benim = GameObject.FindWithTag("Player").GetComponent <ilkscript>().yas=25; // Hata veriyor çünkü withtag işlemlerinde int bi değeri gameobject'e eşitleyemeyiz.
        //şu şekilde yaparsak bir sorun olmaz
        //benim = GameObject.FindWithTag("Player"); // ilk olarak tagten yakalarız.
        //benim.GetComponent<ilkscript>().yas=25; // sonra componente erişiriz.

        //FindTag'de ise söyle bi dezavantaj vardır, bir hiyerarşi içinde Player tagında birden fazla obje var ise sadece ilk objeyi yakalar. Birden çok objeyi yakalamak için ise
        //şöyle bi metodu kullanabiliriz.
        //Anlatım: gameobject dizisini olustururuz çünkü birden çok tagı yakalayacağız. Ardından findgameobjectswithtag fonksiyonu ile tagımızı yazdık
        //foreach döngüsü açtık çünkü kaç defa döneceğini bilmiyoruz çünkü kaç tane player tagı var bilmiyoruz.*/
        /*
        cokluObjeYakalama = GameObject.FindGameObjectsWithTag("Player");
        
        foreach (var item in cokluObjeYakalama)
        {
            item.GetComponent<ilkscript>().yas = 25;
        }
        */

        // Bir başka yöntem ise public bi gameobject olusturup(9) yakalamadık istedigimiz objeyi inspector panelinden belirlemek.
        //disaridan.GetComponent<ilkscript>().yas=25;
        #endregion // find metodu
        #region
        /* 
         * getcomponent ne işe yarıyor?
        /*gameObject demek su an içinde bulundugumuz objedir. compenenti çağırdıktan sonra bizden yakalamk istediğimiz componentin tipini belirtmemizi 
         * istiyor tipini typeof parametresi ile belirliyoruz daha sonra as takısı kullandıktan sonra tipi tekrar yazıyoruz kupume eşitlememizin sebebi ise buradan
         * gelecek değeri bi yere tanımlamamız gerektiğidir.
         * 
        BoxCollider kupum = gameObject.GetComponent(typeof(BoxCollider)) as BoxCollider;
        kupum.isTrigger = true;
        // bir diğer yöntem ise typeof yazmadan tırnak içinde yakalamak istediğimiz componentin ismini yazsakta olur
        BoxCollider kupum2 = gameObject.GetComponent("BoxCollider") as BoxCollider;
        // gameObject'in önemini biraz daha anlayabilmek için

        if (gameObject.GetComponent(typeof(BoxCollider)) as BoxCollider){
            gameObject.name = "ben degistim";
        }

        */
        #endregion
        #region
        // bir yöntem daha 
        Light ısık = (Light)FindObjectOfType(typeof(Light));
        if (ısık)
        {
            Debug.Log("Evet ısık var " + ısık.name);
        }
        else
        {
            Debug.Log("ısık yok");
        }
        #endregion
        #region
        // peki objeleri aktif pasif nasıl yapabiliriz?
        gameObject.SetActive(true); /* pasif yapar true aktif yapar. Bir obje pasifse kendini aktifleştiremez, ama aktifse pasifleştirebilir
                                      * yani biz true yaptıgımızda obje pasifse(bu objeyi inspectordan pasif yaptık) hiçbir işlev yerine getiremez
                                      * dolayısıyla kendini aktif yapacak script bu script ama obje pasif oldugu için calısmıyor o yüzden aktif olmaz.*/

        if (gameObject.activeSelf) // activeSelf objenin aktif olup olmadıgını kontrol eder ve cevabı gönderir
        {
            Debug.Log(gameObject.activeSelf);
        }
        #endregion
        #region
        // Tag'den obje yakalama. CompareTag kullanılması tavsiye edilir daha performanslı
        if (gameObject.CompareTag("Dusman"))
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }
        #endregion
        #region 
        /* component ekleme işlemleri; Bazen kod ile component eklemek isteyebiliriz bunun sebebi oyun basında bazı yerlerde kullanmayacagımız
         tüm componentleri eklemek performans kaybına yol açabilir dolayısıyla kullanacagımız yerde kod ile eklemek zorunda kalabiliriz.*/
        Rigidbody rg =gameObject.AddComponent<Rigidbody>() as Rigidbody;
        rg.isKinematic = true;
        //typeoflu kullanımı
        SphereCollider sc = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
        sc.isTrigger = true;


        #endregion

    }


}
