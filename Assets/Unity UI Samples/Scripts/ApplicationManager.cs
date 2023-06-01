using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplicationManager : MonoBehaviour {
	int carModel;
	public Text car;
	private void Start()
    {
		carModel = PlayerPrefs.GetInt("carModel", 0);
		car.text = "" + carModel;
	}
    public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}

	public void SetCar()
    {
		
		PlayerPrefs.SetInt("carModel", carModel == 0 ? 1 : 0);
		car.text = "" + carModel;
    }


	public void LoadScene(string sceneName){
		Time. timeScale = 1;
      SceneManager.LoadScene(sceneName);
      
  }
}
