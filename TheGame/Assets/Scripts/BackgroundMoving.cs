using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackgroundMoving : MonoBehaviour
{
    private SpawningTerain spawningTerain;
    private bool spawned;
	void Start ()
	{
	    spawned = false;
	    spawningTerain = GameObject.Find("Utility").GetComponent<SpawningTerain>();
	}
	
	void Update () {
	    transform.Translate(-0.1f, 0, 0);
        
        if (Math.Abs(transform.position.x) < 0.2 && spawned == false)
	    {
            spawned = true;
            spawningTerain.SpawnBackground();
	        spawned = true;
	    }
	    if (Math.Abs(transform.position.x + 22.5f) < 0.2)
	    {
            Destroy(gameObject);
        }
	}
}
