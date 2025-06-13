using UnityEngine;
using TMPro; // TextMeshPro
using System.Collections;

public class NPCDialogue : MonoBehaviour
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

        dialogueText.text = "Cyril: Hi youre Bheki I heard youre the new cleaner..uhmm office hire I mean. Welcome to John Beers finance";
        yield return new WaitForSeconds(4f);

        dialogueText.text = "Bheki: Uhmmm? Yebo bhuthi (Yes brother) that's me";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Cyril: Mfethu (my brother) I dont know what they told you but no one really cares about you here. You're just a cleaner in their eyes";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Bheki: Uhmmm askies bhuthi? (sorry brother?) what do mean....I applied for an office job.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Cyril: That means nothing these oaks dont respect you, not even that fancy clipboard you have.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Bheki: Is this why I haven't been assigned a desk, I'm spending my whole day picking up rubbish!? ";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Cyril : Exactly, So ungazenzi smart (Dont act too clever) especially in front of that John Beers I know something about him, just continue cleaning up this office";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Bheki: John Beers... Grootman? (The boss?), what do you know about him";
        yield return new WaitForSeconds(5f);

       
        dialogueUI.SetActive(false);
    }
}
