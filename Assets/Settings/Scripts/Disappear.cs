using UnityEngine;

public class Disappear : MonoBehaviour
{
    public GameObject redsquare;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       redsquare.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            redsquare.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            redsquare.SetActive(false);
        }
    }
}
