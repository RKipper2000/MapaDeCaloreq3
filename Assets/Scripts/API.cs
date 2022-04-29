using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class API : MonoBehaviour
{
    string results;
    public IEnumerator GetData()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://localhost:3000/api/getLogs");
        yield return www.Send();

        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Show results as text
            Debug.Log(www.downloadHandler.text);

            // Or retrieve results as binary data
            results = www.downloadHandler.text;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetData());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(results);
        
    }
}
