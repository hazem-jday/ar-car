using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
 
public class ResetBTN : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
 
public bool buttonPressed;
public GameObject player;

private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
private void Update()
    {
        if(buttonPressed){
            player.GetComponent<PlayerManager>().setFallTrue();
            buttonPressed = false;
        }
    }
public void OnPointerDown(PointerEventData eventData){
     buttonPressed = true;
}
 
public void OnPointerUp(PointerEventData eventData){
    buttonPressed = false;
}
}