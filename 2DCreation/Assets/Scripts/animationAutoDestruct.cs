using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationAutoDestruct : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float delay = 0.5f;

        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorClipInfo(0).Length + delay);
      //  Debug.Log("animation détruite");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
