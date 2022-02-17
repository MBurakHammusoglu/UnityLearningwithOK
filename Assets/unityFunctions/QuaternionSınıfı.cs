using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class QuaternionSınıfı : MonoBehaviour
{
    public Transform hedef;

    void Start()
    {
      //transform.rotation=Quaternion.Euler(90,0,0); // rotasyonunu ayarlarız. 1 kere çalışır.

        transform.rotation = Quaternion.FromToRotation(Vector3.up,transform.forward);

        transform.rotation = Quaternion.identity; // rotasyonu sıfırlar.
    }


    void Update()
    {
        transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);

        /* Vector3 fark = hedef.position - transform.position;
         transform.rotation = Quaternion.LookRotation(fark, Vector3.up);


         float angle = Quaternion.Angle(transform.rotation, hedef.rotation);
         print(angle);


         transform.rotation= Quaternion.Inverse(hedef.rotation); */
    }
}
