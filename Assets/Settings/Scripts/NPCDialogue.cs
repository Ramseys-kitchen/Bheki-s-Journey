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

        dialogueText.text = "Cyril: Hi youre Bheki I heard youre the new hire here welcome" +
            "Listen here mfethu (My brother) this place isnt what it seems youre just a cleaner here thats all";
        yield return new WaitForSeconds(1.5f);

        dialogueText.text = "Bheki: Oh, hello.";
        yield return new WaitForSeconds(1.5f);

        dialogueUI.SetActive(false);
    }
}
