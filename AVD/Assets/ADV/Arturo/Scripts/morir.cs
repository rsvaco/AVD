using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void muerte() {
        Debug.Log(gameObject.name + " me muero");
        Destroy(gameObject);
    }
}
