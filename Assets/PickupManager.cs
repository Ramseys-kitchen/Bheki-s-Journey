using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Collections;
public class PickupManager : MonoBehaviour
{
    public int totalPickups;
    private int collectedPickups = 0;
    public TextMeshProUGUI levelCompleteText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        totalPickups = GameObject.FindGameObjectsWithTag("Pickup").Length;
        levelCompleteText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void RegisterPickup()
    {
        collectedPickups++;
        if (collectedPickups >= totalPickups)
        {
            StartCoroutine(ShowLevelCompleteWithDelay());
        }
    }

    private IEnumerator ShowLevelCompleteWithDelay()
    {
        yield return new WaitForSeconds(2f);
        levelCompleteText.gameObject.SetActive(true);
    }
}
