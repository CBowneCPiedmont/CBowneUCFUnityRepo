using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    public GameObject anim;
    public GameObject old;

    public Animator animator;
    
    void OnDisable()
    {
        //anim.SetActive(true);
        //old.SetActive(false);
        animator.enabled = true;
    }
}
