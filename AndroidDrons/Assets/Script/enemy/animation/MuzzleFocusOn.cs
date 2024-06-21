using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFocusOn : MonoBehaviour
{
    // ��'���, �� ���� �����������
    public Transform muzzle;

    void Update()
    {
        // ����������, �� ����������� ����
        if (muzzle != null)
        {
            Vector3 targetPosition = new Vector3(muzzle.position.x, muzzle.position.y, muzzle.position.z);

            // ������� ��'��� �������� �� ����
            transform.LookAt(targetPosition) ;
        }
    }
}
