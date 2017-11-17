using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripteBombe : MonoBehaviour {


    public GameObject leftBorder, RightBorder,Bombe,Birds;
    private float  intervaleBombe, tempsPlusIntervalBombe, tempsPlusIntervalBirds,intervalleBirds;
    bool endGame;
     
    float xSup, xInf;
    // Use this for initialization
    public void create(GameObject obj)
    {

        if (endGame == false) { 
                //generer une position aléatoire 
                float x = Random.Range(xInf + 2, xSup - 2);//generer avec une marge pour les bordure 
                float y = this.transform.position.y;
                float z = this.transform.position.z;
                Vector3 posAleatoire = new Vector3(x, y, z);
                Instantiate(obj, posAleatoire, Quaternion.identity);
        }
    

    }
    public void setEndGame()
    {
        endGame = true;
    }
    void Start () {
        endGame = false;
        intervaleBombe = 2.3F;
        intervalleBirds = 1.6F;
        
        tempsPlusIntervalBombe = intervaleBombe;
        tempsPlusIntervalBirds = intervalleBirds;
        xSup = RightBorder.transform.position.x;
        xInf = leftBorder.transform.position.x;


    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(Time.time);
        if (Time.time >= tempsPlusIntervalBombe)
        {
          
            //instantiate
            create(Bombe);
            tempsPlusIntervalBombe = tempsPlusIntervalBombe + intervaleBombe;


        }
        if (Time.time >= tempsPlusIntervalBirds)
        {
            //generer une position aléatoire 

            create(Birds);
            tempsPlusIntervalBirds = tempsPlusIntervalBirds + intervalleBirds;

        }


      
    }
   


}
