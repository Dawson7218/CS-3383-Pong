using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;

    [SerializeField]
    public GameObject pause;

    void Start()
    {
        isPaused = true;
        pause.SetActive(true);
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P is pressed");
            if (isPaused)
            {
                pause.SetActive(false);
                Time.timeScale = 1f;
                isPaused = false;
            }
            else
            {
                pause.SetActive(true);
                Time.timeScale = 0f;
                isPaused = true;
            }
        }
    }
}
