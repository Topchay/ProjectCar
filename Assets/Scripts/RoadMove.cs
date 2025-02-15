using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{
    GameSetting GameSetting;

    private const float  resetPositionZ = -20f; // ������� Z, ��� ���������� ������� ������ ������������
    private const float startPositionZ = 20f;  // ��������� ������� Z

    private void Awake()
    {
        GameSetting = FindObjectOfType<GameSetting>();
    }

    void Update()
    {
        MoveRoad();
    }

    void MoveRoad()
    {
        transform.Translate(Vector3.back * GameSetting.Speed * Time.deltaTime);

        if (transform.position.z <= resetPositionZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, startPositionZ);
        }
    }
}
