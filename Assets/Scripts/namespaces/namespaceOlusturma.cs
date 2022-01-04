using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ---------Namespace-------
// namespaceler sınıfları kapsar. sınıfları içinde barındırır. 
// Eş zamanlı bir kodlama yapılırken kullanılan method ve sınıfların isimleri aynı olduğu takdirde kodların çakışmaması için namespace kullanılır


namespace dusmanyonetimi
{
    public class dusman
    {
        public void saglik()
        {
            Debug.Log("1. namespace Saglık 100");
        }


    }
   
}
namespace dusmanyonetimi2
{
    public class dusman
    {
        public void saglik()
        {
            Debug.Log("2. namespace Saglık 100");
        }


    }
  
}


