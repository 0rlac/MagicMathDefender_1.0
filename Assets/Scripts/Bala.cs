using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 8f;
    public float duracion = 2f;
    float tiempoVida;
    public int ataque = 10;
    
    // Start is called before the first frame update
    private void OnEnable()
    {
        tiempoVida = duracion;
    }

    // Update is called once per frame
    private void Update()
    {
        tiempoVida -= Time.deltaTime;
        if (tiempoVida <=0)
        {
            gameObject.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        transform.position += transform.forward * velocidad * Time.fixedDeltaTime;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("la bala choco con " + other.name);
        bool remover = true;
        IDaño damage = other.GetComponent<IDaño>();
        if (damage !=null)
        {
            remover=damage.dañohecho(ataque);
        }

        if(remover==true)gameObject.SetActive(false);
    }
}
    