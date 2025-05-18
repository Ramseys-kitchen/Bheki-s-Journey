using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class VendingMachineInteraction : MonoBehaviour
{
    public Image progressBar;
    public GameObject progressBarParent;
    public AudioSource vendingAudio;
    public UnityEvent onFinishedEating; // Player gains energy

    private int clickCount = 0;
    private int requiredClicks = 8;

    private void OnMouseDown()
    {
        clickCount++;

        if (vendingAudio != null )
            vendingAudio.Play();

        UpdateProgressBar();

        if (clickCount >= requiredClicks)
        {
            onFinishedEating?.Invoke();
            clickCount = 0; //Reset
            UpdateProgressBar();

            if(progressBarParent != null )
                progressBarParent.SetActive(false);
        }
    }

    void UpdateProgressBar()
    {
        if(progressBar != null)
            progressBar.fillAmount = (float)clickCount / requiredClicks;
    }
}
