using UnityEngine;
using System.Collections;

public class PlatformMoving : MonoBehaviour {
    
	void Update () {
        transform.Translate(-0.1f, 0, 0);
    }
}
