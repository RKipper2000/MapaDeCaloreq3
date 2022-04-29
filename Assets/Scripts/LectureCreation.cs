using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectureCreation : MonoBehaviour
{
    public GameObject puntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        int hijos = this.gameObject.transform.childCount;
        Transform hijo = this.gameObject.transform.GetChild(Random.Range(0, hijos));
        Instantiate(puntos, new Vector3(hijo.position.x, hijo.position.y), Quaternion.identity);
    }
}
