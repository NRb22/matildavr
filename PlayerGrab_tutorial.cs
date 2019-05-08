using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab_tutorial : MonoBehaviour
{
    public GameObject ball;
    public GameObject myHand;

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

    private void update()
    {
        
    }
    // Update is called once per frame
    public void drop()
    {
            //when this script is enabled by Hover, the case is only when the player is grabbing.
            ball.transform.SetParent(null);
            ballCol.isTrigger = false;
            ballRb.useGravity = true;

            ballRb.velocity = cam.transform.rotation * Vector3.forward * handPower;

            this.GetComponent<PlayerGrab_box>().enabled = false;
        }

  }

