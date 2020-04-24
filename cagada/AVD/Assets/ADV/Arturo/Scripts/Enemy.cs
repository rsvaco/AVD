using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum ItemType { Eagle = 0, Frog = 1, Opossum = 2}
    public ItemType Type;

    private void Start()
    {
        GetComponent<Animator>().SetInteger("Type", (int)Type);
    }

    public void PickItem()
    {
        GetComponent<Animator>().SetTrigger("Death");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) PickItem();
    }

    public void DeleteMe()
    {
        Destroy(gameObject);
    }
}
