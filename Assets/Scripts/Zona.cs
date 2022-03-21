using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona : MonoBehaviour
{
    List<puntos> lecturasEnZona;
    int cant = 0;

    void addPunto(puntos p)
    {
        lecturasEnZona.Add(p);
        return;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "punto")
        {
            // puntos p1 = 
            // addPunto(other);
            Destroy(other.gameObject);
            cant += 1;

        }
    }

    public int cantLect()
    {
        return lecturasEnZona.Count;
    }

    public float promedio()
    {
        float avg = 0;
        for (int i=0; i<lecturasEnZona.Count; i++)
        {
            avg = avg + lecturasEnZona[i].getValor();
        }
        return avg;
    }
    
}
/*
public class PlayerMovement : MonoBehaviour {
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Rock") {
            Destroy(other.gameObject);
            ScoreScript.scoreCount += 1;
        }
        if (other.tag == "Power") {
            Destroy(other.gameObject);
            StartCoroutine("power");
        }
    }

    IEnumerator power(){
        transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y, transform.localScale.z);
        yield return new WaitForSecondsRealtime(6);
        transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y, transform.localScale.z);
    }

 */

