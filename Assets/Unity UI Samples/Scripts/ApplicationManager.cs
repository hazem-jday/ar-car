using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplicationManager : MonoBehaviour {
	int carModel;
	public Text car;
	public Image red, green;


	private void Start()
	{
		carModel = PlayerPrefs.GetInt("carModel", 0);
		if (red != null && green != null)
		{

		
			if (carModel == 0)
			{
			
				red.gameObject.SetActive(true);
				green.gameObject.SetActive(false);
			}
			else
			{
				red.gameObject.SetActive(false);
				green.gameObject.SetActive(true);
			}
		}
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
		carModel = PlayerPrefs.GetInt("carModel", 0);
		if (red != null && green != null)
		{
			if (carModel == 0)
			{
				red.gameObject.SetActive(true);
				green.gameObject.SetActive(false);
			}
			else
			{
				red.gameObject.SetActive(false);
				green.gameObject.SetActive(true);
			}
		}
	}


	public void LoadScene(string sceneName){
		Time. timeScale = 1;
      SceneManager.LoadScene(sceneName);
      
  }
}
