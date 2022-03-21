using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecturas : MonoBehaviour
{
    List<puntos> listaDePuntos = new List<puntos>() 
    { new puntos { latitud = 1.5F, longitud = 3.5F }, new puntos { latitud = 2, longitud = 7 } };
    public GameObject[] zonas, lecturas;
    // dictionary 
    // Start is called before the first frame update
    void Start()
    {
        zonas = GameObject.FindGameObjectsWithTag("Zona");
        lecturas = GameObject.FindGameObjectsWithTag("Lectura");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void masCercano (puntos pt)
    {
        GameObject cerca;
        float distanciaCerca = 1000;
        foreach (GameObject zona in zonas)
        {
            Vector3 posEne = zona.transform.position;
            float distAct = Vector3.Distance(pt.GetPosition(), posEne);
            if (distAct < distanciaCerca)
            {
                distanciaCerca = distAct;
                cerca = zona;
            }
        }
        /* foreach (GameObject zona in zonas)
        {
            if (cerca.)
        }*/ 
    }
    /*
     requieren: estructuras de datos (investigar dictionary)
    funcion para encontrar la zona mas cercana al punto
    forma de que los puntos declaren sus propios valores de latitud y longitud
     * */
}

