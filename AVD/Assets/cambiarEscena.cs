using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarEscena : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
         SceneManager.LoadSceneAsync(level);
    }
}

