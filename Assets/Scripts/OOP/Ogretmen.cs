using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogretmen : Ogrenci
{
    public string ad;
    protected void ogrenciVeOgretmenAdınıYolla(string ogretmenad,string ogrenciad)  //erişim belirtecini belirtmezsek varsayılan olarak private atanır.
    {
        ogrenciAdiVer(ogrenciad);
        Debug.Log("Ogretmen ad"+ogretmenad);
    }
}
