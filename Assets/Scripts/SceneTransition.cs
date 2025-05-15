using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private Vector2 spawnPositionInNewScene;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Save the position to use in the new scene
            PlayerPrefs.SetFloat("SpawnX", spawnPositionInNewScene.x);
            PlayerPrefs.SetFloat("SpawnY", spawnPositionInNewScene.y);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
