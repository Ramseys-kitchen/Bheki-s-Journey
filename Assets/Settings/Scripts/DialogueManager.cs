using UnityEngine;
using System.Collections;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public GameObject dialoguePanel; //Reference to the panel
    public float textDelay = 5f;
    public TaskPopup taskPopup; //Assign this in the inspector


    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void Start()
    {
        StartCoroutine(ShowDialogue());
    }
    IEnumerator ShowDialogue()
    {
        dialoguePanel.SetActive(true); //Make sure its visible at start

        dialogueText.text = "Bheki: Yoh! this office is so dirty sies man.";
        yield return new WaitForSeconds (textDelay);

        dialogueText.text = "Bheki: I knew I shoud've stayed back home on the farm mxm, what is this?!.";
        yield return new WaitForSeconds(textDelay);

        dialogueText.text = "Bheki: Now which one here is my desk? (looks around)";
        yield return new WaitForSeconds (textDelay);

        dialogueText.text = "Bheki: And then lodoti? (this rubbish?) this is not the big city life I was promised. ";
        yield return new WaitForSeconds (textDelay);

        dialogueText.text = "Bheki: Someone needs to clean this up but I see no cleaners?!.";
        yield return new WaitForSeconds (textDelay);

        dialogueText.text = "Game: Pick up the trash! (Walk over the trash to pick it up)";
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
