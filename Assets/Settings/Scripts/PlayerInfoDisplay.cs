using UnityEngine;
using TMPro;

public class PlayerInfoDisplay : MonoBehaviour
{
    public TextMeshProUGUI infoText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string playerName = "Bheki";
        int playerAge = 20;
        string playerDetails = "intern at John Beers, Office Errand Runner, Diveristy Hire";

        infoText.text = "Name:" + playerName + "\n";
        infoText.text += "Age:" + playerAge + "\n";
        infoText.text += "Details:" + playerDetails;
        }
    }

