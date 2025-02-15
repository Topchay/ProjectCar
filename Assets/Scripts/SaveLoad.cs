using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;

public class SaveLoad:MonoBehaviour
{
    private void Start()
    {
        print(Application.persistentDataPath);
        Save();
    }

    public void Save()
    {
        var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ftgames.ru/Record");
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";
        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            string json = "{\"user\":\"test\"," +
                          "\"password\":\"bla\"}";
            streamWriter.Write(json);
        }
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
        }
    }
}