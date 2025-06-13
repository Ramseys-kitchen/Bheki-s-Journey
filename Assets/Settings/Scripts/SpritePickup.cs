using UnityEngine;

public class SpritePickup : MonoBehaviour
{
    public PickupManager pickupManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            pickupManager.RegisterPickup();
            //Destroy the pickup
            Destroy(gameObject);
        }
    }

}
