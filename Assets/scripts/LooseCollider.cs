using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Application.LoadLevel("Lose");
    }

}
