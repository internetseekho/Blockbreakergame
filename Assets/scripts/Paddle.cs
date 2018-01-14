using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddlepositon = new Vector3(0f, this.transform.position.y, 0f);
        float mousePositionInBlock = (Input.mousePosition.x / Screen.width) * 16;
        paddlepositon.x = Mathf.Clamp(mousePositionInBlock, 0.5f, 15.5f);
        this.transform.position = paddlepositon;

    }
}
