using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsGoingUp : MonoBehaviour
{
    [SerializeField] private RectTransform credits;
    [SerializeField] private float speed;

    void Update()
    {
        credits.Translate(0, 1 * Time.deltaTime * speed, 0);

        if(credits.transform.position.y > 5440){
            credits.transform.position = new Vector2 (credits.transform.position.x, 0);
        }
    }
}