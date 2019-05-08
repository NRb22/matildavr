using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover_doll : MonoBehaviour {

    public GameObject ball;
    public GameObject myHand;

    bool inHands = false;

    Collider ballCol;
    Rigidbody ballRb;

    Camera cam;
    public float handPower;

    // Use this for initialization
    void Start () {

        ballCol = ball.GetComponent<SphereCollider>();
        ballRb = ball.GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();

    }
   
   public void hovering()
    {
        //grab or release
        if (!inHands)
        {

            ballCol.isTrigger = true;
            ball.transform.SetParent(myHand.transform);
            ball.transform.localPosition = new Vector3(0, 0.5f, 10f);
            ballRb.useGravity = false;
            ballRb.velocity = Vector3.zero;

            this.GetComponent<PlayerGrab_doll>().enabled = true;

            inHands = true;

        }
        else   
        {
            ball.transform.SetParent(null);
            ballCol.isTrigger = false;
            ballRb.useGravity = true;

            ballRb.velocity = cam.transform.rotation * Vector3.forward * handPower;

            inHands = false;

        }
    }

	// Update is called once per frame
	void Update () {

    }
}
