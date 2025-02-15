using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    [Header("������� ��������")]
    [SerializeField] float speed = 75f;

    [Header("�������� ����� �����������")]
    [SerializeField] private float interval = 10f;

    [Header("�������� ����� �����������")]
    [SerializeField] private float speedUp = 0.01f;

    [Header("�����, ��������� � ������")]
    private float elapsedTime = 0f;
    
    [Header("�������� ���� �����-������")]
    [SerializeField] private float moveSpeed = 25f;

    public float Speed { get { return speed; } set { speed = value; } }
    public bool IsGame { get; set; }
    public float MoveSpeed { get { return moveSpeed; } set { moveSpeed = value; } }

    [SerializeField] private GameObject grass;

    void Start()
    {
        IsGame = true;
    }

    void Update()
    {
        if (IsGame)
        {
            UpdateSpeedOverTime();
        }
    }

    void UpdateSpeedOverTime()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= interval)
        {
            Time.timeScale += speedUp;
            elapsedTime = 0f;
        }
    }

    public void GrassOff()
    {
        grass.SetActive(true);
    }

}
