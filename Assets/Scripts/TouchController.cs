using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    PlayerController PlayerController;
    float x = 0;

    private void Awake()
    {
        PlayerController = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        x = 0;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x > Screen.width / 2) x = 1;                    // �������� ������.
            else if (touch.position.x < Screen.width / 2) x = -1;              // �������� �����.
        }

        float keyboardInput = Input.GetAxis("Horizontal");

        // ���� ���� ���� � ����������, �������������� x.
        if (keyboardInput != 0)
        {
            x = keyboardInput;
        }

        PlayerController.MoveCharacter(x);
    }
}
