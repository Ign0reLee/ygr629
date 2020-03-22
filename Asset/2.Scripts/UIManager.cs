using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick(string type)
    {
        switch (type)
        {
            case "To Store":
                SceneManager.LoadScene("Store");
                break;

            case "Continue":

                break;

            case "Setting":

                break;

            case "Credit":

                break;

            case "To Storage":
                SceneManager.LoadScene("Storage");
                break;

            case "To Worldmap":
                SceneManager.LoadScene("World");
                break;

            case "To Quest":
                SceneManager.LoadScene("Quest");
                break;

            case "To Character":
                SceneManager.LoadScene("Character");
                break;

            case "To Frontyard":
                SceneManager.LoadScene("Frontyard");
                break;

            case "To Mission":
                SceneManager.LoadScene("Mission");
                break;
        }
    }
}
