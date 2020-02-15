﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float WorkSpeed = 0.3f;
    private Vector3 PlayerScale;

    // Start is called before the first frame update
    void Start()
    {
        PlayerScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        var time = Time.deltaTime;
        if (Input.GetAxis("Horizontal") > 0)
        {

            //右
            transform.Translate(WorkSpeed * time, 0, 0);
            //向き変更
            transform.localScale = new Vector3(PlayerScale.x, PlayerScale.y, PlayerScale.z);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            //左
            transform.Translate(-WorkSpeed * time, 0, 0);
            //向き変更
            transform.localScale = new Vector3(-PlayerScale.x, PlayerScale.y, PlayerScale.z);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            //上
            transform.Translate(0, WorkSpeed * time, 0);
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            //下
            transform.Translate(0, -WorkSpeed * time, 0);
        }


 


    }
}