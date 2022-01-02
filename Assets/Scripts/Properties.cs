using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{/*
    public int altin;
    public int elmas;

    public int Altin
    {

        get
        {

            if (altin <= 50)
                return altin;
            else
                return 0;
        }
        set
        {
            elmas = 2;
            altin = value + degerekle(3);
        }

    }
    int degerekle (int deger)
    {
        return 3 * deger;

    }*/

    public int elmas;
    public int Elmas { get; private set; }
    /*
        get
            {      
                    return elmas;
            }
    set
    {        
        altin = value ;
    }
    */



    void Start()
    {
        Elmas = 40;
        Debug.Log(Elmas);
        Elmas = 20;
        Debug.Log(Elmas);

        /*
                Altin = 10 ;
                Debug.Log(Altin);
        */

        /* elmas =2;
         * 
         * altin = 20;
         Debug.Log(altin);*/

    }


    void Update()
    {

    }
}