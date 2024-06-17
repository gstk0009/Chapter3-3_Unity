using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Animator anim;
    public float attackPower = 1f;

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    public void OnMouse(InputAction.CallbackContext context)
    {
        if (context.started)
            Clikced();
        if (context.canceled)
            anim.SetBool("OneTab", false);
    }

    public void OnTab(InputAction.CallbackContext context)
    {
        if (context.started)
            Clikced();
        if (context.canceled)
            anim.SetBool("OneTab", false);
    }

    public void Clikced()
    {
        if (anim != null)
            anim.SetBool("OneTab", true);
    }

    private void dubbleClicked()
    {
        if (anim != null)
            anim.SetBool("TwoTab", true);
    }
}
