using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag =="Player"){
            player.GetComponent<PlayerManager>().lastCheckPoint = this.gameObject;
        }
    }
}
