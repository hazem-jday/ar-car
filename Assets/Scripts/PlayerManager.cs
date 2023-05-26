using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject lastCheckPoint;
    bool fall = false;
    public Vector3 offset = new Vector3(0f,0f,0f);

    // Update is called once per frame
    void Update()
    {
        if (fall == true){
            this.transform.rotation = lastCheckPoint.transform.rotation;
            this.transform.position = lastCheckPoint.transform.position + offset;
            fall = false;
        }
    }

    public void setFallTrue(){
        fall=true;
    }
}
