using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {

    private LevelManager levelmanager;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        levelmanager = FindObjectOfType<LevelManager>();
        levelmanager.LoadLevel("Lose");
    }

}
