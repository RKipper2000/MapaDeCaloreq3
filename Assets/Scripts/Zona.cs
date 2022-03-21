using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zona : MonoBehaviour
{
    float avg;
    int cant;
    private void Start()
    {
        avg = 0;
        cant = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "punto")
        {
            //listaPuntos.Add(other.gameObject);
            Destroy(other.gameObject.GetComponent<Collider>());

            Debug.Log("Colision detectada con " + other.GetComponent<puntos>().getValor());
            cant += 1;
            avg = ((avg*(cant-1))+ other.GetComponent<puntos>().vlr())/(cant);
            Debug.Log("Promedio en " + gameObject.name + ": " + avg);
        }
    }
}



