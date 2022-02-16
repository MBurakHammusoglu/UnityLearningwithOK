using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformScript2 : MonoBehaviour

{
    public Transform hedef;
    public Transform hedef2;
    void Start()
    {
        //transform.position = new Vector3(2f, 3f, 5f); Pozisyonunu değiştirir
        //transform.position = new Vector3(transform.position.x,6f,transform.position.z); sadece y pozisyonu değişir diğer pozisyonları o anki pozisyonuyla aynı kalır.
        
        //hedef.transform.Rotate(90f,0f,0f,Space.Self); // kendi eksenini baz alarak dönme hareketi yapar.
        //hedef2.transform.Rotate(90f,0f,0f,Space.World); // uzay eksenini baz alarak dönme hareketi yapar daha tutarlı döner.

    }

    void Update()
    {
        hedef2.transform.LookAt(hedef.transform.position); /*Lookat komutuyla objeyi takip ederiz yani sürekli ona bakar güvenlik kamerası gibi. */
        //hedef.transform.Rotate(2f,4f,1f,Space.Self);
        //hedef2.transform.Rotate(2f, 4f, 1f, Space.World);
        //transform.Translate(transform.up*Time.deltaTime*2f);
    }
}
