using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("historia");
    }

    public void QuitMenu()
    {
        Debug.Log("GAME QUITTED SUCCESSFULLY");
        Application.Quit();
    }
}
