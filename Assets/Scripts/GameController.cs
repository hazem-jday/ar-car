using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject game;
    public Transform plane;
    bool begin = false;

    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;
    public static string TotalTimer;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    public GameObject PauseScreen;
    public GameObject HUD;

    public GameObject player;

    private void Start()
    {
        //Found();
        Physics.gravity = Vector3.zero;
        
    }
    private void Update()
    {
        if(begin)   {
            
            Physics.gravity = plane.up * -5f;

            MilliCount += Time.deltaTime *10;
            MilliDisplay = MilliCount.ToString("F0");
            MilliBox.GetComponent<Text>().text = ""+ MilliDisplay;

            if( MilliCount >= 10){
                MilliCount = 0;
                SecondCount+=1;
            }

            if( SecondCount <= 9){
                SecondBox.GetComponent<Text>().text = "0"+ SecondCount+ ".";
            } else {
                SecondBox.GetComponent<Text>().text = ""+ SecondCount+ ".";
            }

            if( SecondCount >= 60){
                SecondCount = 0;
                MinuteCount+=1;
            }

            if( MinuteCount <= 9){
                MinuteBox.GetComponent<Text>().text = "0"+ MinuteCount+ ".";
            } else {
                MinuteBox.GetComponent<Text>().text = ""+ MinuteCount+ ".";
            }
        }

    }
    public void Found()
    {
        begin = true;
        game.SetActive(true);
        HUD.SetActive(true);
        player.GetComponent<PlayerManager>().setFallTrue();
    }

    public void Lost()
    {
        game.SetActive(false);
    }

     public void GameFinished()
    {
        Time. timeScale = 0;
        TotalTimer = MinuteCount + " : " + SecondCount + " . " + MilliCount; 

    } 

    public void GamePaused()
    {
        PauseScreen.SetActive(true);
        Time. timeScale = 0;
    }

    public void GameResume()
    {   
        Time. timeScale = 1;
        PauseScreen.SetActive(false);
    }
}
