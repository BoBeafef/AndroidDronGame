using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowerFocusOn : MonoBehaviour
{
    // ��'���, �� ���� �����������
    public Transform target;
    public Transform muzzle;
    public double maxDistanse = 20f;
    void Update()
    {
        // ����������, �� ����������� ����
        double distanse = Math.Sqrt((muzzle.position.x - target.position.x) * (muzzle.position.x - target.position.x)
            + (muzzle.position.y - target.position.y) * (muzzle.position.y - target.position.y)
            + (muzzle.position.z - target.position.z) * (muzzle.position.z - target.position.z));
        if (target != null && distanse < maxDistanse)
        {
            Vector3 targetPosition = new Vector3(target.position.x, transform.position.y, target.position.z);

            // ������� ��'��� �������� �� ����
            transform.LookAt(targetPosition) ;
            Vector3 muzzletargetPosition = new Vector3(target.position.x, target.position.y, target.position.z);

            muzzle.transform.LookAt(muzzletargetPosition);
        }
    }
}
