using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaPuntos : MonoBehaviour
{
    public GameObject puntos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawns());
    }
    
    private IEnumerator Spawns()
    {
        while (true)
        {
            Instantiate(puntos, new Vector3(Random.Range(-12.5f, 7.5f), Random.Range(-12.5f, 7.5f)), Quaternion.identity);

            yield return new WaitForSeconds(3);
        }
    }
    
}
