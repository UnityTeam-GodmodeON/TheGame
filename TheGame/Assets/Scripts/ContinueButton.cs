using UnityEngine;
using System.Collections;

public class ContinueButton : MonoBehaviour
{
	void Start ()
	{
	    if (!PlayerPrefs.HasKey("GameProgress"))
	    {
            gameObject.SetActive(false);
	    }
	    
	}
}
