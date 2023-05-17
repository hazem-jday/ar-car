using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject game;
    public Transform plane;
    bool begin = false;
    private void Start()
    {
        Physics.gravity = Vector3.zero;
        
    }
    private void Update()
    {
        if(begin)
            Physics.gravity = plane.up * -9.81f;
    }
    public void Found()
    {
        begin = true;
        game.SetActive(true);
    }

    public void Lost()
    {
        game.SetActive(false);
    }
}
