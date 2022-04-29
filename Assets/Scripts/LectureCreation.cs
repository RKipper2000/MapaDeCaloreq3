using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectureCreation : MonoBehaviour
{
    public GameObject puntos;

    void Update() {
        int hijos = this.gameObject.transform.childCount;
        Transform hijo = this.gameObject.transform.GetChild(Random.Range(0, hijos));
        Instantiate(puntos, new Vector3(hijo.position.x, hijo.position.y), Quaternion.identity);
    }
}
