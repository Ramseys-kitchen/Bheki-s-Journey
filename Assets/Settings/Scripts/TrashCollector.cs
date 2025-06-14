using UnityEngine;

public class TrashCollector : MonoBehaviour
{
    private int trashCollected = 0;
    private bool isCollecting = false;

    public GameObject Door;
    

    [Header("Audio Settings")]
    [SerializeField] private AudioClip collectSound; //Assign in Inspector
    [SerializeField]
    [Range(0f, 1f)]
    private float volume = 0.7f; //Default volume level

    private void Start()
    {
        Door.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isCollecting && other.CompareTag("Item"))
        {
            isCollecting = true;
            StartCoroutine(CollectSingleTrash(other.gameObject));
            //Progress Bar will update here (reversehealthbar)
        }
    }
    private System.Collections.IEnumerator CollectSingleTrash(GameObject trash)
    {
        //Wait one physics frame to prevent multi-collection
        yield return new WaitForFixedUpdate();

        trashCollected++;
        Debug.Log($"About to play sound for trash#{trashCollected}");
        PlayCollectSound();
        Destroy(trash);
        Debug.Log($"Collected trash! Total:{trashCollected}");

        isCollecting = false;
    }

    private void PlayCollectSound()
    {
        if (collectSound != null)
        {
            // Play at camera position for better spatial audio
            Vector3 soundPos = Camera.main.transform.position;

            AudioSource.PlayClipAtPoint(collectSound, soundPos, volume);
        }

    }

    private void Update()
    {
        if(trashCollected >= 7)
        {
            Door.SetActive(false);
        }
    }
}
