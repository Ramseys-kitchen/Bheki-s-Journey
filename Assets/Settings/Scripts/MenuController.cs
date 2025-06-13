using UnityEngine;

public class MenuController : MonoBehaviour
{
    private GameObject menuCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
       menuCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Tab))
        {
            Time.timeScale = 0; //Pauses the game
            menuCanvas.SetActive(!menuCanvas.activeSelf);
        }
            
    }
}
