using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zona : MonoBehaviour
{
    float avg;
    int cant;
    float[] valores = new float[100];
    int pos = 0;

    public Material verde;
    public Material amarillo;
    public Material naranja;
    public Material rojo;

    private void Start()
    {
        avg = 25;
        cant = 0;
        for (int i = 0; i < 100; i++) valores[i] = 0;

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "punto")
        {
            cant++;
            //pos = (pos+1) % 99;
            //avg += other.GetComponent<puntos>().vlr() / 100;
            //avg -= valores[pos];
            //valores[pos] = other.GetComponent<puntos>().vlr() / 100;
            avg = ((avg * (cant - 1)) + other.GetComponent<puntos>().vlr()) / (cant);
            Destroy(other.gameObject);
            //Debug.Log("Objeto destruido");
        }
    }

    public float getAvg()
    {
        return avg;
    }
}



