using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class count2 : MonoBehaviour
{
    public static int score = 0;    //for hidden scene discovery

    float timer;

    public Text timeText;
    public Text scoreCheck;
    public Text instruct;

    public GameObject bunny;

    public void scoring()
    {
        score += 100;
        scoreCheck.text = ("Current Score = " + score);
        if (score == 600)
        {
            scoreCheck.text = ("Current Score = 600! \n<GOD OF DAUGTHER>");
            instruct.text = "... (つ◕౪◕)つ━☆ﾟ.*･｡ﾟ ...\n... (ﾉ≧∀≦)ﾉ・‥…━━━★ ...";
            this.GetComponent<Pause>().hiddenGame();
        }
        else if(score >= 700){
            scoreCheck.text = ("<GOD OF DAUGHTER>");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bunny.transform.position.y < 0)
        {
            SceneManager.LoadScene("Ending");
        }

        timer += Time.deltaTime;
        timeText.text = ("" + (60 - (int)timer) + " Seconds Left");
        if (timer >= 60)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
