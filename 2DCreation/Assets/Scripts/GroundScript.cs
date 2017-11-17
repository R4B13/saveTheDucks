using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

    public GameObject explosion,objDeadBirds,creator,gameOver;
    private int deadBirds;
    private ScripteBombe scripteOfCreator;
    private gameOverScript scriptOfGameOver;
    // Use this for initialization
	void Start () {
        
        scripteOfCreator = creator.GetComponent<ScripteBombe>();
        scriptOfGameOver = gameOver.GetComponent<gameOverScript>();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag=="bombe"))
        {
        
            //Debug.Log("bombe bouum");
            Destroy(col.gameObject);
            Instantiate(explosion, col.transform.position, Quaternion.identity);
            
            
            
            
        }


        if (col.gameObject.tag == "birds")
        {
            deadBirds++;    
            
            Destroy(col.gameObject);
            Instantiate(objDeadBirds, col.transform.position, Quaternion.identity);
            //may be a better animation later 
            if (deadBirds == 3)
            {
                //fin de partie 
                Debug.Log("fin de partie (3 ratés");
                scriptOfGameOver.setGameOver();
                scripteOfCreator.setEndGame();



            }

        }
    }
    public int getDeadBirds()
    {
        return deadBirds;
    }
}
