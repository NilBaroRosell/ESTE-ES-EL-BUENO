using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HistoryMenu : MonoBehaviour {

    public GameObject HistoryMenuUI;

    public void advance()
    {
        SceneManager.LoadScene("prova");
    }
}
