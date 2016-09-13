using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public float launchSpeed;

    private Rigidbody rigidBody;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        rigidBody = this.GetComponent<Rigidbody>();
        audioSource = this.GetComponent<AudioSource>();

        LaunchBall();
    }

    public void LaunchBall()
    {
        rigidBody.velocity = Vector3.forward * launchSpeed;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Lane")
        {
            audioSource.Play();
        }
    }
}
