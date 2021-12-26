using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propertyPatterns : MonoBehaviour
{
    string mulkTipi;
    string blokTipi;
    int aidatCarpanKatSayi = 2;
    void Start()
    {
        mulkTipi = "Daire";

        // Normal bir if-else kodlarý
        #region
        if (mulkTipi == "Daire")
        {
            Debug.Log(aidatCarpanKatSayi * 1.5);
        }
        else if (mulkTipi == "Villa") 
        {
            Debug.Log(aidatCarpanKatSayi * 2.5);
        }else if (mulkTipi == "Rezidans") 
        {
            Debug.Log(aidatCarpanKatSayi * 3.5);
        }
        else
        {
            Debug.Log("Tanýmsýz");
        }
        #endregion 
        
        
        // Tek koþullu bir Property Patterns örneði
        #region
        int aidatHesapla(propertyPatterns clasim, int aidatCarpanKatSayi) => clasim switch 
        {
            { mulkTipi: "Daire"} => aidatCarpanKatSayi*(int)1.5,
            { mulkTipi: "Villa" } => aidatCarpanKatSayi *(int)2.5,
            { mulkTipi: "Rezidans" } => aidatCarpanKatSayi *(int)3.5,
            _=>0   //varsayýlan deðer giriþ yok ise
            
        };
        #endregion
        mulkTipi = "Rezidans";
        Debug.Log(aidatHesapla(this, 2));

        // Birden çok koþullu Property Patterns örneði
        #region
        int aidatHesaplaIki(propertyPatterns clasimiki, int aidatCarpanKatSayi) => clasimiki switch
        {
            {mulkTipi:"Daire",blokTipi:"A"}=>aidatCarpanKatSayi*(int)1.5,
            { mulkTipi:"Rezidans",blokTipi:"A"}=>aidatCarpanKatSayi*(int)2.5,
            { mulkTipi:"Villa",blokTipi:"B"}=>aidatCarpanKatSayi*(int)5.5,
            _=>0

        };
        mulkTipi = "Villa";
        blokTipi = "B";
        Debug.Log(aidatHesaplaIki(this, 2));
        #endregion


    }


    void Update()
    {
        
    }
}
