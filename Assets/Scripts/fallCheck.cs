using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallCheck : MonoBehaviour
{
   public GameObject GC;

    private void Start()
    {
        GC = GameObject.FindGameObjectWithTag("GC");
    }
    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag =="Player"){
            GC.GetComponent<GameController>().setFallTrueGC();
        }
    }
}
