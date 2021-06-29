using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCheck : MonoBehaviour
{
    public void DisableCheckAfterAnimation()
    {
        this.gameObject.SetActive(false);
    }
}