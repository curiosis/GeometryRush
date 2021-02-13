using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStage : MonoBehaviour
{
    public Transform player;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {

        if (player.position.x >= transform.position.x)
        {
            animator.SetBool("Close", true);
        }
    }
}
