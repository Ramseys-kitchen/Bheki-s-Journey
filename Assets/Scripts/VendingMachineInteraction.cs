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
    public GameObject Square;


    public void Start()
    {
        Square.SetActive(false);
    }

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

    public void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Square.gameObject.SetActive(true); 
        }
    }
}
