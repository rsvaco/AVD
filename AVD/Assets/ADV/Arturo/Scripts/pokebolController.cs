using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokebolController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float fuerzaDisparo;
    public GameObject torretaPrefab;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(rb.transform.forward * fuerzaDisparo, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == 8 || collision.collider.gameObject.layer == 16)
        {
            if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
            {
                Instantiate(torretaPrefab, collision.contacts[0].point, Quaternion.identity);
            }
            else {
                Debug.Log("no se puede instanciar otra torreta, ya hay una activa. esperate para que se muera");
            }
            
            Destroy(gameObject);
        }
    }
}
