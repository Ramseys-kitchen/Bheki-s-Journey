using UnityEngine;
using System.Collections;

public class SignDestroyer : MonoBehaviour
{
    public GameObject textPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SignKiller());
        
    }

    private IEnumerator SignKiller()
    {
        yield return new WaitForSeconds(5f);
        textPanel.gameObject.SetActive(false);
        Debug.Log("It Works");
    }
}
