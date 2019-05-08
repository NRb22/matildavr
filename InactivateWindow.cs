using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactivateWindow : MonoBehaviour
{
    public GameObject objectInact;

    public void RemovingfromScene()
    {
        objectInact.transform.Translate(new Vector3(0, -15f, 0));
    }

    // Start is called before the first frame update
    void Start()
    {
        //objectInact.transform.Translate(new Vector3(0, -15f, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
