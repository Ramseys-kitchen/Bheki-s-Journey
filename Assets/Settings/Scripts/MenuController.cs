using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
       menuCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 0; //Pauses the game

            menuCanvas.SetActive(true);
        }
       else if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = 1;
            menuCanvas.SetActive(false);
        }

            
    }
}
