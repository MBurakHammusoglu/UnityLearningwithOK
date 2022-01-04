using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Okul : Ogretmen
{

    public void butunAdlarıGetir(string ogretmenad,string ogrenciad,string ad)  //erişim belirtecini belirtmezsek varsayılan olarak private atanır.
    {
        
        ogrenciVeOgretmenAdınıYolla(ogretmenad,ogrenciad);
        Debug.Log("Okulun adi "+ad);
    }
}
