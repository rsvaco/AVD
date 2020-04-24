using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Animator animator;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("wwwwww");
        if (collision.CompareTag("Player")) animator.SetTrigger("PlayerEntered2");
    }
}
