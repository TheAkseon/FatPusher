using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GameRestart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
