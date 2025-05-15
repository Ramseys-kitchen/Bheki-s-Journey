using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DailyTaskManager : MonoBehaviour
{
    public GameObject taskPanel; // UI panel that holds the tasks
    public GameObject taskPrefab; // Prefab for each task line (e.g., Text or Button)
    public List<string> dailyTasks = new List<string>
    {
        "File paperwork by the computer",
        "Eat lunch by he vending machine",
        "Pick up trash on the floor"
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        taskPanel.SetActive(false); // Hide at start
    }
    public void ShowTasks()
    {
    
        // Clear existing tasks
        foreach(Transform child in taskPanel.transform)
        {
            Destroy(child.gameObject);
        }

        // Display new tasks
        foreach(string task in dailyTasks)
        {
            GameObject newTask = Instantiate(taskPrefab, taskPanel.transform);
            newTask.GetComponent<Text>().text = "*" + task;
        }

        taskPanel.SetActive(true); // Show the panel
    }

    public void HideTasks()
    {
        taskPanel.SetActive(false);
    }
}
