using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour {

    [SerializeField] Animator _animator;

    public static CharacterAnimator instance;

    private void Awake() {
        instance = this;
    }

    public void SetState(int _state) {
        _animator.SetInteger("Moving", _state);
    }

    public static void SetIdle() {
        instance.SetState(0);
    }

    public static void SetWalking() {
        instance.SetState(1);
    }

    public static void SetWalkingBackwards() {
        instance.SetState(-1);
    }

    public static void SetRunning() {
        instance.SetState(2);
    }

}
