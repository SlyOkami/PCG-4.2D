using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    LevelManager levelManager = new LevelManager();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        print("Collision");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");

        levelManager.LoadNewScene("Lose");
    }
}
