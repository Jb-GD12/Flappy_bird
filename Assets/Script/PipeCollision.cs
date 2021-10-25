using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCollision : MonoBehaviour
{
    
    

    private void OnTriggerEnter2D(Collider2D p_other)
    {
        if (p_other.GetComponent<PlayerCtrl>() != null)
        {
            p_other.gameObject.SetActive(false);
        }
    }
}
