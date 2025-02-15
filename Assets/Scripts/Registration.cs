using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    [SerializeField] private Text UniqueIdText;

    string sysInfo;

    void Start()
    {
        sysInfo = SystemInfo.deviceUniqueIdentifier;
        UniqueIdText.text= sysInfo;

    }

    void Update()
    {
        
    }
}
