using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassVerilerininTumu : MonoBehaviour // mono sınıfı scripti unityde çalıştırmak için gerekli.
{
   Okul okul = new Okul();
    

    
    void Start()
    {
        okul.butunAdlarıGetir("burak","hammus","inönü");
    }

    
 


}
