using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
      animator = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
              if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("LanternColor");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("LanternSize");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("LanternSpin");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("LanternHeight");
        }  
    }
}
