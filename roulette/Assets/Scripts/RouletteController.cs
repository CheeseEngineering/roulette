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
        // 좌클릭 확인
        bool isLeftDown = Input.GetMouseButtonDown(0);
        // 우클릭 확인
        bool isRightDown = Input.GetMouseButtonDown(1);
        // 좌클릭시 z축 10만큼
        if (isLeftDown)
        {
            rotationSpeed = 10 ;
        }
        // 우클릭시 z축 -10만큼
        else if (isRightDown)
        {
            rotationSpeed = -10 ;
        }
        // 회전
        this.transform.Rotate(0, 0, rotationSpeed);
        // 회전속도 감소
        rotationSpeed *= 0.96f;

    }
}
