using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwanMove : MonoBehaviour {
    private int moveSpeed = 4;  //swan移动速度

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(22, 3, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > -22) {
            transform.Translate(transform.right  *- moveSpeed * Time.deltaTime);
        } else {
            transform.position = new Vector3(22, 3, 0);
        }
	}
}
