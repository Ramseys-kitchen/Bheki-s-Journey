using UnityEngine;

public class InfoToggle : MonoBehaviour
{
    public GameObject infoPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Ensure the panel is hidden at the start
        infoPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            infoPanel.SetActive(!infoPanel.activeSelf);
        }
        
    }
}
