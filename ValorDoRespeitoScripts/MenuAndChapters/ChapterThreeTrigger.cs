using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterThreeTrigger : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;

    public void ChangeChapter3AndLoadScene(){
        PlayerPrefs.SetInt("ChapterNumber", 3);
        fadeOut.SetActive(true);
    }
}