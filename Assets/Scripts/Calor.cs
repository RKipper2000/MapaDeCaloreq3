using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calor : MonoBehaviour
{
    public Material verde;
    public Material amarillo;
    public Material naranja;
    public Material rojo;

    public GameObject zona;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float avg = zona.GetComponent<Zona>().getAvg();
        if (avg >= 0 && avg <50)
        {
            zona.GetComponent<MeshRenderer>().material = verde;
        }
        else if (avg >= 50 && avg < 100)
        {
            zona.GetComponent<MeshRenderer>().material = amarillo;
        }
        else if (avg >= 10 && avg < 200)
        {
            zona.GetComponent<MeshRenderer>().material = naranja;
        }
        else if (avg > 200)
        {
            zona.GetComponent<MeshRenderer>().material = rojo;
        }
    }
}
