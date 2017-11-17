using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorePanel : MonoBehaviour {
    private Player scriptPalyer;
    public GameObject Player;
    Text score;
    
    

    // Use this for initialization
    void Start () {
        score = this.GetComponent<Text>();
        // print this.GetComponent<>(Text);
        scriptPalyer = Player.GetComponent<Player>();
        score.text = "SCORE :";
    }
	
	// Update is called once per frame
	void Update () {
       int scoreFromPlayer= scriptPalyer.getScore();
        score.text = "SCORE " + scoreFromPlayer.ToString();
    }
   
}
