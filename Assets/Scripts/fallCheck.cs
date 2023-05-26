using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallCheck : MonoBehaviour
{
   public GameObject player;

    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag =="Player"){
            player.GetComponent<PlayerManager>().setFallTrue();
        }
    }
}
