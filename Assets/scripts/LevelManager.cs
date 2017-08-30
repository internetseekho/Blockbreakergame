using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel( string name ) {

        print( "Load Level " + name );
        Application.LoadLevel( name );

    }

    public void QuitRequest() {
        print("Quit request received");
        Application.Quit();
    }
}
