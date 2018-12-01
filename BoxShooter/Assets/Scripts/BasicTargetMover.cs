using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour {

    public float spinSpeed = 180.0f;
    public float motionMagnitute = 0.1f;

    public bool doSpin = true;
    public bool doMotion = false;
    	
	// Update is called once per frame
	void Update () {

        if (doSpin) {
            //Rotate the gameobject around y axis
            gameObject.transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
        }

        if (doMotion) {
            //Move the gameobject along y axis
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitute);
        }
	}
}
