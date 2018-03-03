using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

    public int maxTimesHit; // keeping maximum number of times a brick can be hit
    public int timesHit;    // it will keep track of how many times a bricks been hit.

    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
        timesHit = 0;
        levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision) {
        timesHit++;
        if (timesHit >= maxTimesHit ) { Destroy(gameObject); }
        
    }

    // Todo we will remove this function later own because its just for testing purpose.
    void OccurWinCondition() {

        levelManager.LoadNextLevel();

    }

}
