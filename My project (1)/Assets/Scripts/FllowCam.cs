using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FllowCam : MonoBehaviour
{
    public Player_Key playerkey;
    public Vector3 offset; // �÷��̾�� ī�޶� ������ �Ÿ��Դϴ�.

    void Update()
    {
        // �÷��̾��� ���� ��ǥ�� offset�� ���� ī�޶� ��ġ�� �����մϴ�.
        transform.position = playerkey.transform.position + offset;
    }
}
