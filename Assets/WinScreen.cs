using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    public GameObject winPanel;
    public Text winText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winPanel.SetActive(false);
    }

    public void LeftWin()
    {
        winText.text = "Left Wins!";
        winPanel.SetActive(true);
    }

    public void RightWin()
    {
        winText.text = "Right Wins!";
        winPanel.SetActive(true);
    }
}
