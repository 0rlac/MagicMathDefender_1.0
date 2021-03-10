using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionesDelJugador : MonoBehaviour
{
    public Transform poscicionPistola, camara;
    RaycastHit hit;
    public int municion = 5;
    public GameObject balaPrefab;
    public LayerMask ignorarJugador;
    
    // Start is called before the first frame update
    void Start()
    {
        ControladorDeCanvas.instance.AñadirTextoMunicion(municion);
    }
    private void Update()
    {
        disparar();
    }


    public void disparar()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawRay(camara.position, camara.forward * 100f, Color.red);
            Debug.DrawRay(poscicionPistola.position, camara.forward * 100f, Color.blue);

            if (municion != 0)
            {
                Vector3 direccion = camara.TransformDirection(new Vector3(0, 0, 1));
                Debug.DrawRay(camara.position, direccion * 100f, Color.green, 5f);

                GameObject obj = Instantiate(balaPrefab);
                obj.transform.position = poscicionPistola.position;

                if (Physics.Raycast(camara.position, camara.forward, out hit, Mathf.Infinity, ~ignorarJugador))
                {
                    obj.transform.LookAt(hit.point);
                }
                else
                {
                    Vector3 dir = camara.position + direccion * 10f;
                    obj.transform.LookAt(dir);
                }
                municion--;
                ControladorDeCanvas.instance.AñadirTextoMunicion(municion);
            }

        }
    }
        
            

}
