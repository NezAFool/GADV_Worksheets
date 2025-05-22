using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    bool isRunning;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Animation event handler method
    public void HandleFall()
    {
        Debug.Log("Oof! I didn't expect that!");
    }
    private void Update()
    {
        isRunning = true;
        animator.SetBool("Run", isRunning);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }
    }

}
