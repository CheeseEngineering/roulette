using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public  float rotationSpeed;
    void Start()
    {
       
    }


    void Update()
    {
        // ��Ŭ�� Ȯ��
        bool isLeftDown = Input.GetMouseButtonDown(0);
        // ��Ŭ�� Ȯ��
        bool isRightDown = Input.GetMouseButtonDown(1);
        // ��Ŭ���� z�� 10��ŭ
        if (isLeftDown)
        {
            rotationSpeed = 10 ;
        }
        // ��Ŭ���� z�� -10��ŭ
        else if (isRightDown)
        {
            rotationSpeed = -10 ;
        }
        // ȸ��
        this.transform.Rotate(0, 0, rotationSpeed);
        // ȸ���ӵ� ����
        rotationSpeed *= 0.96f;

    }
}
