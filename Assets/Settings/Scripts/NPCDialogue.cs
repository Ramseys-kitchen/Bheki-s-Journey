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

        dialogueText.text = "Sibusiso: Hi you're Bheki I heard you're the new cleaner..uhmm office hire I mean. Welcome to John Beers finance.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Bheki: Uhmmm? Yes that's me.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Sibusiso: Mfethu (my brother) I dont know what they told you but no one really cares about you here. You're just a cleaner in their eyes.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Bheki: A cleaner? uhmmm askies bhuthi? (sorry brother?) what do mean....I applied for an office job you might have the wrong Bheki.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Sibusio: Hey listen that means nothing here these oaks dont respect you, not that suit, tie, or even that fancy clipboard you have.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Bheki: Is this why I haven't been assigned a desk, I'm spending my whole day picking up rubbish.!? ";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Sibusio: Exactly that, So ungazenzi smart (Dont act too clever) especially in front of that John Beers I know something about him, just continue cleaning up this office.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Bheki: John Beers... Grootman? (The boss?), what do you know about him.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Sibusio: Ey man I'm gonna put you onto to something (glances around). You know Johns office. That place is always a mess.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Sibusio: But deep inside that mess there's files, I'm talking real stuff, HR- level type of complaints.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Bheki: Say you lie.?!";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Sibusiso: Mistreatment and dodgy contracts about how they hire black okes like us to balance the numbers but we just end up pushing brooms.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Sibusio: But listen if you get those files you could get a payout. A hush money type of thing.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Sibusio: We split that money, you can decide the cut. I just wanna get out of here with something.";
        yield return new WaitForSeconds(5f);

        dialogueText.text = "Game: (Walk up to John Beers Office)";
        yield return new WaitForSeconds(5f);

        dialogueUI.SetActive(false);
    }
}
