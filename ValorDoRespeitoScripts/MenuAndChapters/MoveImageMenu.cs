using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveImageMenu : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private float maxWidth;
    [SerializeField] private float minWidth;
    private bool isAtMax;

    void Start()
    {
        isAtMax = true;
    }

    void Update()
    {
        if(isAtMax == true){
            transform.Translate (speedX * Time.deltaTime, 0 , 0);
                if(transform.position.x >= maxWidth){
                isAtMax = false;
                }
        }

        if (isAtMax == false){
            transform.Translate (speedX * Time.deltaTime * -1, 0 , 0);
                if (transform.position.x <= minWidth){
                isAtMax = true;
                }
        }
    }
}