using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class API : MonoBehaviour
{
    const string ENDPOINT = "http://coronavirusapi.com/time_series.csv";
 

    public void GetTimeData()
    {
        StartCoroutine(GetTimeDataRoutine());
    }

    IEnumerator GetTimeDataRoutine()
    {
        UnityWebRequest request = UnityWebRequest.Get(ENDPOINT);
        yield return request.SendWebRequest();


        if(request.isNetworkError)
        {
            Debug.Log("Network Error");

        }
        else
        {
            Debug.Log(request.downloadHandler.text);
        }
    }

    void ParseData(string data)
    {

    }
}
