using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class count1 : MonoBehaviour
{
    public static int count = 0;
    public Text instruction;

    float timer;

    void Start()
    {
        //start counting 5 seconds and scene change
    }

    public void counting_1()
    {
        count++;
        if (count == 3)
        {
            instruction.text = "Finished! \nMove on to main game :)\n60 seconds will be given xD";
            this.GetComponent<count1>().enabled = true;
        }
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            SceneManager.LoadScene("MainGame");
        }
        
    }
}
