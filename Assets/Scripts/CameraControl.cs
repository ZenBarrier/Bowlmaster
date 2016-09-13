using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
    public Ball ball;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        ball = FindObjectOfType<Ball>();
        offset = transform.position - ball.transform.position;
        this.transform.position = ball.transform.position + offset;
	}
	
	// Update is called once per frame
	void Update () {
        float zPos = this.transform.position.z - offset.z;
        if (zPos < 1829f)
        {
            this.transform.position = ball.transform.position + offset;
        }
    }
}
