using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesajBir : MonoBehaviour
{
    void Start()
    {
        /* gameObject.SendMessage();
         * gameObject.BroadcastMessage();
         * */
        gameObject.SendMessage("ekranabas"); // Method ile çalışır. Oyunda başka bi görevi olan fonksiyonları tetiklemek için bunu kullanabiliriz.
        // Burada SendMessage'i gönderici ekranabas() metodunu ise alıcı olarak düşünebiliriz. Eğer gönderici alıcıyı bulamazsa hata verir.
        // Ama bazı durumlarda alıcı yok ise hata vermesini istemeyebiliriz bunun için şunu kullanabiliriz.Kendi scriptinde iş yapar.
        gameObject.SendMessage("ekranabasdasdsadasd", SendMessageOptions.DontRequireReceiver); // Bu komut ile alıcı olmasa bile hata vermez.


        // Broadcastmessage ise; Hiyerarşik yani parent-child ilişkili objelerde bütün childlardan çağırır. Yani ekranabas2 metodunun bulunduğu bütün child objelerde yazdırır.
        gameObject.BroadcastMessage("ekranabas2");


    }
    void ekranabas()
    {
        Debug.Log("ekrana bas");
    }
    void ekranabas2()
    {
        Debug.Log("ana objeden geliyorum ");
    }

    void Update()
    {
        
    }
}
