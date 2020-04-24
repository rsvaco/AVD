using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaController : MonoBehaviour
{
    public Animator animator;
    public int zona;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) animator.SetInteger("Zona", zona);
    }
}
