using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class TelegramSender : MonoBehaviour
{
    public string serverUrl = "t.me/VprokGameBot";

    public void SendMessageToTelegram(string message)
    {
        StartCoroutine(SendMessageCoroutine(message));
    }

    private IEnumerator SendMessageCoroutine(string message)
    {
        UnityWebRequest www = new UnityWebRequest(serverUrl, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(message);
        www.uploadHandler = new UploadHandlerRaw(bodyRaw);
        www.downloadHandler = new DownloadHandlerBuffer();
        www.SetRequestHeader("Content-Type", "text/plain");

        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error sending message: " + www.error);
        }
        else
        {
            Debug.Log("Message sent: " + www.downloadHandler.text);
        }
    }
}