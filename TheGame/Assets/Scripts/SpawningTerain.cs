using UnityEngine;
using System.Collections;

public class SpawningTerain : MonoBehaviour
{
    private float platformMin = -2.5f;
    private float platformMax = 2.5f;
    public GameObject Platform;
    public GameObject Background;
	void Start ()
	{
	    StartCoroutine(SpawnPlatforms());
	}

    IEnumerator SpawnPlatforms()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            float heith = Random.Range(platformMin, platformMax);
            Instantiate(Platform, new Vector3(20.5f, heith, 0), Quaternion.identity);
        }
    }
    public void SpawnBackground()
    {
        Instantiate(Background, new Vector3(20.5f, 0, 0), Quaternion.identity);
    }
}
