using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;
    
    // Start is called before the first frame update
    void Start()
    {
    }
    public void resuming()
    {
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        gamePaused = false;

        Time.timeScale = 1;

    }
    public void hiddenGame()
    {
        gamePaused = true;
        pauseMenu.SetActive(true);


    }
    public void pausing()
    {
            Time.timeScale = 0;
            gamePaused = true;
            Cursor.visible = true;
            pauseMenu.SetActive(true);
    }
    

    // Update is called once per frame
    void Update()
    {
        if(gamePaused)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                resuming();
            }
        }

    }
}
