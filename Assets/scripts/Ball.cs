using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Paddle paddle;

    private Vector3 differenceBetweenBallPaddle;
    private bool GameHasStarted = false;
	// Use this for initialization
	void Start () {
        differenceBetweenBallPaddle = this.transform.position - paddle.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if ( !GameHasStarted ) { 
            this.transform.position = paddle.transform.position + differenceBetweenBallPaddle;
            if ( Input.GetMouseButtonDown(0) ) {
                GameHasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }
    }
}
