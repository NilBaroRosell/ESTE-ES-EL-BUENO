using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitMenu()
    {
        Debug.Log("GAME QUITTED SUCCESSFULLY");
        Application.Quit();
    }
}
