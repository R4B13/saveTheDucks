using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour {

    Text gameOverText;
	// Use this for initialization
	void Start () {
        gameOverText = this.GetComponent<Text>();
        gameOverText.text = "";


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void setGameOver()
    {
        gameOverText.text = "Game Over";
    }

   
}
