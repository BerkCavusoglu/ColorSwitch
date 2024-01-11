using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunbitisi : MonoBehaviour
{
    public MeshRenderer kare1, kare2;
    void Start()
    {
        
    }

    void Update()
    {
        if(kare1.material.name == kare2.material.name) {
            Debug.Log("Tebrikler Renkler Ayni");
        }
    }
}
