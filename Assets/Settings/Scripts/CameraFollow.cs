using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Your player's transform
    public float smoothing = 5f;
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);

        }
    }
}
