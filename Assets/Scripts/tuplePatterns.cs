using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuplePatterns : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //string deger1 = "makas";
        //string deger2 = "tas";

        #region
        // Tuple Patterns
        string taskagitmakas(string bir, string iki) => (bir, iki) switch
        {
            ("tas", "kagit") => "Kagıt kazandi",
            ("tas", "makas") => "Tas kazandi",
            ("kagit", "tas") => "Kagıt kazandi",
            ("kagit", "makas") => "Makas kazandi",
            ("makas", "tas") => "Taskazandi",
            ("makas", "kagit") => "Makas kazandi",
            ("makas", "makas") => "Berabere",
            ("tas", "tas") => "Berabere",
            ("kağıt", "kağıt") => "Berabere",
            (_, _) => "Değerler boş"
        };
        #endregion

        Debug.Log(taskagitmakas("tas", "tas"));
        Debug.Log("Github deneme..");
        Debug.Log("Github deneme3...");
    }


    void Update()
    {

    }
}
