using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerAi : MonoBehaviour
{
    public GameObject enemy;
    public GameObject lastCheckPoint;
    bool fall = false;
    public Vector3 offset = new Vector3(0f,0f,0f);
    private void Start()
    {
        lastCheckPoint = GameObject.FindGameObjectWithTag("FirstCheckPoint");
        setFallTrue();
    }
    // Update is called once per frame
    void Update()
    {
        if (fall == true){
            transform.rotation = lastCheckPoint.transform.rotation;
            transform.position = lastCheckPoint.transform.position + offset;
            fall = false;
            enemy.SetActive(true);
        }
    }

    public void setFallTrue(){
        fall=true;
    }
}
