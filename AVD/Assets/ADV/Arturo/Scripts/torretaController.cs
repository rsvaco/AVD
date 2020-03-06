using UnityEngine;

public class torretaController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject balaPrefab;

    [SerializeField]
    private GameObject[] slots;
    public bool activada;

    public float fuerzaDisparo;
    private int count = 0;
    private Animator animator;
    private int tasaDisparo = 100;
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
        count++;
    }

    public void activar() {
        Debug.Log("torreta activada");
        gameObject.GetComponent<AudioSource>().Play();
        activada = true;
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
            bala.GetComponent<Rigidbody>().AddForce(bala.transform.forward * fuerzaDisparo, ForceMode.Impulse);
            
        }
    }
}
