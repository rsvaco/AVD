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
    void Start()
    {
        activada = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            Disparar();
        }
    }

    public void activar() {
        print("torreta activada");
        gameObject.GetComponent<AudioSource>().Play();
        activada = true;
    }


    void Disparar() {
        if (activada)
        {
            Rigidbody bala;
            bala = GameObject.Instantiate(balaPrefab, slots[count % slots.Length].transform.position, slots[count % slots.Length].transform.rotation).GetComponent<Rigidbody>();
            bala.GetComponent<Rigidbody>().AddForce(bala.transform.forward * fuerzaDisparo, ForceMode.Impulse);
            count++;
        }
    }
}
