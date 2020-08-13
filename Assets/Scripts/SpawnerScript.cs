using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public GameObject obstacle;

    private float max_Y = 4.5f, min_Y = -3f;

	// Use this for initialization
	void Start () {
        StartCoroutine(StartSpawning());
	}
	

    IEnumerator StartSpawning() {
        yield return new WaitForSeconds(Random.Range(1f, 2f));

        Instantiate(obstacle);

        float y = Random.Range(min_Y, max_Y);

        obstacle.transform.position = new Vector2(transform.position.x, y);

        StartCoroutine(StartSpawning());

    }


}
