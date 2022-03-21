using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zona : MonoBehaviour
{
    //List<GameObject> listaPuntos;
    //int cant = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "punto")
        {
            //listaPuntos.Add(other.gameObject);
            Destroy(other.gameObject.GetComponent<Collider>());

            Debug.Log("Colision detectada con " + other.GetComponent<puntos>().getValor());
        }
    }
}



