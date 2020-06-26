using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventLook : MonoBehaviour
{
	public GameObject fase3;
	public GameObject menu;
	public void ChangeScene()
	{
		if (fase3)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
		}

		if (menu)
		{
			SceneManager.LoadScene("MENU");
		}
		
	}
}
