using UnityEngine;
using System.Collections;

public class ParalaxObject : MonoBehaviour {

    public Vector3 startingPosition;

    public Vector2 speed = new Vector2();

    void Start()
    {
        startingPosition = this.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 newPosition = new Vector3();

        newPosition.x = Camera.main.transform.position.x * speed.x * -1 + startingPosition.x;
        newPosition.y = Camera.main.transform.position.y * speed.y * -1 + startingPosition.y;
        newPosition.z = startingPosition.z;

        this.transform.position = newPosition;
	}
}
