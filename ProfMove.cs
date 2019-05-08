using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProfMove : MonoBehaviour
{
    public GameObject prof;
    public GameObject doll;
    public GameObject player;

    public Plane plane;
    int flag = 0;

    float timer;
    float fps;

    // Use this for initialization
    void Start()
    {
        prof.transform.Rotate(new Vector3(0, 1, 0), 90);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 20)
        {
            if (this.GetComponent<AudioSource>().enabled == false) this.GetComponent<AudioSource>().enabled = true;

            if (flag == 0)
            {
                prof.transform.Translate(new Vector3(0f, 0.0f, 1.5f) * Time.deltaTime);
                if (prof.transform.position.x >= 8.0f)
                {
                    flag = 1;
                    prof.transform.Rotate(new Vector3(0, 1, 0), 180);
                }
                if (    ( ((prof.transform.position.x <= doll.transform.position.x)&&     //1-1. when the doll is inside the prof's sight, visible area
                    (doll.transform.position.x <= 3.0f)&&(doll.transform.position.x >= -3.0f)) ||    
                     ((player.transform.position.z >= -4.0f)&&(player.transform.position.x >= prof.transform.position.x)))  //1-2. or when player is inside the prof's sight, visible area
                    && ((prof.transform.position.x <= 3.0f)&&(prof.transform.position.x >= -3.0f))  ) //2. and when the prof is inside visible area
                {
                    flag = 2;   //mode ,stop
                    SceneManager.LoadScene("GameOver");

                }
            }
            else if (flag == 1)
            {
                prof.transform.Translate(new Vector3(0.0f, 0.0f, 1.5f) * Time.deltaTime);
                if (prof.transform.position.x <= -8.0f)
                {
                    flag = 0;
                    prof.transform.Rotate(new Vector3(0, 1, 0), 180);
                }
                if( (((prof.transform.position.x >= doll.transform.position.x) &&     //1-1. when the doll is inside the prof's sight, visible area
               (doll.transform.position.x <= 3.0f) && (doll.transform.position.x >= -3.0f)) ||
                     ((player.transform.position.z >= -4.0f) && (player.transform.position.x <= prof.transform.position.x)))  //1-2. or when player is inside the prof's sight, visible area
                    && ((prof.transform.position.x <= 3.0f) && (prof.transform.position.x >= -3.0f))  ) //2. and when the prof is inside visible area
                {
                    flag = 2;   //mode ,stop
                    SceneManager.LoadScene("GameOver");
                }
            }

        }

    }
}
