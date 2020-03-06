using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animStateController : MonoBehaviour
{

    public Animator animator;

    private int count = 0;

    [SerializeField]
    private int numAnims;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int currente = count % numAnims;
        if (Input.GetKeyDown("space")) {
            animator.SetInteger("state", currente);
            animator.SetTrigger("change");
            Debug.Log(currente);
            count++;
        }
    }
}
