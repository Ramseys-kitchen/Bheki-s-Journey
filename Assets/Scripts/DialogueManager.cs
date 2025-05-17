using UnityEngine;
using System.Collections;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public GameObject dialoguePanel; //Reference to the panel
    public float textDelay = 3f;
    public TaskPopup taskPopup; //Assign this in the inspector


    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void Start()
    {
        StartCoroutine(ShowDialogue());
    }
    IEnumerator ShowDialogue()
    {
        dialoguePanel.SetActive(true); //Make sure its visible at start

        dialogueText.text = "Bheki: yoh this office is so dirty sies man";
        yield return new WaitForSeconds (textDelay);

        dialogueText.text = "Bheki: I shoud've stayed on the farm mxm";
        yield return new WaitForSeconds(textDelay);

        dialogueText.text = "Bheki: And then lodoti? (this rubbish?)";
        yield return new WaitForSeconds (textDelay);

        dialogueText.text = "Bheki: Surely they dont expect me to clean this?!";
        yield return new WaitForSeconds (textDelay);

        dialogueText.text = ""; // Clear the text after dialogue ends 
        dialoguePanel.SetActive(false); //Hide the panel after dialogue
    }

    void OnDialogueEnd()
    {
        // Show the task pop-up when the dialogue ends
        taskPopup.ShowTasks();
    }
}
