using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float speed = 2.0f; // �������� ��������
    public float maxRotation = 10.0f; // ������������ ��������� ��������

    private float initialZRotation;

    void Start()
    {
        initialZRotation = transform.eulerAngles.z;
    }

    void Update()
    {
        // ��������� ���� �� ������ ���������
        float zRotation = initialZRotation + maxRotation * Mathf.Sin(Time.time * speed);
        // ��������� �������� ������ ��� Z
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, zRotation);
    }
}