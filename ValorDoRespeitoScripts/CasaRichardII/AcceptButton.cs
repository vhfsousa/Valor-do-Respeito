using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcceptButton : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void OnPress()
    {
        SceneManager.LoadScene(sceneName);
    }
}