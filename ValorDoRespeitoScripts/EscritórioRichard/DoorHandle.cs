using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorHandle : MonoBehaviour
{
    [SerializeField] private Vector2 touchStartPos, touchEndPos;
    [SerializeField] private Image macaneta;
    [SerializeField] private Sprite alavancaLevantada;
    [SerializeField] private Sprite alavancaAbaixada;
    [SerializeField] private AudioSource somPorta;
    [SerializeField] private AudioClip portaAbrindo;
    [SerializeField] private string sceneName;
    [SerializeField] private GameObject puzzle;

    void Update()
    {
        OpenDoor();
    }

    void OpenDoor(){
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
            touchStartPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchEndPos = Input.GetTouch(0).position;
            if(touchEndPos.y < touchStartPos.y && puzzle.GetComponent<PointsCounter>().puzzleAccept == true){
                macaneta.sprite  = alavancaAbaixada;
                somPorta.PlayOneShot(portaAbrindo);
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}