using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainCameraMenu : MonoBehaviour {

	public void loadLevel()
    {

        SceneManager.LoadScene(1);
    }

    public void Quitter()
    {
        Application.Quit();
    }
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
