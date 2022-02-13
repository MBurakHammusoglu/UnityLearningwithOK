using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeYokEtme : MonoBehaviour
{
    void Start()
    {
        //destroy ile istediğimiz objeyi yok ederiz.
        //Destroy(gameObject);

        //belirli bi süre sonra yok etmek istiyorsak
        //Destroy(gameObject,2f);//virgül atıp süreyi yazarız 2sn geçtikten sonra yok edecektir.
        
        // peki şu şekilde yazarsak
        //Destroy(this); // script dosyasını siler.
        
        //Objeye ait componenti silmek istersek;
        Destroy(GetComponent<BoxCollider>());
    }

    
}
