using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public float speed=20.0F;
    private int compteurBirds;
    
    private gameOverScript scriptOfGui;
    
    public GameObject creator,explosion,gameOver,scoreText;
    private ScripteBombe scripeOfCreator;
    
    // Use this for initialization
	void Start () {
        scripeOfCreator = creator.GetComponent<ScripteBombe>();
        compteurBirds = 0;
        scriptOfGui = gameOver.GetComponent<gameOverScript>();
	}
    public int  getScore()
    {
        return compteurBirds;
    }
	
	// Update is called once per frame
	void Update () {
        float mouvement = Input.GetAxis("Horizontal");
        //mouvement *= Time.deltaTime;
        if ((this.transform.position.x < 20) && (this.transform.position.x > -20))
        {
            this.transform.Translate(mouvement, 0, 0);

        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "bombe":
                
                Debug.Log("Fin de Partie");
                //fin de partie
                
                scripeOfCreator.setEndGame();//arréter la génération des bombes et des oiseaux
                scriptOfGui.setGameOver();//afficher le game over
                Instantiate(explosion, this.transform.position, Quaternion.identity);//créer l animation de l'explosion 
                Destroy(this.gameObject);//detruire le chapeau
                Destroy(collision.gameObject);//detruire la bombe
                break;

            case "birds":
                Destroy(collision.gameObject);//detruire l'oiseau
                compteurBirds++;//incrémenter le score
                break;

            case "rightBorder":
                
                this.transform.position = new Vector3(-18F, -8, 0);
                //transporter le chapeau droite vers gauche
                break;

            case "leftBorder":
                //transporter le chapeau de la gauche vers la droite 
                this.transform.position = new Vector3(18, -8, 0);
                break;

        }
        
    }
    
}
