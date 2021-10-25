using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoCharacterController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w")) {
            CharacterAnimator.SetRunning();
        }
        else if (Input.GetKey("w")) {
            CharacterAnimator.SetWalking();
        }
        else if (Input.GetKey("s")) {
            CharacterAnimator.SetWalkingBackwards();
        }
        else {
            CharacterAnimator.SetIdle();
        }
    }
}
