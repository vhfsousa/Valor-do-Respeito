using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScene : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public void FadeToLevel(int levelIndex)
    {
        anim.SetTrigger("FadeOut");
    }
}