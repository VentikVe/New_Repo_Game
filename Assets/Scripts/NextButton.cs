using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;
using TMPro;

public class NextButton : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TextMeshProUGUI bestScoreBest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        userName.text = "Your Name: " + StartManager.Instance.userName;
        bestScoreBest.text = "BestScore: " + " " + StartManager.Instance.userNameBest + " " + StartManager.Instance.bestScoreBest;
    }

    public void NextMain()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
    #if UNITY_EDITOR
        //MainManager.Instance.SaveColor(); 
        EditorApplication.ExitPlaymode();

    #else

        Application.Quit(); // original code to quit Unity player

    #endif
    }
}
