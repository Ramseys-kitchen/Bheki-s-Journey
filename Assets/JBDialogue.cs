using UnityEngine;
using TMPro; // TextMeshPro
using System.Collections;

public class JBDialogue : MonoBehaviour
{
    public GameObject dialogueUI;
    public TMP_Text dialogueText;

    private bool hasTalked = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasTalked)
        {
            StartCoroutine(ShowDialogue());
        }
    }
    private IEnumerator ShowDialogue()
    {
        hasTalked = true;
        dialogueUI.SetActive(true);

        dialogueText.text = "John Beers: JA! cyril neh I need you to..";
        yield return new WaitForSeconds(4f);

        dialogueText.text = "Bheki: Bheki sir...it's Bheki";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "John Beers: Bheki....right..Bheki Mmmm";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Bheki: Uhmm when will I be assigned a desk. I've been here a week";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "John Beers: Your desk? relax neh its coming. Ag jy weet moes (you know how it is)";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "John Beers: Since you here just clean up this mess for me its useless paperwork";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "John Beers: (Yoh so I really left home to be a white oaks cleaner)";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Bheki: (Maybe I'll find those things Cyril told me about, bring this company down and get a fat paycheck)";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Game: (Pick up the objects you see by walking over them)";
        yield return new WaitForSeconds(5f);


        dialogueUI.SetActive(false);
    }
}
