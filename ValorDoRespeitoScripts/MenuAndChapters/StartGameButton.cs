using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private GameObject aviso;
    
    public void ChangeSceneAndAddChapter(){
        if(PlayerPrefs.GetInt("ChapterNumber") > 0){
            aviso.SetActive(true);
        }
        else{
            PlayerPrefs.SetInt("ChapterNumber", 0);
            SceneManager.LoadScene(sceneName);
        }
    }
}