using UnityEngine;

public class TrashCollector : MonoBehaviour
{
    private int trashCollected = 0;
    private bool isCollecting = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isCollecting && other.CompareTag("Item"))
        {
            isCollecting = true;
            StartCoroutine(CollectSingleTrash(other.gameObject));
        }
    }
    private System.Collections.IEnumerator CollectSingleTrash(GameObject trash)
    {
        //Wait one physics frame to prevent multi-collection
        yield return new WaitForFixedUpdate();

        trashCollected++;
        Destroy(trash);
        Debug.Log($"Collected trash! Total:{trashCollected}");

        isCollecting = false;
    }

    // Visual debugging 
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }

}
