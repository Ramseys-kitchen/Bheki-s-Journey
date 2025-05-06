using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SinglePageIntro : MonoBehaviour
{
    public TextMeshProUGUI diaryText;
    [TextArea(5, 10)]
    public string diaryPage;
    public string nextSceneName = "SampleScene";

    private bool hasClicked = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        diaryText.text = diaryPage;
        Debug.Log("Diary Page Loaded:" + diaryPage);
    }

   void Update()
    {
        if (Input.GetMouseButtonDown(0) && !hasClicked)
        {
            hasClicked = true;
            LoadNextScene();
        }
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
