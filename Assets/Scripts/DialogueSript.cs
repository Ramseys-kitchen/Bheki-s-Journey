using UnityEngine;
using UnityEngine.UI;

public class DialogueSript : MonoBehaviour
{
    public Text dialogueText;
    public string[] dialogue;
    public float displayTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowDialogue(0); // Show first dialogue on start
    }
    public void ShowDialogue(int index)
    {
        dialogueText.text = dialogue[index];
        Invoke("ClearText",displayTime);
    }
    void ClearText()
    {
        dialogueText.text = "";
    }
}
