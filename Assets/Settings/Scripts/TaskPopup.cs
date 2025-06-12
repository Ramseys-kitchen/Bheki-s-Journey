using UnityEngine;
using UnityEngine.UI;

public class TaskPopup : MonoBehaviour
{
   
    // Public fields to assign via Inspector

    public Text taskText; // Reference to the Text Component
    public Button closeButton; //Reference to the Button Component

    //Awake is called when the script instance is loaded 
    private void Awake()
    {
        //Auto-assign references if they're null (safety check)
        if (taskText==null)
            taskText = transform.Find("TaskText").GetComponent<Text>();

        if (closeButton == null) 
            closeButton = transform.Find("CloseButton").GetComponent<Button>();

        //Optional: Log warning if assignments fail
        if (taskText == null)
            Debug.LogWarning("TaskText not found in childern!");

        if (closeButton == null)
            Debug.LogWarning("CloseButton not found in children!");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Initialize button listener
        closeButton.onClick.AddListener(() =>
       gameObject.SetActive(false));

        //Start hidden
        gameObject.SetActive(false);
       
    }
    public void ShowTasks()
    {
        gameObject.SetActive(true);
    }
}
