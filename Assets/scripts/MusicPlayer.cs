using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer obj = null;

	// Use this for initialization
	void Start () {
        print(obj);
        if (obj != null)
        {
            Destroy(gameObject);
           // print("Game object destoryed");
            print("i am destory");
        } else {
            obj = this;
            GameObject.DontDestroyOnLoad(gameObject);
            print("i am don't destory");
        }

		GameObject.DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
