using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash= Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPress = Input.GetKey("z");
        bool isWalking = animator.GetBool(isWalkingHash);
        bool runPress = Input.GetKey("shift left");
        bool isRunning = animator.GetBool(isRunningHash);

        // si on appuit sur z
        if (!isWalking && forwardPress)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !forwardPress)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if (!isRunning &&(runPress && forwardPress))
        {
            animator.SetBool(isRunningHash, true);
        }

        if (isRunning &&(runPress || forwardPress))
        {
            animator.SetBool(isRunningHash, false);
        }

    }

}
