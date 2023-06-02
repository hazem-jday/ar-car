using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject manager;
    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GC");
    }
    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag =="Player"){
            manager.GetComponent<GameController>().GameFinished();
        }
    }
}
