using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButtonAfterConfirmation : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void StartAfterConfirmation(){
        PlayerPrefs.SetInt("ChapterNumber", 0);
        SceneManager.LoadScene(sceneName);
    }
}