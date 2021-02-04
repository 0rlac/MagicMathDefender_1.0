using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ControladorEnemigo : MonoBehaviour, IDaño
{
    public Transform target=null ;

    public float distanciaDeDisparo = 10f;
    public float intervaloDeDisparo = 2f;
    float timpoDeDisparo;
    float distanciaDelObjetivo;

    public Transform poscicionPistola;
    public GameObject bala;
    public int vida = 100;
    NavMeshAgent agent;
    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        timpoDeDisparo = intervaloDeDisparo;
    }
    public bool dañohecho(int valor)
    {
        Debug.Log("He recivido daño = " + valor );
        if (target.tag == "Player")
        {
            vida -= valor;
            if (vida <=0)
            {
                morir();
            }
            return true;
        }
        return false;
    }
    void morir()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posMirar = new Vector3(target.position.x,transform.position.y, target.position.z);
        transform.LookAt(posMirar);

        distanciaDelObjetivo = Vector3.Distance(transform.position, target.position);
        agent.SetDestination(target.position);
        controladorDeDisparo();
    }
    void controladorDeDisparo()
    {
        timpoDeDisparo -= Time.deltaTime;
        if (timpoDeDisparo < 0)
        {
            if (distanciaDelObjetivo < distanciaDeDisparo)
            {
                timpoDeDisparo = intervaloDeDisparo;
                GameObject obj = Instantiate(bala);
                obj.transform.position = poscicionPistola.position;
                obj.transform.LookAt(target.position);
            }
        }
    }
}
