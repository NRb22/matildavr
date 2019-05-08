using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    public GameObject ball;
    public GameObject myHand;

    bool inHands = false;

    Collider ballCol;
    Rigidbody ballRb;

    Camera cam;
    public float handPower;


    // Use this for initialization
    void Start()
    {

        ballCol = ball.GetComponent<SphereCollider>();
        ballRb = ball.GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();


    }

    private void Update()
    {
        
    }

    // Update is called once per frame
    public void grabbing()
    {
        if (!inHands)
        {
            ballCol.isTrigger = true;
            ball.transform.SetParent(myHand.transform);
            ball.transform.localPosition = new Vector3(0, 0.5f, 10f);
            ballRb.useGravity = false;
            ballRb.velocity = Vector3.zero;

            inHands = true;

            this.GetComponent<grab>().enabled = false;

        }
        else
        {
            //when this script is enabled by Hover, the case is only when the player is grabbing.
            ball.transform.SetParent(null);
            ballCol.isTrigger = false;
            ballRb.useGravity = true;

            ballRb.velocity = cam.transform.rotation * Vector3.forward * handPower;

            inHands = false;


            this.GetComponent<grab>().enabled = false;
           // prof.GetComponent<ProfMove>().enabled = true;
        }

    }
}
