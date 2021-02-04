using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoCaja : MonoBehaviour
{
    public Transform container;
    public float velocidadRotacion = 180f;
    // Update is called once per frame
    void Update()
    {
        container.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
    }
}
