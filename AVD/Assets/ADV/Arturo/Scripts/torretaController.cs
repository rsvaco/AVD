using System.Collections.Generic;
using UnityEngine;

public class torretaController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject balaPrefab;

    static List<GameObject> ammoPool;
    public int poolSize;

    [SerializeField]
    private GameObject[] slots;
    public bool activada;

    public float fuerzaDisparo;
    private int count = 0;
    private Animator animator;
    private int tasaDisparo = 2;

    void Awake()
    {
        if (ammoPool == null)
        {
            ammoPool = new List<GameObject>();
        }
        for (int i = 0; i < poolSize; i++)
        {
            GameObject ammoObject = Instantiate(balaPrefab);
            ammoObject.SetActive(false);
            ammoPool.Add(ammoObject);
        }
    }

    GameObject SpawnAmmo(Vector3 location, Quaternion rotation)
    {
        foreach (GameObject ammo in ammoPool)
        {
            if (ammo.activeSelf == false)
            {
                ammo.SetActive(true);
                ammo.transform.position = location;
                ammo.transform.rotation = rotation;
                return ammo;
            }
        }
        return null;
    }


    void Start()
    {
        animator = GetComponent<Animator>();
        activada = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") || count % tasaDisparo == 0) {
            Disparar();
        }

        if (Input.GetKeyDown("f"))
        {
            animator.SetTrigger("die");
        }

        if (Input.GetKeyDown(","))
        {
            tasaDisparo += 5;
        }

        if (Input.GetKeyDown("."))
        {
            tasaDisparo = Mathf.Max(2, tasaDisparo - 5);
        }
        count++;
    }

    public void activar() {
        Debug.Log("torreta activada");
        gameObject.GetComponent<AudioSource>().Play();
        activada = true;
    }

    public void desactivar()
    {
        Debug.Log("torreta desactivada");
        gameObject.GetComponent<AudioSource>().Play();
        activada = false;
    }

    public void morir() {
        Debug.Log("muero");
        Destroy(gameObject);
        
    }

    void Disparar() {
        if (activada)
        {
            Rigidbody bala;
            bala = GameObject.Instantiate(balaPrefab, slots[count % slots.Length].transform.position, slots[count % slots.Length].transform.rotation).GetComponent<Rigidbody>();
            //GameObject balita = SpawnAmmo(slots[count % slots.Length].transform.position, slots[count % slots.Length].transform.rotation);
            //bala = balita.GetComponent<Rigidbody>();

            bala.GetComponent<Rigidbody>().AddForce(bala.transform.forward * fuerzaDisparo, ForceMode.Impulse);
            //bala.AddForce(bala.transform.forward * fuerzaDisparo, ForceMode.Impulse);
        }
    }
}
