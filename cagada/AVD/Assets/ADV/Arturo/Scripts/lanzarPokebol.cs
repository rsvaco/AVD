using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzarPokebol : MonoBehaviour
{
    public GameObject pokebolPrefab;
    public string key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key)) {
            Instantiate(pokebolPrefab, gameObject.transform.position, gameObject.transform.rotation);
        }


    }
}
