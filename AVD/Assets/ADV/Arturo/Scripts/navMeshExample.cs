using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navMeshExample : MonoBehaviour
{
    public GameObject destination;
    NavMeshAgent agent;
    Animator anim;
    Vector3 posicionAnterior;
    RaycastHit hitinfo = new RaycastHit();

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        agent.destination = destination.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.isStopped) {
            //anim.SetInteger("state", 3 );
            anim.SetFloat("velx", agent.velocity.x);
            anim.SetFloat("vely", agent.velocity.z);
        }

        /*
        if (posicionAnterior != destination.transform.position) {
            agent.destination = destination.transform.position;
            posicionAnterior = destination.transform.position;
        }*/

        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hitinfo)) {
                agent.destination = hitinfo.point;
            }
        }
    }
}
